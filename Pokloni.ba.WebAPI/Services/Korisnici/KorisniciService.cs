using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Pokloni.ba.Model;
using Pokloni.ba.Model.Requests;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Pokloni.ba.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public KorisniciService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper; 
        }

        public static string GenerateSalt()
        {
            var buff = new Byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public IEnumerable<Model.Korisnik> Get()
        {
            var list = _db.Korisnik.Include(k=>k.Uloga).ToList();

            return _mapper.Map<IEnumerable<Model.Korisnik>>(list);
        }

        public Model.Korisnik GetById(int id)
        {
            var user = _db.Korisnik.Find(id);
            if (user == null) throw new ServerException(Constants.NotFoundErrorMessage + id);

            var temp = _mapper.Map<Model.Korisnik>(user);

            return temp;
        }

        public Model.Korisnik GetByUsername(string username)
        {
            var user = _db.Korisnik.Where(k => k.Username == username || k.Email == username).FirstOrDefault();
            if (user == null) throw new ServerException(Constants.NotFoundErrorMessage + username);

            var temp = _mapper.Map<Model.Korisnik>(user);

            return temp;
        }

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var alreadyExists = _db.Korisnik.Where(k => k.Username == request.Username || k.Email == request.Email).FirstOrDefault();
            if (alreadyExists != null)
                throw new UserException("Korisnik sa tim nazivom/emailom već postoji!");

            if (request.Password != request.PasswordConfirmation) throw new UserException("Passwordi nisu jednaki!");

            var temp = _mapper.Map<Database.Korisnik>(request);

            //Automatski postavlja korisnicku ulogau, ukoliko nije drugacije specifirano od strane administratora
            temp.UlogaId = (request.UlogaId != 0) ? request.UlogaId : _db.Uloga.Where(x => x.Naziv == Roles.User).Select(y => y.UlogaId).FirstOrDefault();

            temp.LozinkaSalt = GenerateSalt();
            temp.LozinkaHash = GenerateHash(temp.LozinkaSalt, request.Password);

            var korisnikDetails = new KorisnikDetails();
            _db.KorisnikDetails.Add(korisnikDetails);
            _db.SaveChanges();
            temp.KorisnikDetailsId = korisnikDetails.KorisnikDetailsId;

            _db.Korisnik.Add(temp);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(temp);
        }

        public Model.Korisnik Update(KorisniciUpdateRequest request, int id)
        {
            if (request.Password != request.PasswordConfirmation) throw new UserException("Passwordi nisu jednaki!");

            var x = _db.Korisnik.Where(s => s.KorisnikId == id).FirstOrDefault()??throw new Exception(Constants.NotFoundErrorMessage + id);
            _mapper.Map(request, x);

            _db.Update(x);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(x);
        }

        public void Delete(int id)
        {
            var temp = _db.Korisnik.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);
            var details = _db.KorisnikDetails.Find(temp.KorisnikDetailsId);

            _db.Korisnik.Remove(temp);
            _db.KorisnikDetails.Remove(details);

            _db.SaveChanges();
        }

        public Model.Korisnik Authenticiraj(string username, string password)
        {
            var model = _db.Korisnik.Include(c=>c.Uloga).Where(k => k.Username == username).FirstOrDefault();

            if(model != null)
            {
                var newHash = GenerateHash(model.LozinkaSalt, password);
                if(newHash == model.LozinkaHash)
                {
                    model.DatumZadnjegLogiranja = DateTime.Now;
                    model.Status = true;
                    _db.Korisnik.Update(model);
                    _db.SaveChanges();
                    return _mapper.Map<Model.Korisnik>(model);
                }
            }
            return null;
        }

        public void ResetPassword(string email)
        {
            var user = _db.Korisnik.Where(k => k.Email == email).FirstOrDefault()?? throw new ServerException(Constants.NotFoundErrorMessage + email);


        }
    }
}
