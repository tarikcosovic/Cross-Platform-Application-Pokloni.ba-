using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [EnableQuery]
        [Authorize]
        public ActionResult<IEnumerator<Model.Korisnik>> Get()
        {
            var korisnici = _service.Get();

            return Ok(korisnici);
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<Model.Korisnik> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("[action]/{username}")]
        [Authorize]
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
        [Authorize]
        public Model.Korisnik Update(Model.Requests.KorisniciUpdateRequest request, int id)
        {
            return _service.Update(request, id);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}