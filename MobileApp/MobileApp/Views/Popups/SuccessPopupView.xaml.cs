using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static MobileApp.ViewModels.LoginViewModel;

namespace MobileApp.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuccessPopupView
    {
        private Page _page;
        public SuccessPopupView(Page temp)
        {
            InitializeComponent();
            _page = temp;
        }

        private async void AnimationView_OnFinish(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();

            //del?.Invoke();

            //if(del != null)
            //    del();

            Application.Current.MainPage = _page;
        }
    }
}