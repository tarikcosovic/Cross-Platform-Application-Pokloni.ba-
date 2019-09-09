using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Narudzba
{
    public class RacunVM
    {
        public string BrojRacuna { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public decimal? CijenaBezPdv { get; set; }
        public decimal? CijenaSaPdv { get; set; }
        public string VrstaPlacanja { get; set; }
        public int? NarudzbaId { get; set; }
    }
}
