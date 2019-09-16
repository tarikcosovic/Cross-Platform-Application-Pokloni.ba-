using System;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class ProizvodacPoklona
    {
        public ProizvodacPoklona()
        {
            Proizvod = new HashSet<Proizvod>();
        }

        public int ProizvodacPoklonaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaMinimised { get; set; }

        public virtual ICollection<Proizvod> Proizvod { get; set; }
    }
}
