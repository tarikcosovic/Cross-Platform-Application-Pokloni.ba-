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

            CreateMap<Model.Requests.Korisnici.KorisniciDetailsGetRequest, Database.KorisnikDetails>().ReverseMap();

            CreateMap<Model.Requests.Korisnici.Uloga, Database.Uloga>().ReverseMap();
            #endregion

            #region Proizvodi
            CreateMap<Database.ProizvodacPoklona, Model.Requests.Proizvodi.ProizvodacPoklona>().ReverseMap();


            #endregion
        }
    }
}
