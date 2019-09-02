using System;
using System.Collections.Generic;
using System.Text;

namespace Pokloni.ba.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public int KorisnikDetailsId { get; set; }
        public int UlogaId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
