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
using static MobileApp.ViewModels.KorpaViewModel;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorpaPage : ContentPage
    {
        private KorpaViewModel model = null;
        public KorpaPage()
        {
            InitializeComponent();
            BindingContext = model = new KorpaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            model.UpdateUkupnaCijena(UkupnaCijena);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.Zavrsi();
        }

        private void Korpalw_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var temp = e.Item as KorpaModel;

                ProizvodVM model = new ProizvodVM();

                model.ProizvodId = temp.Proizvod.ProizvodId;
                model.Naziv = temp.Proizvod.Naziv;
                model.Slika = temp.Proizvod.Slika;
                model.Opis = temp.Proizvod.Opis;
                model.Cijena = temp.Proizvod.Cijena;

                this.Navigation.PushAsync(new PokloniDetails(model));
            }
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            Entry entry = sender as Entry;

            if(entry != null && int.TryParse(entry.ClassId, out int id) && int.TryParse(entry.Text, out int kolicina))
            {
                model.RefreshKolicina(id, kolicina);
                model.UpdateUkupnaCijena(UkupnaCijena);
                model.UpdateList(korpalw);
            }
        }

        private void Picker_Unfocused(object sender, FocusEventArgs e)
        {
            Picker temp = sender as Picker;

            switch(temp.SelectedIndex)
            {
                case 0:
                    {
                        model.UpdateDostava(0);
                        break;
                    }
                case 1:
                    {
                        model.UpdateDostava(5);
                        break;
                    }
                case 2:
                    {
                        model.UpdateDostava(10);
                        break;
                    }
            }
            model.UpdateUkupnaCijena(UkupnaCijena);
        }
    }
}