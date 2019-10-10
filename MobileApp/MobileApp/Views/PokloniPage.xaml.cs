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
            model.LoadList(PokloniTable);
        }
        private void ImageCell_Tapped(int id)
        {
            
        }
    }
}