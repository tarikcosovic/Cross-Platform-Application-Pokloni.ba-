using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Dostava = new HashSet<Dostava>();
            NarudzbaKorisnik = new HashSet<Narudzba>();
            NarudzbaZaposlenik = new HashSet<Narudzba>();
            Ocjena = new HashSet<Ocjena>();
        }

        public int KorisnikId { get; set; }
        public int? KorisnikDetailsId { get; set; }
        public int? UlogaId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }

        public virtual KorisnikDetails KorisnikDetails { get; set; }
        public virtual Uloga Uloga { get; set; }
        public virtual ICollection<Dostava> Dostava { get; set; }
        public virtual ICollection<Narudzba> NarudzbaKorisnik { get; set; }
        public virtual ICollection<Narudzba> NarudzbaZaposlenik { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
    }
}
