using MobileApp.ViewModels;
using Pokloni.ba.Model.Requests.Narudzba;
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
    public partial class NarudzbaDetailsPage : ContentPage
    {
        private readonly NarudzbaDetailsViewModel model = null;

        public NarudzbaDetailsPage(int id)
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaDetailsViewModel(id);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            model.LoadNarudzba(korpalw, ukupniracun);
        }

        private void Korpalw_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var temp = e.Item as NarudzbaDetailsVM;

                ProizvodVM model = new ProizvodVM();

                model.ProizvodId = temp.ProizvodId;
                model.Naziv = temp.Proizvod.Naziv;
                model.Slika = temp.Proizvod.Slika;
                model.Opis = temp.Proizvod.Opis;
                model.Cijena = temp.Proizvod.Cijena;

                this.Navigation.PushAsync(new PokloniDetails(model));
            }
        }
    }
}