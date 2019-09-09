using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers.Proizvodi
{
    public class KategorijeController : BaseController<IKategorijeService, Model.Requests.Proizvodi.Kategorije>
    {
        public KategorijeController(IKategorijeService service) : base(service)
        {

        }
    }
}