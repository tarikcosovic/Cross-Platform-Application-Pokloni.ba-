using Pokloni.ba.Model;
using Pokloni.ba.Model.Requests.Narudzba;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class NarudzbeViewModel : BaseViewModel
    {
        private APIService _apiService = new APIService("Narudzbe");
        private APIService _apiServiceKorisnici = new APIService("Korisnici");
        private ListView PageListView { get; set; } = null;

        private List<NarudzbaVM> listaKorisnikovihNarudzbi = new List<NarudzbaVM>();

        public NarudzbeViewModel(ListView lw)
        {
            PageListView = lw;
        }

        public async void LoadList()
        {
            try
            {
                IsBusy = true;
                
                var ListaNarudzbi = await _apiService.Get<IEnumerable<NarudzbaVM>>();
                var korisnik = await _apiServiceKorisnici.GetUserByUsername<Korisnik>(APIService.Username);

                foreach(var item in ListaNarudzbi)
                {
                    if (item.KorisnikId == korisnik.KorisnikId)
                        listaKorisnikovihNarudzbi.Add(item);
                }
                PageListView.ItemsSource = listaKorisnikovihNarudzbi;
            }
            catch(AmbiguousMatchException)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
        
    }
}
