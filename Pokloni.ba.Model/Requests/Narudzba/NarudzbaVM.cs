using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Narudzba
{
    public class NarudzbaVM
    {
        public int KorisnikId { get; set; }
        public int? ZaposlenikId { get; set; }
        public int? DostavaId { get; set; }
        public string StatusPoruka { get; set; }
        public DateTime? DatumNarudzbe { get; set; }
    }
}
