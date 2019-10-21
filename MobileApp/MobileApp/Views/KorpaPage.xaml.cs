using MobileApp.ViewModels;
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

            model.LoadItems(korpalw);
            model.UpdateUkupnaCijena(UkupnaCijena);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.Zavrsi();
            korpalw.ItemsSource = null;
        }
    }
}