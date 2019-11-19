using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProizvodiController : BaseController<IProizvodiService, ProizvodVM>
    {
        IProizvodiService _service = null;
        public ProizvodiController(IProizvodiService service):base(service)
        {
            _service = service;
        }

        [HttpGet("[action]/{id}")]
        public int GetProizvodOcjena(int id)
        {
            return _service.GetProizvodOcjena(id);
        }

        [HttpGet("[action]/{id}")]
        public List<ProizvodVM> GetPreporuceni(int id)
        {
            return _service.GetPreporuceniProizvodi(id);
        }

        [HttpPut("[action]/{id}")]
        public ActionResult<ProizvodVM> UpdateProductInStock(int id, [FromBody]ProizvodVM request)
        {
            return Ok(_service.Update(request, id));
        }
    }
}
