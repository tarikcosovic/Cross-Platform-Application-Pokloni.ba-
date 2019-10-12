using MobileApp.Views.Popups;
using Pokloni.ba.Model.Requests.Proizvodi;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PokloniDetailsViewModel : BaseViewModel
    {

        public PokloniDetailsViewModel()
        {

        }

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
        private readonly APIService _apiServiceProizvodi = new APIService("Proizvodi");
        private StackLayout _ratingLayout = null;
        private readonly int _poklonId;

        public ObservableCollection<UserFeedback> ListaFeedbacka = new ObservableCollection<UserFeedback>();
        public PokloniDetailsViewModel(ProizvodVM proizvod, StackLayout ratingLayout)
        {
            _naziv = proizvod.Naziv;
            _opis = proizvod.Opis;
            _slika = proizvod.Slika;
            _cijena = proizvod.Cijena;

            _ratingLayout = ratingLayout;
            _poklonId = proizvod.ProizvodId;
        }

        public async Task LoadOcjene(ListView feedbackListView)
        {
            try
            {
                IsBusy = true;
                var listaOcjena = await _apiService.Get<IEnumerable<OcjenaVM>>();
                var prosjecnaOcjena = await _apiServiceProizvodi.GetProizvodOcjena(_poklonId);

                if (prosjecnaOcjena == 0)
                {
                    _ratingLayout.Children.Add(new Label() { Text = "Poklon još nije ocjenjen!" });
                    return;
                }

                foreach (var ocjena in listaOcjena)
                {
                    if(ocjena.ProizvodId == _poklonId)
                    {
                        UserFeedback temp = new UserFeedback(ocjena);
                        if (ocjena.NumerickaOcjena <= 0) continue;

                        var prosjek = ocjena.NumerickaOcjena;

                        if(prosjek > 0)
                        {
                            temp.rating1 = 1;
                            prosjek--;
                        }
                        if(prosjek>0)
                        {
                            temp.rating2 = 1;
                            prosjek--;
                        }
                        if (prosjek > 0)
                        {
                            temp.rating3 = 1;
                            prosjek--;
                        }
                        if (prosjek > 0)
                        {
                            temp.rating4 = 1;
                            prosjek--;
                        }
                        if (prosjek > 0)
                            temp.rating5 = 1;

                        ListaFeedbacka.Add(temp);
                    }
                }

                feedbackListView.ItemsSource = null;
                feedbackListView.ItemsSource = ListaFeedbacka;

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

        public class UserFeedback
        {
            public double rating1 = 0.3;
            public double rating2 = 0.3;
            public double rating3 = 0.3;
            public double rating4 = 0.3;
            public double rating5 = 0.3;

            public OcjenaVM Ocjena = null;

            public UserFeedback(OcjenaVM ocjena)
            {
                this.Ocjena = ocjena;
            }
        }
    }
}
