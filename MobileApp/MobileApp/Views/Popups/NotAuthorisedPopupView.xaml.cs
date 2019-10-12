using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotAuthorisedPopupView
    {
        public string poruka = string.Empty;
        public NotAuthorisedPopupView(string tekst = "")
        {
            InitializeComponent();
            poruka = tekst;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            labelaPoruke.Text = poruka;
        }
    }
}