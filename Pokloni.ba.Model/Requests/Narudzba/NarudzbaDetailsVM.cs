using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Narudzba
{
    public class NarudzbaDetailsVM
    {
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int? Kolicina { get; set; }
        public decimal? Popust { get; set; }
        public decimal? Ukupno { get; set; }
    }
}
