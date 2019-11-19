using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Pokloni.ba.Model.Requests.Dostava;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;

namespace Pokloni.ba.WebAPI.Services.Dostava
{
    public class DostavaService : IDostavaService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public DostavaService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<Model.Requests.Dostava.Dostava> Get()
        {
            var temp = _db.Dostava.ToList();

            return _mapper.Map<IEnumerable<Model.Requests.Dostava.Dostava>>(temp);
        }

        public Model.Requests.Dostava.Dostava GetById(int id)
        {
            var temp = _db.Dostava.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<Model.Requests.Dostava.Dostava>(temp);
        }

        public Model.Requests.Dostava.Dostava Insert(Model.Requests.Dostava.Dostava request)
        {
            var temp = _mapper.Map<Database.Dostava>(request);

            var test = _db.Dostava.Add(temp);
            _db.SaveChanges();

            request.DostavaId = test.Entity.DostavaId;
            return request;
        }

        public Model.Requests.Dostava.Dostava Update(Model.Requests.Dostava.Dostava request, int id)
        {
            var temp = _db.Dostava.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Dostava.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Dostava.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.Dostava.Remove(temp);
            _db.SaveChanges();
        }
    }
}
