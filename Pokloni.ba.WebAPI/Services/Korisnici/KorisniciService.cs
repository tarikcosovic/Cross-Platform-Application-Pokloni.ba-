using AutoMapper;
using Pokloni.ba.Model.Requests;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Model.Korisnik> Get()
        {
            var list = _db.Korisnik.ToList();

            return _mapper.Map<IEnumerable<Model.Korisnik>>(list);
        }

        public Model.Korisnik GetById(int id)
        {
            var user = _db.Korisnik.Find(id);
            if (user == null) throw new Exception();

            var temp = _mapper.Map<Model.Korisnik>(user);

            return temp;
        }

        public Model.Korisnik GetByUsername(string username)
        {
            var user = _db.Korisnik.Where(k => k.Username == username || k.Email == username).FirstOrDefault();
            if (user == null) throw new Exception();

            var temp = _mapper.Map<Model.Korisnik>(user);

            return temp;
        }

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation) throw new UserException("Passwordi nisu jednaki!");

            var temp = _mapper.Map<Database.Korisnik>(request);

            var korisnikDetails = new KorisnikDetails();
            _db.KorisnikDetails.Add(korisnikDetails);
            _db.SaveChanges();

            temp.UlogaId = _db.Uloga.Where(x => x.Naziv == Roles.User).Select(y => y.UlogaId).FirstOrDefault();

            temp.KorisnikDetailsId = korisnikDetails.KorisnikDetailsId;
            temp.LozinkaHash = "test";
            temp.LozinkaSalt = "test";

            _db.Korisnik.Add(temp);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(temp);
        }

        public Model.Korisnik Update(KorisniciUpdateRequest request, int id)
        {
            if (request.Password != request.PasswordConfirmation) throw new UserException("Passwordi nisu jednaki!");

            var x = _db.Korisnik.Where(s => s.KorisnikId == id).FirstOrDefault()??throw new Exception();
            _mapper.Map(request, x);

            _db.Update(x);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(x);
        }

        public void Delete(int id)
        {
            var temp = _db.Korisnik.Find(id) ?? throw new Exception();
            var details = _db.KorisnikDetails.Find(temp.KorisnikDetailsId);

            _db.Korisnik.Remove(temp);
            _db.KorisnikDetails.Remove(details);

            _db.SaveChanges();
        }
    }
}
