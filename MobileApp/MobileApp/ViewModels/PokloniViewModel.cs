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

namespace MobileApp.ViewModels
{
    public class PokloniViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Proizvodi");
        private readonly APIService _apiServiceKategorije = new APIService("Kategorije");

        private ObservableCollection<ProizvodVM> _listaProizvoda = new ObservableCollection<ProizvodVM>();
        private ObservableCollection<Kategorije> _listaKategorija = new ObservableCollection<Kategorije>();
        public ICommand AddToCardCommand { get; }

        public PokloniViewModel()
        {
            AddToCardCommand = new Command(async () => await DodajUKorpu());

        }
        public async Task DodajUKorpu()
        {

        }
        public async void LoadList(ListView listView, Picker picker)
        {
            try
            {
                IsBusy = true;
                _listaProizvoda = await _apiService.Get<ObservableCollection<ProizvodVM>>();
                _listaKategorija = await _apiServiceKategorije.Get<ObservableCollection<Kategorije>>();
            }
            catch (Exception e)
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
                catch (Exception e)
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
