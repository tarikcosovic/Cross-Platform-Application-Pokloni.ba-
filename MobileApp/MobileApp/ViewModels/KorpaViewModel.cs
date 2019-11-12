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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Linq;

namespace MobileApp.ViewModels
{
    public class KorpaViewModel : INotifyPropertyChanged
    {

        private readonly APIService _apiServiceNarudzbe = new APIService("Narudzbe");
        private readonly APIService _apiServiceNarudzbeDetalji = new APIService("NarudzbeDetails");


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        string _ukupno = String.Empty;

        public string UkupnaCijena
        {
            get { return _ukupno; }
            set { _ukupno = value; OnPropertyChanged(); }
        }

        public ObservableCollection<KorpaModel> _ListaKorpe
        {
            get { return ListaKorpe; }
            set { ListaKorpe = value; OnPropertyChanged(); }
        }

        public static ObservableCollection<KorpaModel> ListaKorpe { get; set; } = new ObservableCollection<KorpaModel>();

        public static void AddToCart(NarudzbaDetailsVM model, ProizvodVM poklon)
        {
            foreach (var item in ListaKorpe)
            {
                if (item.Proizvod.ProizvodId.Equals(model.ProizvodId))
                {
                    item.Narudzba.Kolicina++;
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

        public void UpdateUkupnaCijena(Button ukupnolbl)
        {
            decimal sum = 0;
            foreach (var item in ListaKorpe)
                sum += item.Proizvod.Cijena * (decimal)item.Narudzba.Kolicina;
            _ukupno = sum.ToString();

            ukupnolbl.Text = _ukupno;
        }

        public void UpdateList(ListView lw) { lw.ItemsSource = null; lw.ItemsSource = _ListaKorpe; }
        public async void Zavrsi()
        {
            try
            {
                //IsBusy = true;

                NarudzbaVM model = new NarudzbaVM()
                {
                    KorisnikId = APIService.UserId,
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
                //IsBusy = false;
            }
        }

        public void RefreshKolicina(int id, int kolicina)
        {

            foreach(var item in _ListaKorpe)
            {
                if(item.Proizvod.ProizvodId.Equals(id))
                {
                    if (kolicina <= 0)
                    {
                        _ListaKorpe.Remove(item);
                        return;
                    }

                    item.Narudzba.Kolicina = kolicina;
                    item.CijenaProizvoda = (decimal)item.Narudzba.Kolicina * item.Proizvod.Cijena;
                    break;
                }
            }
        }

        public class KorpaModel
        {
            public NarudzbaDetailsVM Narudzba { get; set; }
            public ProizvodVM Proizvod { get; set; }
            public decimal CijenaProizvoda { get; set; }
        }
    }
}
