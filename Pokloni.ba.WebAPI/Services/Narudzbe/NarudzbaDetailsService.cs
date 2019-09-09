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
    public class NarudzbaDetailsService : INarudzbaDetailsService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public NarudzbaDetailsService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<NarudzbaDetailsVM> Get()
        {
            var temp = _db.NarudzbaDetails.ToList();

            return _mapper.Map<IEnumerable<NarudzbaDetailsVM>>(temp);
        }

        public NarudzbaDetailsVM GetById(int id)
        {
            var temp = _db.NarudzbaDetails.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<NarudzbaDetailsVM>(temp);
        }

        public NarudzbaDetailsVM Insert(NarudzbaDetailsVM request)
        {
            var temp = _mapper.Map<Database.NarudzbaDetails>(request);

            _db.NarudzbaDetails.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public NarudzbaDetailsVM Update(NarudzbaDetailsVM request, int id)
        {
            var temp = _db.NarudzbaDetails.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.NarudzbaDetails.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.NarudzbaDetails.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.NarudzbaDetails.Remove(temp);
            _db.SaveChanges();
        }
    }
}
