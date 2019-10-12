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
    public class ProizvodiService : IProizvodiService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public ProizvodiService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<ProizvodVM> Get()
        {
            var temp = _db.Proizvod.Include(k=>k.Kategorija).Include(c=>c.Proizvodac).ToList();

            return _mapper.Map<IEnumerable<ProizvodVM>>(temp);
        }

        public ProizvodVM GetById(int id)
        {
            var temp = _db.Proizvod.Where(k => k.ProizvodId == id).Include(c => c.Ocjena).ThenInclude(s=>s.Korisnik).FirstOrDefault() ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<ProizvodVM>(temp);
        }
        public int GetProizvodOcjena(int id)
        {
            var ocjene = _db.Ocjena.Where(x => x.ProizvodId == id).ToList();

            int prosjcnaOcjena = 0;
            foreach(var ocjena in ocjene)
            {
                prosjcnaOcjena += ocjena.NumerickaOcjena;
            }
            if (ocjene.Count == 0)
                return 0;

            return prosjcnaOcjena / ocjene.Count();
        }

        public ProizvodVM Insert(ProizvodVM request)
        {
            var temp = _mapper.Map<Database.Proizvod>(request);

            _db.Proizvod.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public ProizvodVM Update(ProizvodVM request, int id)
        {
            var temp = _db.Proizvod.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Proizvod.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Proizvod.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.Proizvod.Remove(temp);
            _db.SaveChanges();
        }
    }
}
