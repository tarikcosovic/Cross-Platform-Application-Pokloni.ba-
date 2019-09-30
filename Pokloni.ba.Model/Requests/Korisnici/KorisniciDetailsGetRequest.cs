using System.ComponentModel.DataAnnotations;

namespace Pokloni.ba.Model.Requests.Korisnici
{
    public class KorisniciDetailsGetRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DrzavaStanovanja { get; set; }
        public string GradStanovanja { get; set; }
        public string PostalCode { get; set; }
        public string AdresaStanovanja { get; set; }
        public string BrojTelefona { get; set; }
    }
}
