using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Services;

namespace Pokloni.ba.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerator<Model.Korisnik>> Get()
        {
            var korisnici = _service.Get();

            return Ok(korisnici);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Korisnik> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("[action]/{username}")]
        public ActionResult<Model.Korisnik> GetByUsername(string username)
        {
            return _service.GetByUsername(username);
        }

        [HttpPost]
        public Model.Korisnik Insert(Model.Requests.KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Korisnik Update(Model.Requests.KorisniciUpdateRequest request, int id)
        {
            return _service.Update(request, id);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}