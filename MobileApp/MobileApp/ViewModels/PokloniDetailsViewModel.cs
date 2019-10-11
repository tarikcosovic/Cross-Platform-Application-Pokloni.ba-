using MobileApp.Views.Popups;
using Pokloni.ba.Model.Requests.Proizvodi;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PokloniDetailsViewModel : BaseViewModel
    {

        string _naziv = String.Empty;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        string _opis = String.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        decimal _cijena = decimal.Zero;
        public decimal Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }

        private readonly APIService _apiService = new APIService("Ocjene");
        private StackLayout _ratingLayout = null;
        private readonly int _poklonId;

        private List<Ocjena> listaFeedbacka = null;
        private ListView _feedbackListView = null;
        public PokloniDetailsViewModel(ProizvodVM proizvod, StackLayout ratingLayout, ListView feedbackListView)
        {
            _naziv = proizvod.Naziv;
            _opis = proizvod.Opis;
            _slika = proizvod.Slika;
            _cijena = proizvod.Cijena;

            _ratingLayout = ratingLayout;
            _feedbackListView = feedbackListView;
            _poklonId = proizvod.ProizvodId;
        }

        public async Task LoadOcjene()
        {
            try
            {
                IsBusy = true;
                var listaOcjena = await _apiService.Get<IEnumerable<Ocjena>>();


                var sumaOcjena = 0;
                var ukupnoOcjena = 0;

                foreach (var ocjena in listaOcjena)
                {
                    if(ocjena.ProizvodId == _poklonId)
                    {
                        ukupnoOcjena++;
                        sumaOcjena += ocjena.NumerickaOcjena;
                        listaFeedbacka.Add(ocjena);
                    }
                }

                _feedbackListView.ItemsSource = listaFeedbacka;

                if(sumaOcjena == 0)
                {
                    _ratingLayout.Children.Add(new Label() { Text = "Poklon još nije ocjenjen!" });
                    return;
                }

                var prosjecnaOcjena = sumaOcjena / ukupnoOcjena;
                
                for(int i = 0; i < 5; i++)
                {
                    Image img = new Image();
                    img.Source = "iconStar.png";
                    img.Aspect = Aspect.AspectFit;
                    if (--prosjecnaOcjena >= 0)
                        img.Opacity = 1;
                    else img.Opacity = 0.3;

                    _ratingLayout.Children.Add(img);
                }
            }
            catch(Exception e)
            {
                await PopupNavigation.Instance.PushAsync(new Error404PopupView());
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
