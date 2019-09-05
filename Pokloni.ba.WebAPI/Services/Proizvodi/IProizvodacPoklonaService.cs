using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokloni.ba.Model.Requests.Proizvodi;

namespace Pokloni.ba.WebAPI.Services.Proizvodi
{
    public interface IProizvodacPoklonaService
    {
        IEnumerable<ProizvodacPoklona> Get();

        ProizvodacPoklona GetById(int id);

        ProizvodacPoklona Insert(ProizvodacPoklona request);

        ProizvodacPoklona Update(ProizvodacPoklona request, int id);

        void Delete(int id);
    }
}
