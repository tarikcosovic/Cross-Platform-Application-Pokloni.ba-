using MobileApp.ViewModels;
using Rg.Plugins.Popup.Services;
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
    public partial class FeedbackPopupView
    {
        private FeedbackViewModel model = null;
        private int poklonID;
        public FeedbackPopupView(int poklonID)
        {
            InitializeComponent();
            BindingContext = model = new FeedbackViewModel();
            this.poklonID = poklonID;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.SaveOcjena(poklonID);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}