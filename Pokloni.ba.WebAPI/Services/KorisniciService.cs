using AutoMapper;
using Pokloni.ba.Model;
using Pokloni.ba.Model.Requests;
using Pokloni.ba.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var temp = _mapper.Map<Database.Korisnik>(request);

            var korisnikDetails = new KorisnikDetails();
            _db.KorisnikDetails.Add(korisnikDetails);
            _db.SaveChanges();

            temp.UlogaId = 2;

            temp.KorisnikDetailsId = korisnikDetails.KorisnikDetailsId;
            temp.LozinkaHash = "test";
            temp.LozinkaSalt = "test";

            _db.Korisnik.Add(temp);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(temp);
        }
    }
}
