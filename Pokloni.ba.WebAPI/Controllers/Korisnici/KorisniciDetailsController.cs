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
    public class KorisniciDetailsController : BaseController<IKorisniciDetailsService, Model.Requests.Korisnici.KorisniciDetailsGetRequest>
    {
        public KorisniciDetailsController(IKorisniciDetailsService service) :base(service)
        {

        }
    }
} 