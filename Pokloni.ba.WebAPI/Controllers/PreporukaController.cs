using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Services;
using Pokloni.ba.WebAPI.Services.Narudzbe;
using Pokloni.ba.WebAPI.Services.Proizvodi;

namespace Pokloni.ba.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PreporukaController : Controller
    {
        private readonly IProizvodiService _proizvodiService;
        private readonly INarudzbaService _narudzbeService;
        private readonly INarudzbaDetailsService _narudzbeDetailsService;
        public PreporukaController(IProizvodiService proizvodiService, INarudzbaService narudzbeService , INarudzbaDetailsService narudzbeDetailsService)
        {
            _proizvodiService = proizvodiService;
            _narudzbeDetailsService = narudzbeDetailsService;
            _narudzbeService = narudzbeService;
        }

        [HttpGet("{id}")]
        public IActionResult PreporuceniProizvod(int id)
        {
            var narudzbe = _narudzbeService.Get().ToList();
            var narudzbeDetails = _narudzbeDetailsService.Get().ToList();

            List<ProizvodVM> listaKupljenihProizvoda = new List<ProizvodVM>();

            foreach(var item in narudzbe)
            {
                foreach(var detail in narudzbeDetails)
                {
                    if (item.KorisnikId != id || detail.NarudzbaId != item.NarudzbaId)
                        continue;

                    if(!listaKupljenihProizvoda.Contains(detail.Proizvod))
                        listaKupljenihProizvoda.Add(detail.Proizvod);
                }
                //Zaustavljamo dodavanje kupljenih elemenata nakon sto dodamo 3 na listu 
                if (listaKupljenihProizvoda.Count >= 3)
                    break;
            }

            List<ProizvodVM> preporuceni = new List<ProizvodVM>();
            List<ProizvodVM> preporuceniDodatni = new List<ProizvodVM>();
            foreach(var item in listaKupljenihProizvoda)
            {
                var preporuceniList = _proizvodiService.GetPreporuceniProizvodi(item.ProizvodId);
                //Uzima prvi element, tj. element sa najvisim koeficijentom slicnosti i ukoliko nije vec kupljen ili vec preporucen stavi ga na listu preporucenih
                if(preporuceniList.Count > 0 && !listaKupljenihProizvoda.Contains(preporuceniList[0]) && !preporuceni.Contains(preporuceniList[0]))
                    preporuceni.Add(preporuceniList[0]);

                //Uzimamo preporucene koji imaju manji koef. slicnosti kao rezervu prije dodjeljivanja random proizvoda u slucaju manjka podataka za generisanje
                if (preporuceniList.Count > 1)
                {
                    if (preporuceniList[1] != null && !listaKupljenihProizvoda.Contains(preporuceniList[1]) && !preporuceni.Contains(preporuceniList[1]))
                        preporuceniDodatni.Add(preporuceniList[1]);
                    if (preporuceniList[2] != null && preporuceniList.Count > 0 && !listaKupljenihProizvoda.Contains(preporuceniList[2]) && !preporuceni.Contains(preporuceniList[2]))
                        preporuceniDodatni.Add(preporuceniList[2]);
                }
            }

            if(preporuceni.Count < 3)
            {
                foreach(var item in preporuceniDodatni)
                    preporuceni.Add(item);
            }

            //Ukoliko nemamo najmanje 3 preporucena elementa niti dodatna(ugl. radi manjka podataka), dodjeljujemo random proizvod koji nije kupljen ili vec preporucen
            if (preporuceni.Count < 3)
            {
                var proizvodi = _proizvodiService.Get().ToList();

                foreach (var item in proizvodi)
                {
                    if (!listaKupljenihProizvoda.Contains(item) && !preporuceni.Contains(item))
                        preporuceni.Add(item);

                    if (preporuceni.Count >= 3) break;
                }
            }

            return Ok(preporuceni);
        }
    }
}