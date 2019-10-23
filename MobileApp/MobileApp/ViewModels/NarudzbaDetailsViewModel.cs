using Pokloni.ba.Model.Requests.Narudzba;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class NarudzbaDetailsViewModel : BaseViewModel
    {
        private readonly APIService _apiServiceNarudzbaDetails = new APIService("NarudzbeDetails");
        private readonly int NarudzbaId = 0;

        private readonly List<NarudzbaDetailsVM> ListaDetalja = new List<NarudzbaDetailsVM>();

        public NarudzbaDetailsViewModel(int id)
        {
            NarudzbaId = id;
        }
        public async void LoadNarudzba(ListView lw, Label ukupno)
        {
            try
            {
                IsBusy = true;

                var listaProizvoda = await _apiServiceNarudzbaDetails.Get<IEnumerable<NarudzbaDetailsVM>>();

                foreach(var item in listaProizvoda)
                {
                    if (item.NarudzbaId.Equals(NarudzbaId))
                        ListaDetalja.Add(item);
                }

                lw.ItemsSource = ListaDetalja;

                decimal? suma = 0;
                foreach(var item in ListaDetalja)
                    suma += item.Ukupno;
                ukupno.Text = suma.ToString() + " $";
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
