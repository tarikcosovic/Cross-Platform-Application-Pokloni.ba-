using System;
using System.Collections.Generic;

namespace Pokloni.ba.Model.Requests.Proizvodi
{
    public partial class Ocjena
    {
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public int NumerickaOcjena { get; set; }
        public string Komentar { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
