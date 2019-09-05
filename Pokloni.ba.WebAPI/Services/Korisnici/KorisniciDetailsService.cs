using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;

namespace Pokloni.ba.WebAPI.Services
{
    public class KorisniciDetailsService : IKorisniciDetailsService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;

        public KorisniciDetailsService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<KorisniciDetailsGetRequest> Get()
        {
            var temp = _db.KorisnikDetails.ToList();

            return _mapper.Map<IEnumerable<Model.Requests.Korisnici.KorisniciDetailsGetRequest>>(temp);
        }

        public KorisniciDetailsGetRequest GetById(int id)
        {
            var temp = _db.KorisnikDetails.Find(id)??throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<KorisniciDetailsGetRequest>(temp);
        }

        public KorisniciDetailsGetRequest Update(KorisniciDetailsGetRequest request, int id)
        {
            var model = _db.KorisnikDetails.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, model);

            _db.Update(model);
            _db.SaveChanges();

            return request;
        }
    }
}
