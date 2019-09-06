using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.WebAPI.Services.Korisnici;

namespace Pokloni.ba.WebAPI.Controllers.Korisnici
{
    public class UlogeController : BaseController<IUlogeService, Uloga>
    {
        public UlogeController(IUlogeService service):base(service)
        {

        }
    }
}