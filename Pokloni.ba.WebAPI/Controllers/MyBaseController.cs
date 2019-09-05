using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pokloni.ba.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyBaseController<X, Y>:ControllerBase
    {
        private readonly X _service;
        public MyBaseController(X service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Y>> Get()
        {
           // var temp = _service.Get();

            return Ok();
        }
    }
}