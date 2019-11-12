using Flurl.Http;
using Pokloni.ba.Model.Requests.Proizvodi;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PocetnaViewModel : BaseViewModel
    {
        private readonly APIService _apiServicePreporuceni = new APIService("Preporuka");
        public List<ProizvodVM> ListaPreporucenih { get; set; } = new List<ProizvodVM>();
        public async void LoadPreporuceniProizvodi(ItemsView model)
        {
            try
            {
                IsBusy = true;

                ListaPreporucenih = await _apiServicePreporuceni.GetbyId<List<ProizvodVM>>(APIService.UserId);
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
