using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Narudzba
{
    public class NarudzbaVM
    {
        public int NarudzbaId { get; set; }
        public int KorisnikId { get; set; }
        public int? ZaposlenikId { get; set; }
        public int? DostavaId { get; set; }
        public string StatusPoruka { get; set; }
        public DateTime? DatumNarudzbe { get; set; }

        public virtual Dostava.Dostava Dostava { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Korisnik Zaposlenik { get; set; }
    }
}
