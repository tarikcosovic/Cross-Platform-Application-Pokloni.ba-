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
    public partial class NarudzbePage : ContentPage
    {
        private NarudzbeViewModel model = null;
        public NarudzbePage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbeViewModel(proizvodiListView);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.LoadList();
        }

        private void ProizvodiListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                this.Navigation.PushAsync(new NarudzbaDetailsPage((e.Item as NarudzbaVM).NarudzbaId));
            }
        }
    }
}