using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            Korisnik = new HashSet<Korisnik>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Korisnik> Korisnik { get; set; }
    }
}
