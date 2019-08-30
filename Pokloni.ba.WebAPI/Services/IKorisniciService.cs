using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokloni.ba.WebAPI.Services
{
    public interface IKorisniciService
    {
        IEnumerable<Model.Korisnik> Get();

        Model.Korisnik Insert(Model.Requests.KorisniciInsertRequest request);
    }
}
