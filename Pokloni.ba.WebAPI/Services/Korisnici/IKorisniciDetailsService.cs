using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Services
{
    public interface IKorisniciDetailsService
    {
        IEnumerable<Model.Requests.Korisnici.KorisniciDetailsGetRequest> Get();

        Model.Requests.Korisnici.KorisniciDetailsGetRequest GetById(int id);

        Model.Requests.Korisnici.KorisniciDetailsGetRequest Update(Model.Requests.Korisnici.KorisniciDetailsGetRequest request, int id);
    }
}
