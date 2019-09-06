using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.WebAPI.Services.Korisnici;

namespace Pokloni.ba.WebAPI.Controllers
{
    public class DefaultController : BaseController<IUlogeService, Uloga>
    {
        public DefaultController(IUlogeService service):base(service)
        {
        }
    }
}