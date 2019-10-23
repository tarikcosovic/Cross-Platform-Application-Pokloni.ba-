using System;
using System.Collections.Generic;
using System.Text;
using Pokloni.ba.Model.Requests.Narudzba;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.Model;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using MobileApp.Views.Popups;
using Flurl.Http;
using System.Reflection;

namespace MobileApp.ViewModels
{
    public class KorpaViewModel : BaseViewModel
    {
        private readonly APIService _apiServiceKorisnici = new APIService("Korisnici");
        private readonly APIService _apiServiceNarudzbe = new APIService("Narudzbe");
        private readonly APIService _apiServiceNarudzbeDetalji = new APIService("NarudzbeDetails");

        public static List<KorpaModel> ListaKorpe { get; set; } = new List<KorpaModel>();

        public static void AddToCart(NarudzbaDetailsVM model, ProizvodVM poklon)
        {
            foreach (var item in ListaKorpe)
            {
                if (item.Proizvod.ProizvodId.Equals(model.ProizvodId))
                {
                    item.Narudzba.Kolicina ++;
                    item.CijenaProizvoda += item.Proizvod.Cijena;
                    return;
                }
            }
            ListaKorpe.Add(new KorpaModel()
            {
                Narudzba = model,
                Proizvod = poklon,
                CijenaProizvoda = poklon.Cijena
            });
        }

        public void LoadItems(ListView lw)
        {
            lw.ItemsSource = null;
            lw.ItemsSource = ListaKorpe;
        }

        public class KorpaModel
        {
            public NarudzbaDetailsVM Narudzba { get; set; }
            public ProizvodVM Proizvod { get; set; }
            public decimal CijenaProizvoda { get; set; }
        }

        public void UpdateUkupnaCijena(Button ukupnolbl)
        {
            decimal sum = 0;
            foreach (var item in ListaKorpe)
                sum += item.CijenaProizvoda;
            _ukupno = sum.ToString();

            ukupnolbl.Text = _ukupno;
        }

        string _ukupno = String.Empty;
        public string UkupnaCijena
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }

        public async void Zavrsi()
        {
            try
            {
                IsBusy = true;
                var korisnik = await _apiServiceKorisnici.GetUserByUsername<Korisnik>(APIService.Username);

                NarudzbaVM model = new NarudzbaVM()
                {
                    KorisnikId = korisnik.KorisnikId,
                    StatusPoruka = "Aktivno",
                    DatumNarudzbe = DateTime.Now,
                };

                var narudzba = await _apiServiceNarudzbe.Insert<NarudzbaVM>(model);

                foreach(var item in ListaKorpe)
                {
                    NarudzbaDetailsVM temp = new NarudzbaDetailsVM()
                    {
                        NarudzbaId = narudzba.NarudzbaId,
                        ProizvodId = item.Proizvod.ProizvodId,
                        Kolicina = item.Narudzba.Kolicina,
                        Ukupno = item.Proizvod.Cijena * item.Narudzba.Kolicina,
                        Popust = item.Narudzba.Popust??0,
                    };

                    await _apiServiceNarudzbeDetalji.Insert<NarudzbaDetailsVM>(temp);
                }
                ListaKorpe.Clear();
                await PopupNavigation.Instance.PushAsync(new FinishOrderPopupView());
            }
            catch (AmbiguousMatchException)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
