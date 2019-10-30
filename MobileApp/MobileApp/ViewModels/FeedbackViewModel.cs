using Flurl.Http;
using MobileApp.Views.Popups;
using Pokloni.ba.Model.Requests.Proizvodi;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class FeedbackViewModel : BaseViewModel
    {
        private APIService _apiServiceKorisnika = new APIService("Korisnici");
        private readonly APIService _apiService = new APIService("Ocjene");


        int _ocjena = 3;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

        string _komentar = String.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

        public async Task SaveOcjena(int poklonId)
        {
            var korisnik = await _apiServiceKorisnika.GetUserByUsername<Pokloni.ba.Model.Korisnik>(APIService.Username);

            try
            {
                OcjenaVM temp = new OcjenaVM() { ProizvodId = poklonId, KorisnikId = korisnik.KorisnikId, NumerickaOcjena = Ocjena, Komentar = Komentar };
                await _apiService.Insert<OcjenaVM>(temp);

                await PopupNavigation.Instance.PopAsync();
                await PopupNavigation.Instance.PushAsync(new SuccessPopupView());
            }
            catch(FlurlHttpException ex)
            {
                await PopupNavigation.Instance.PushAsync(new NotAuthorisedPopupView("Već ste ocjenili ovaj poklon!"));
            }
        }

    }
}
