using Pokloni.ba.Model.Requests;
using System.Collections.Generic;

namespace Pokloni.ba.WebAPI.Services
{
    public interface IKorisniciService
    {
        IEnumerable<Model.Korisnik> Get();

        Model.Korisnik GetById(int id);

        Model.Korisnik GetByUsername(string username);

        Model.Korisnik Insert(KorisniciInsertRequest request);

        Model.Korisnik Update(KorisniciUpdateRequest request, int id);

        void Delete(int id);
    }
}
