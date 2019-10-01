using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokloni.ba.Model.Requests.Proizvodi
{
    public class ProizvodVM
    {
        public int ProizvodId { get; set; }
        public int KategorijaId { get; set; }
        public int ProizvodacId { get; set; }
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public string Opis { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        public int StanjeNaLageru { get; set; }
        public byte[] Slika { get; set; }

        public Kategorije Kategorija { get; set; }
        public ProizvodacPoklona Proizvodac { get; set; }
        public ICollection<Ocjena> Ocjena { get; set; }
    }
}
