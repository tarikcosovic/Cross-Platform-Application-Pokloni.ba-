using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Dostava
{
    public class Dostava
    {
        public int? DostavljacId { get; set; }
        public string DrzavaDostave { get; set; }
        public string GradDostave { get; set; }
        public string PostalCode { get; set; }
        public string AdresaDostave { get; set; }
        public string KontaktTelefon { get; set; }
        public DateTime? DatumSlanja { get; set; }
        public DateTime? DatumPreuzimanja { get; set; }
    }
}
