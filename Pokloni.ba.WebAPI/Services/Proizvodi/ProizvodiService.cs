using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
            var temp = _db.Proizvod.ToList();

            return _mapper.Map<IEnumerable<ProizvodVM>>(temp);
        }

        public ProizvodVM GetById(int id)
        {
            var temp = _db.Proizvod.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<ProizvodVM>(temp);
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
