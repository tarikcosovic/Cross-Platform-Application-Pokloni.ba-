using AutoMapper;

namespace Pokloni.ba.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();

            CreateMap<Model.Requests.KorisniciInsertRequest, Database.Korisnik>();
        }
    }
}
