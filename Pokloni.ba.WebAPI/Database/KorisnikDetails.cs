using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class KorisnikDetails
    {
        public KorisnikDetails()
        {
            Korisnik = new HashSet<Korisnik>();
        }

        public int KorisnikDetailsId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DrzavaStanovanja { get; set; }
        public string GradStanovanja { get; set; }
        public string PostalCode { get; set; }
        public string AdresaStanovanja { get; set; }
        public string BrojTelefona { get; set; }

        public virtual ICollection<Korisnik> Korisnik { get; set; }
    }
}
