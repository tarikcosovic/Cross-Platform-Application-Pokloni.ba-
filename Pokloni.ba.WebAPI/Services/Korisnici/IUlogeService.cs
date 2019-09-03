using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokloni.ba.Model.Requests.Korisnici;

namespace Pokloni.ba.WebAPI.Services.Korisnici
{
    public interface IUlogeService
    {
        IEnumerable<Uloga> Get();

        Uloga GetById(int id);

        Uloga Insert(Uloga request);

        Uloga Update(Uloga request, int id);

        void Delete(int id);
    }
}
