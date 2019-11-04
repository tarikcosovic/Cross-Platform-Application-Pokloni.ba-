using MobileApp.ViewModels;
using Pokloni.ba.Model.Requests.Proizvodi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProizvodiPage : ContentPage
    {
        private readonly PocetnaViewModel model = null;
        private bool OpenedOnce = false;
        public ProizvodiPage()
        {
            InitializeComponent();
            BindingContext = model = new PocetnaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!OpenedOnce)
            {
                model.LoadPreporuceniProizvodi(carouselList);
                OpenedOnce = true;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync((new PokloniPage(2)));
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync((new PokloniPage(1)));
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushAsync((new PokloniPage(5)));
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Navigation.PushAsync((new PokloniPage(3)));
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            if (e != null)
            {
                var clicked = e as TappedEventArgs;
                this.Navigation.PushAsync(new PokloniDetails(clicked.Parameter as ProizvodVM));
            }
        }
    }
}