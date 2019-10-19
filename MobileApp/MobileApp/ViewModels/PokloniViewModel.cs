using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using Xamarin.Forms;
using Pokloni.ba.Model.Requests.Proizvodi;
using Rg.Plugins.Popup.Services;
using MobileApp.Views.Popups;
using MobileApp.Converters;
using System.Windows.Input;
using System.Threading.Tasks;
using Pokloni.ba.Model.Requests.Narudzba;
using System.Reflection;

namespace MobileApp.ViewModels
{
    public class PokloniViewModel : BaseViewModel
    {
        string counter = KorpaViewModel.ListaKorpe.Count.ToString();
        public string PoklonCounter
        {
            get { return counter; }
            set { SetProperty(ref counter, value); }
        }

        private readonly APIService _apiService = new APIService("Proizvodi");
        private readonly APIService _apiServiceKategorije = new APIService("Kategorije");

        private ObservableCollection<ProizvodVM> _listaProizvoda = new ObservableCollection<ProizvodVM>();
        private ObservableCollection<Kategorije> _listaKategorija = new ObservableCollection<Kategorije>();
        public ICommand AddToCardCommand { get; }

        public PokloniViewModel()
        {
            counter = KorpaViewModel.ListaKorpe.Count.ToString();
            AddToCardCommand = new Command((() => DodajUKorpu()));
        }
        public void DodajUKorpu(ProizvodVM model = null)
        {
            if (model == null)
                return;

            NarudzbaDetailsVM temp = new NarudzbaDetailsVM()
            {
                Kolicina = 1,
                ProizvodId = model.ProizvodId,
            };

            KorpaViewModel.AddToCart(temp, model);
            counter = KorpaViewModel.ListaKorpe.Count.ToString();
        }

        public async void LoadList(ListView listView, Picker picker)
        {
            try
            {
                IsBusy = true;
                _listaProizvoda = await _apiService.Get<ObservableCollection<ProizvodVM>>();
                _listaKategorija = await _apiServiceKategorije.Get<ObservableCollection<Kategorije>>();
            }
            catch (AmbiguousMatchException)
            {
                await PopupNavigation.Instance.PushAsync(new Error404PopupView());
            }
            finally
            {
                IsBusy = false;
            }

            picker.ItemsSource = _listaKategorija;
            picker.ItemDisplayBinding = new Binding("Naziv");

            foreach (var item in _listaProizvoda)
            {
                item.Sifra = string.Empty;
                try
                {
                    var ocjena = await _apiService.GetProizvodOcjena(item.ProizvodId);
                    for (int i = 0; i < ocjena; i++)
                    {
                        item.Sifra += "★";
                    }
                }
                catch (AmbiguousMatchException)
                {

                }

            }
            listView.ItemsSource = _listaProizvoda;
        }

        public void LoadFilteredList(ListView listView, int kategorijaID)
        {
            List<ProizvodVM> _filtriranaLista = new List<ProizvodVM>();
            foreach (var item in _listaProizvoda)
                _filtriranaLista.Add(item);

            for (int i = _filtriranaLista.Count - 1; i >= 0; i--)
            {
                if (!_filtriranaLista[i].KategorijaId.Equals(kategorijaID))
                    _filtriranaLista.RemoveAt(i);
            }

            listView.ItemsSource = _filtriranaLista;
        }
    }
}
