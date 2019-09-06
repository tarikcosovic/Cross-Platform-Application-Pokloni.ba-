using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    public class ProizvodaciController : BaseController<IProizvodacPoklonaService, ProizvodacPoklona>
    {
        public ProizvodaciController(IProizvodacPoklonaService service):base(service)
        {

        }
    }
}