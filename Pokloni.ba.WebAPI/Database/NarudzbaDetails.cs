using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class NarudzbaDetails
    {
        public int NarudzbaDetailsId { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int? Kolicina { get; set; }
        public decimal? Popust { get; set; }
        public decimal? Ukupno { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
