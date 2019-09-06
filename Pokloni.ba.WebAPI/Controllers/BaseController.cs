using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Pokloni.ba.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T1, T2>: ControllerBase where T1:IBaseInterface<T2>
    {
        private readonly T1 _service;
        public BaseController(T1 service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IEnumerable<T2>> Get()
        {
            var temp = _service.Get();

            return Ok(temp);
        }

        [HttpGet("{id}")]
        public ActionResult<T2> GetById(int id)
        {
            var temp = _service.GetById(id);

            return Ok(temp);
        }

        [HttpPost]
        public ActionResult<T2> Insert(T2 request)
        {
            var temp = _service.Insert(request);

            return Ok(temp);
        }

        [HttpPut("{id}")]
        public ActionResult<T2> Update(T2 request, int id)
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