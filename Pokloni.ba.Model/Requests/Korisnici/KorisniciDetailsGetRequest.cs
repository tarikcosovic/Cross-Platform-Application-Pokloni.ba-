using System.ComponentModel.DataAnnotations;

namespace Pokloni.ba.Model.Requests.Korisnici
{
    public class KorisniciDetailsGetRequest
    {
        [MinLength(2), MaxLength(50)]
        public string Ime { get; set; }
        [MinLength(2), MaxLength(50)]
        public string Prezime { get; set; }
        [MinLength(2), MaxLength(100)]
        public string DrzavaStanovanja { get; set; }
        [MinLength(2), MaxLength(100)]
        public string GradStanovanja { get; set; }
        [MinLength(2), MaxLength(20)]
        public string PostalCode { get; set; }
        [MinLength(2), MaxLength(100)]
        public string AdresaStanovanja { get; set; }
        [MinLength(2), MaxLength(20)]
        public string BrojTelefona { get; set; }
    }
}
