using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OcjeneController : BaseController<IOcjenaService, OcjenaVM>
    {
        IOcjenaService _service = null;
        public OcjeneController(IOcjenaService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("[action]/{id}")]
        public int GetKorisnikOcjena(int id)
        {
            return _service.GetByKorisnik(id);
        }
    }
}