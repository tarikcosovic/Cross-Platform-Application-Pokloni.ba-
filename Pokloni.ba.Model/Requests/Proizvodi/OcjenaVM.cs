using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Proizvodi
{
    public class OcjenaVM
    {
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public int NumerickaOcjena { get; set; }
        public string Komentar { get; set; }
    }
}
