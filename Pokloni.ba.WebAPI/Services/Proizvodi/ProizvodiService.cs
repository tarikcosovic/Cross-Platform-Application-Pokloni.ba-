using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.WebAPI.Database;
using Pokloni.ba.WebAPI.Exceptions;

namespace Pokloni.ba.WebAPI.Services.Proizvodi
{
    public class ProizvodiService : IProizvodiService
    {
        private readonly PokloniContext _db;
        private readonly IMapper _mapper;
        public ProizvodiService(PokloniContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<ProizvodVM> Get()
        {
            var temp = _db.Proizvod.Include(k=>k.Kategorija).Include(c=>c.Proizvodac).ToList();

            return _mapper.Map<IEnumerable<ProizvodVM>>(temp);
        }

        public ProizvodVM GetById(int id)
        {
            var temp = _db.Proizvod.Where(k => k.ProizvodId == id).Include(c => c.Ocjena).ThenInclude(s=>s.Korisnik).FirstOrDefault() ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            return _mapper.Map<ProizvodVM>(temp);
        }
        public int GetProizvodOcjena(int id)
        {
            var ocjene = _db.Ocjena.Where(x => x.ProizvodId == id).ToList();

            int prosjcnaOcjena = 0;
            foreach(var ocjena in ocjene)
            {
                prosjcnaOcjena += ocjena.NumerickaOcjena;
            }
            if (ocjene.Count == 0)
                return 0;

            return prosjcnaOcjena / ocjene.Count();
        }

        public ProizvodVM Insert(ProizvodVM request)
        {
            var temp = _mapper.Map<Database.Proizvod>(request);

            _db.Proizvod.Add(temp);
            _db.SaveChanges();

            return request;
        }

        public ProizvodVM Update(ProizvodVM request, int id)
        {
            var temp = _db.Proizvod.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _mapper.Map(request, temp);

            _db.Proizvod.Update(temp);
            _db.SaveChanges();

            return request;
        }

        public void Delete(int id)
        {
            var temp = _db.Proizvod.Find(id) ?? throw new ServerException(Constants.NotFoundErrorMessage + id);

            _db.Proizvod.Remove(temp);
            _db.SaveChanges();
        }

        public List<ProizvodVM> GetPreporuceniProizvodi(int ProizvodId)
        {
            //Liste u koju cemo popuniti proizvode, te njihove koeficijente slicnosti sa nasim proizvodom
            List<ProizvodVM> listaProizvoda = new List<ProizvodVM>();
            List<double> listaKoeficijenata = new List<double>();
            List<decimal> listaKoeficijentaSlicnosti = new List<decimal>();

            var model = _db.Proizvod.Find(ProizvodId) ?? throw new UserException(Constants.NotFoundErrorMessage + ProizvodId);
            var proizvodi = _db.Proizvod.ToList();
            var korisnici = _db.Korisnik.ToList();

            foreach (var item in proizvodi)
            {
                //Ukoliko je upoređeni proizvod, zahtjevani proizvod neka preskace iteraciju
                if (item.ProizvodId == ProizvodId)
                    continue;

                //Ocjene prvog proizvoda
                List<int> OcjenePrvogProizvoda = new List<int>();

                //Ocjene drugog proizvoda
                List<int> OcjeneDrugogProizvoda = new List<int>();

                //Dobavljamo ocjene proizvoda1,2 s tim da ih je ocjenio isti korisnik
                bool postoji = false;
                foreach(var korisnik in korisnici)
                {
                    var ocjena1 = _db.Ocjena.Where(k => k.KorisnikId == korisnik.KorisnikId && k.ProizvodId == ProizvodId).FirstOrDefault();
                    var ocjena2 = _db.Ocjena.Where(k => k.KorisnikId == korisnik.KorisnikId && k.ProizvodId == item.ProizvodId).FirstOrDefault();

                    if(ocjena1 != null && ocjena2 != null)
                    {
                        OcjenePrvogProizvoda.Add(ocjena1.NumerickaOcjena);
                        OcjeneDrugogProizvoda.Add(ocjena2.NumerickaOcjena);
                        postoji = true;
                    }
                }
                if (!postoji) continue;

                //Formula koef = (A * B) / (|A| * |B|)
                //Racunamo A * B
                double brojnik = 0;

                for (int i = 0; i < OcjenePrvogProizvoda.Count; i++)
                    brojnik += OcjenePrvogProizvoda[i] * OcjeneDrugogProizvoda[i];

                //Racunamo |A| i |B|
                double a = 0;
                double b = 0;
                for (int i = 0; i < OcjenePrvogProizvoda.Count; i++)
                {
                    a += Math.Pow(OcjenePrvogProizvoda[i], 2);
                    b += Math.Pow(OcjeneDrugogProizvoda[i], 2);
                }
                a = Math.Sqrt(a);
                b = Math.Sqrt(b);

                var nazivnik = a * b;
                //Racunamo koeficijent slicnosti
                var koeficijentSlicnosti = brojnik / nazivnik;

                listaKoeficijenata.Add(koeficijentSlicnosti);
                listaProizvoda.Add(_mapper.Map<ProizvodVM>(item));
            }

            //Sortiramo proizvode sa najvecim koeficijentom slicnosti na vrh
            for(int i = 0; i < listaKoeficijenata.Count; i++)
            {
                for(int c = i; c< listaKoeficijenata.Count; c++)
                {
                    if(listaKoeficijenata[c] > listaKoeficijenata[i])
                    {
                        var temp = listaKoeficijenata[i];
                        listaKoeficijenata[i] = listaKoeficijenata[c];
                        listaKoeficijenata[c] = temp;

                        var temp2 = listaProizvoda[i];
                        listaProizvoda[i] = listaProizvoda[c];
                        listaProizvoda[c] = temp2;
                    }
                }
            }
            return listaProizvoda;
        }
    }
}
