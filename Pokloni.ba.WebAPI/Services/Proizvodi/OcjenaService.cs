using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;

namespace Pokloni.ba.WebAPI.Services.Proizvodi
{
    public class OcjenaService : IOcjenaService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public OcjenaService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<OcjenaVM> Get()
        {
            var temp = _db.Ocjena.Include(x=>x.Korisnik).ToList();

            return _mapper.Map<IEnumerable<OcjenaVM>>(temp);
        }

        public OcjenaVM GetById(int id)
        {
            var temp = _db.Ocjena.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<OcjenaVM>(temp);
        }

        public int GetByKorisnik(int id)
        {
            var temp = _db.Ocjena.Where(x => x.KorisnikId == id).FirstOrDefault();

            return temp.NumerickaOcjena;
        }

        public OcjenaVM Insert(OcjenaVM request)
        {
            var temp = _mapper.Map<Database.Ocjena>(request);

            _db.Ocjena.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public OcjenaVM Update(OcjenaVM request, int id)
        {
            var temp = _db.Ocjena.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Ocjena.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Ocjena.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.Ocjena.Remove(temp);
            _db.SaveChanges();
        }
    }
}
