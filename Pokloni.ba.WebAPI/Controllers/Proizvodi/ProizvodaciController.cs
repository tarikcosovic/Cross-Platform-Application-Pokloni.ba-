using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodaciController : ControllerBase
    {
         private readonly IProizvodacPoklonaService _service;
        public ProizvodaciController(IProizvodacPoklonaService service)
        {
            _service = service;
        }

        [EnableQuery]
        [HttpGet]
        public ActionResult<IEnumerable<ProizvodacPoklona>> Get()
        {
            var temp = _service.Get();

            return Ok(temp);
        }

        [HttpGet("{id}")]
        public ActionResult<ProizvodacPoklona> GetById(int id)
        {
            var temp = _service.GetById(id);

            return Ok(temp);
        }

        [HttpPost]
        public ActionResult<ProizvodacPoklona> Insert(ProizvodacPoklona request)
        {
            var temp = _service.Insert(request);

            return Ok(temp);
        }

        [HttpPut("{id}")]
        public ActionResult<ProizvodacPoklona> Update(ProizvodacPoklona request, int id)
        {
            var temp = _service.Update(request, id);

            return Ok(temp);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}