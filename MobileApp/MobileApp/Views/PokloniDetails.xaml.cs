using MobileApp.Converters;
using MobileApp.ViewModels;
using Pokloni.ba.Model.Requests.Proizvodi;
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
    }
}