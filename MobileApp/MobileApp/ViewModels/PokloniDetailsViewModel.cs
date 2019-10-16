using MobileApp.Views.Popups;
using Pokloni.ba.Model.Requests.Proizvodi;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class PokloniDetailsViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Ocjene");
        private readonly APIService _apiServiceProizvodi = new APIService("Proizvodi");
        private StackLayout _ratingLayout = null;
        public readonly int _poklonId;

        public ObservableCollection<UserFeedback> ListaFeedbacka { get; set; } = new ObservableCollection<UserFeedback>();
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

                ListaFeedbacka.Clear();
                foreach (var ocjena in listaOcjena)
                {
                    if(ocjena.ProizvodId == _poklonId)
                    {
                        if (ocjena.NumerickaOcjena <= 0) continue;
                        UserFeedback temp = new UserFeedback(ocjena.Korisnik.Username, ocjena.Komentar);

                        for(int i = ocjena.NumerickaOcjena - 1; i >=0; i--)
                            temp.ratings[i] = 1.0m;

                        ListaFeedbacka.Add(temp);
                    }
                }
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
            catch(AmbiguousMatchException)
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
            public decimal[] ratings { get; set; } = new decimal[5] { 0.3m, 0.3m, 0.3m, 0.3m, 0.3m };
            public string NazivKorisnika { get; set; }
            public string KomentarKorisnika { get; set; }

            public UserFeedback(string korisnik, string komentar)
            {
                NazivKorisnika = korisnik;
                KomentarKorisnika = komentar;
            }
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

    }
}
