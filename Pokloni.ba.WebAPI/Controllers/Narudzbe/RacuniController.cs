using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Narudzba;
using Pokloni.ba.WebAPI.Services.Narudzbe;

namespace Pokloni.ba.WebAPI.Controllers.Narudzbe
{
    public class RacuniController : BaseController<IRacunService ,RacunVM>
    {
        public RacuniController(IRacunService service):base(service)
        {

        }
    }
}