using Flurl.Http;
using Pokloni.ba.Model;
using Pokloni.ba.Model.Requests.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PocetnaViewModel : BaseViewModel
    {
        private readonly APIService _apiServicePreporuceni = new APIService("Preporuka");
        private readonly APIService _apiServiceKorisnik = new APIService("Korisnici");
        public List<ProizvodVM> ListaPreporucenih { get; set; } = new List<ProizvodVM>();
        public async void LoadPreporuceniProizvodi(ItemsView model)
        {
            try
            {
                IsBusy = true;

                var korisnik = await _apiServiceKorisnik.GetUserByUsername<Korisnik>(APIService.Username);
                int? korisnikId = korisnik.KorisnikId;

                ListaPreporucenih = await _apiServicePreporuceni.GetbyId<List<ProizvodVM>>(korisnikId);
                model.ItemsSource = ListaPreporucenih;
            }
            catch (FlurlHttpException e)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
