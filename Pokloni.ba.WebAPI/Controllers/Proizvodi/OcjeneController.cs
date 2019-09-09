using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    public class OcjeneController : BaseController<IOcjenaService, OcjenaVM>
    {
        public OcjeneController(IOcjenaService service) : base(service)
        {

        }
    }
}