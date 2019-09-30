using AutoMapper;
using Pokloni.ba.Model.Requests;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.Model.Requests.Narudzba;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Database;

namespace Pokloni.ba.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            #region Korisnici
            CreateMap<Database.Korisnik, Model.Korisnik>();

            CreateMap<KorisniciInsertRequest, Database.Korisnik>();

            CreateMap<KorisniciUpdateRequest, Database.Korisnik>();

            CreateMap<KorisniciDetailsGetRequest, Database.KorisnikDetails>().ReverseMap();

            CreateMap<Model.Requests.Korisnici.Uloga, Database.Uloga>().ReverseMap();
            #endregion

            #region Proizvodi
            CreateMap<Database.ProizvodacPoklona, Model.Requests.Proizvodi.ProizvodacPoklona>().ReverseMap();

            CreateMap<Database.Kategorija, Kategorije>().ReverseMap();

            CreateMap<Database.Proizvod, ProizvodVM>().ReverseMap();

            CreateMap<Database.Ocjena, OcjenaVM>().ReverseMap();

            #endregion

            #region Dostava
            CreateMap<Database.Dostava, Model.Requests.Dostava.Dostava>().ReverseMap();

            #endregion

            #region Narudzbe
            CreateMap<Database.Racun, RacunVM>().ReverseMap();

            CreateMap<Database.Narudzba, NarudzbaVM>().ReverseMap();

            CreateMap<Database.NarudzbaDetails, NarudzbaDetailsVM>().ReverseMap();
            #endregion
        }
    }
}
