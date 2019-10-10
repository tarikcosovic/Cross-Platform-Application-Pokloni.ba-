using MobileApp.ViewModels;
using System;
using Pokloni.ba.Model.Requests.Proizvodi;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokloniPage : ContentPage
    {
        private PokloniViewModel model = null;
        public PokloniPage()
        {
            InitializeComponent();
            BindingContext = model = new PokloniViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.LoadList(proizvodiListView, KategorijePicker);
        }

        protected void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(KategorijePicker.SelectedItem != null)
            {
                model.LoadFilteredList(proizvodiListView, (KategorijePicker.SelectedItem as Kategorije).KategorijaId); 
            }
        }
    }
}