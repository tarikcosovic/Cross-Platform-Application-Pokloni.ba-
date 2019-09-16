using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model.Requests.Proizvodi
{
    public class ProizvodVM
    {
        public int KategorijaId { get; set; }
        public int ProizvodacId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public int StanjeNaLageru { get; set; }
    }
}
