using Flurl.Http;
using MobileApp.Views;
using MobileApp.Views.Popups;
using Pokloni.ba.Model;
using Pokloni.ba.Model.Requests;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public RegistrationViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _passwordconfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _passwordconfirmation; }
            set { SetProperty(ref _passwordconfirmation, value); }
        }

        public ICommand RegisterCommand { get; }

        async Task Register()
        {
            IsBusy = true;

            if(!_password.Equals(_passwordconfirmation))
            {
                await PopupNavigation.Instance.PushAsync(new NotAuthorisedPopupView("Password and Password Confirmation do not match!"));
            }

            try
            {
                KorisniciInsertRequest korisnik = new KorisniciInsertRequest()
                {
                    Username = _username,
                    Email = _email,
                    Password = _password,
                    PasswordConfirmation = _passwordconfirmation,
                    Status = true
                };

                await _apiService.Insert<KorisniciInsertRequest>(korisnik);
                await PopupNavigation.Instance.PushAsync(new SuccessPopupView(new LoginPage()));
            }
            catch (AmbiguousMatchException)
            {
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
