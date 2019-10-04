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
    public partial class SuccessPopupView
    {
        public SuccessPopupView()
        {
            InitializeComponent();
        }

        private async void AnimationView_OnFinish(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}