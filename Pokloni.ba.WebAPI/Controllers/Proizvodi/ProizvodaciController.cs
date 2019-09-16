
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    public class ProizvodaciController : BaseController<IProizvodacPoklonaService, ProizvodacPoklona>
    {
        public ProizvodaciController(IProizvodacPoklonaService service):base(service)
        {

        }
    }
}