using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.WebAPI.Services.Dostava;

namespace Pokloni.ba.WebAPI.Controllers.Dostava
{

    public class DostaveController : BaseController<IDostavaService, Model.Requests.Dostava.Dostava>
    {
        public DostaveController(IDostavaService service):base(service)
        {

        }
    }
}