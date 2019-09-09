using AutoMapper;
using Pokloni.ba.Model.Requests.Narudzba;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokloni.ba.WebAPI.Services.Narudzbe
{
    public class RacunService : IRacunService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public RacunService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<RacunVM> Get()
        {
            var temp = _db.Racun.ToList();

            return _mapper.Map<IEnumerable<RacunVM>>(temp);
        }

        public RacunVM GetById(int id)
        {
            var temp = _db.Racun.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<RacunVM>(temp);
        }

        public RacunVM Insert(RacunVM request)
        {
            var temp = _mapper.Map<Database.Racun>(request);

            _db.Racun.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public RacunVM Update(RacunVM request, int id)
        {
            var temp = _db.Racun.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Racun.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Racun.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.Racun.Remove(temp);
            _db.SaveChanges();
        }
    }
}
