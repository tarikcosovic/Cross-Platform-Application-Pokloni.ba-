using AutoMapper;

namespace Pokloni.ba.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            #region Korisnici
            CreateMap<Database.Korisnik, Model.Korisnik>();

            CreateMap<Model.Requests.KorisniciInsertRequest, Database.Korisnik>();

            CreateMap<Model.Requests.KorisniciUpdateRequest, Database.Korisnik>();

            CreateMap<Model.KorisniciDetailsGetRequest, Database.KorisnikDetails>().ReverseMap();
            #endregion
        }
    }
}
