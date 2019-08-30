using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class Ocjena
    {
        public int ProizvodId { get; set; }
        public int KorisnikId { get; set; }
        public int NumerickaOcjena { get; set; }
        public string Komentar { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
