using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Services
{
    public interface IKorisniciDetailsService
    {
        IEnumerable<Model.KorisniciDetailsGetRequest> Get();

        Model.KorisniciDetailsGetRequest GetById(int id);
    }
}
