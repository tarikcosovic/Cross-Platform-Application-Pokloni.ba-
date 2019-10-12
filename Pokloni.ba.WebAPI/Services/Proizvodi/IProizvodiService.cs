using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokloni.ba.WebAPI.Services.Proizvodi
{
    public interface IProizvodiService : IBaseInterface<ProizvodVM>
    {
        int GetProizvodOcjena(int id);
    }
}
