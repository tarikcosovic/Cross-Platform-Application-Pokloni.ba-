using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.WebAPI.Services.Korisnici;

namespace Pokloni.ba.WebAPI.Controllers.Korisnici
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _service;
        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Uloga>> Get()
        {
            var temp = _service.Get();

            return Ok(temp);
        }

        [HttpGet("{id}")]
        public ActionResult<Uloga> GetById(int id)
        {
            var temp = _service.GetById(id);

            return Ok(temp);
        }

        [HttpPost]
        public ActionResult<Uloga> Insert(Uloga request)
        {
            var temp = _service.Insert(request);

            return Ok(temp);
        }

        [HttpPut("{id}")]
        public ActionResult<Uloga> Update(Uloga request, int id)
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