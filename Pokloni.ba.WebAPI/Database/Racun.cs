using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class Racun
    {
        public int RacunId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public decimal? CijenaBezPdv { get; set; }
        public decimal? CijenaSaPdv { get; set; }
        public string VrstaPlacanja { get; set; }
        public int? NarudzbaId { get; set; }

        public virtual Narudzba Narudzba { get; set; }
    }
}
