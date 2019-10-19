using MobileApp.Converters;
using MobileApp.ViewModels;
using MobileApp.Views.Popups;
using Pokloni.ba.Model.Requests.Proizvodi;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokloniDetails : ContentPage
    {
        private PokloniDetailsViewModel model = null;
        public PokloniDetails(ProizvodVM poklon)
        {
            InitializeComponent();

            BindingContext = model = new PokloniDetailsViewModel(poklon, RatingLayout);

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadOcjene(productFeedback);
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new FeedbackPopupView(model._poklonId));
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            model.AddTocart();
            DisplayAlert("Uspjeh!", "Uspješno ste dodali " + model.Naziv + " u vašu korpu!", "ok");
        }
    }
}