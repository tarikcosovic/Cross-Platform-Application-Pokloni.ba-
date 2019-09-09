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
    public class KategorijeService : IKategorijeService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public KategorijeService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<Kategorije> Get()
        {
            var temp = _db.Kategorija.ToList();

            return _mapper.Map<IEnumerable<Kategorije>>(temp);
        }

        public Kategorije GetById(int id)
        {
            var temp = _db.Kategorija.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<Kategorije>(temp);
        }

        public Kategorije Insert(Kategorije request)
        {
            var validation1 = _db.Kategorija.Where(x => x.Naziv == request.Naziv).FirstOrDefault();
            if (validation1 != null)
                throw new UserException(Constants.AlreadyExistsErrorMessag + request.Naziv);

            var temp = _mapper.Map<Database.Kategorija>(request);

            _db.Kategorija.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public Kategorije Update(Kategorije request, int id)
        {
            var temp = _db.Kategorija.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Kategorija.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Kategorija.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.Kategorija.Remove(temp);
            _db.SaveChanges();
        }
    }
}
