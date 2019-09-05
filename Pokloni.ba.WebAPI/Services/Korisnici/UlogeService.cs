using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.WebAPI.Exceptions;

namespace Pokloni.ba.WebAPI.Services.Korisnici
{
    public class UlogeService : IUlogeService
    {
        private readonly Database.PokloniContext _db;
        private readonly IMapper _mapper;

        public UlogeService(Database.PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<Uloga> Get()
        {
            var temp = _db.Uloga.ToList();

            return _mapper.Map<IEnumerable<Uloga>>(temp);
        }

        public Uloga GetById(int id)
        {
            var temp = _db.Uloga.Find(id)?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<Uloga>(temp);
        }

        public Uloga Insert(Uloga request)
        {
            var temp = _mapper.Map<Database.Uloga>(request);

            _db.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public Uloga Update(Uloga request, int id)
        {
            var temp = _db.Uloga.Find(id)?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Uloga.Find(id)??throw new ServerException(Constants.NotFoundErrorMessage + id);
            var adminCounter = _db.Uloga.Where(x => x.Naziv == Roles.Admin).Count();

            if (adminCounter <= 1 && temp.Naziv == Roles.Admin) throw new UserException("Nije dozvoljeno brisati jedinog preostalog admina");

            _db.Uloga.Remove(temp);
            _db.SaveChanges();
        }
    }
}
