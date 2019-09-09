using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;
using ProizvodacPoklona = Pokloni.ba.Model.Requests.Proizvodi.ProizvodacPoklona;

namespace Pokloni.ba.WebAPI.Services.Proizvodi
{
    public class ProizvodacPoklonaService : IProizvodacPoklonaService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public ProizvodacPoklonaService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<ProizvodacPoklona> Get()
        {
            var temp = _db.ProizvodacPoklona.ToList();

            return _mapper.Map<IEnumerable<ProizvodacPoklona>>(temp);
        }

        public ProizvodacPoklona GetById(int id)
        {
            var temp = _db.ProizvodacPoklona.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<ProizvodacPoklona>(temp);
        }

        public ProizvodacPoklona Insert(ProizvodacPoklona request)
        {
            var validation1 = _db.ProizvodacPoklona.Where(x => x.Naziv == request.Naziv).FirstOrDefault();
            if (validation1 != null)
                throw new UserException(Constants.AlreadyExistsErrorMessag + request.Naziv);

            var temp = _mapper.Map<Database.ProizvodacPoklona>(request);

            _db.ProizvodacPoklona.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public ProizvodacPoklona Update(ProizvodacPoklona request, int id)
        {
            var temp = _db.ProizvodacPoklona.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.ProizvodacPoklona.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.ProizvodacPoklona.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.ProizvodacPoklona.Remove(temp);
            _db.SaveChanges();
        }

    }
}
