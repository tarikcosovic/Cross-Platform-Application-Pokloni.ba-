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

                foreach(var item in ListaNarudzbi)
                {
                    if (item.KorisnikId == APIService.UserId)
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
