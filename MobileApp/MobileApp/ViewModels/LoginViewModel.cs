 using Flurl.Http;
using MobileApp.Views;
using MobileApp.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Uloge");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = String.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = String.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; }

        async Task Login()
        {
            IsBusy = true;

            APIService.Username = _username;
            APIService.Password = _password;

            try
            {
                await _apiService.Get<dynamic>();
                await PopupNavigation.Instance.PushAsync(new SuccessPopupView(new MainPage()));
            }
            catch(AmbiguousMatchException)
            {
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
