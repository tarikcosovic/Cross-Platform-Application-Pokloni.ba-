using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokloni.ba.Model.Requests.Korisnici
{
    public class Uloga
    {
        public int UlogaId { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Naziv { get; set; }

        [Required]
        [MinLength(3), MaxLength(500)]
        public string Opis { get; set; }

    }
}
