using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokloni.ba.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Password { get; set; }
        [MinLength(3), MaxLength(50)]
        public string PasswordConfirmation { get; set; }

        public int UlogaId { get; set; }
        public bool Status { get; set; }
    }
}
