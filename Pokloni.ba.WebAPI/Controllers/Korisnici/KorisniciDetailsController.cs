using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.WebAPI.Services;

namespace Pokloni.ba.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciDetailsController : ControllerBase
    {
        private readonly IKorisniciDetailsService _service;

        public KorisniciDetailsController(IKorisniciDetailsService service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IEnumerator<Model.Requests.Korisnici.KorisniciDetailsGetRequest>> Get()
        {
            var korisniciDetails = _service.Get();

            return Ok(korisniciDetails);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Requests.Korisnici.KorisniciDetailsGetRequest> GetById(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPut("{id}")]
        public Model.Requests.Korisnici.KorisniciDetailsGetRequest Update(Model.Requests.Korisnici.KorisniciDetailsGetRequest request, int id)
        {
            return _service.Update(request, id);
        }
    }
} 