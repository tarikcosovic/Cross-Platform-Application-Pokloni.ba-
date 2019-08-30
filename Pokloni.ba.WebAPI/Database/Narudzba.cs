using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            NarudzbaDetails = new HashSet<NarudzbaDetails>();
            Racun = new HashSet<Racun>();
        }

        public int NarudzbaId { get; set; }
        public int KorisnikId { get; set; }
        public int? ZaposlenikId { get; set; }
        public int? DostavaId { get; set; }
        public string StatusPoruka { get; set; }
        public DateTime? DatumNarudzbe { get; set; }

        public virtual Dostava Dostava { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Korisnik Zaposlenik { get; set; }
        public virtual ICollection<NarudzbaDetails> NarudzbaDetails { get; set; }
        public virtual ICollection<Racun> Racun { get; set; }
    }
}
