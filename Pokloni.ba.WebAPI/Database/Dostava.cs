using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class Dostava
    {
        public Dostava()
        {
            Narudzba = new HashSet<Narudzba>();
        }

        public int DostavaId { get; set; }
        public int? DostavljacId { get; set; }
        public string DrzavaDostave { get; set; }
        public string GradDostave { get; set; }
        public string PostalCode { get; set; }
        public string AdresaDostave { get; set; }
        public string KontaktTelefon { get; set; }
        public DateTime? DatumSlanja { get; set; }
        public DateTime? DatumPreuzimanja { get; set; }

        public virtual Korisnik Dostavljac { get; set; }
        public virtual ICollection<Narudzba> Narudzba { get; set; }
    }
}
