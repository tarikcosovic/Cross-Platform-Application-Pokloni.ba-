using Pokloni.ba.Model;
using System;
using Pokloni.ba.Model.Requests.Korisnici;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using Rg.Plugins.Popup.Services;
using MobileApp.Views.Popups;

namespace MobileApp.ViewModels
{
    public class ProfilViewModel : INotifyPropertyChanged
    {
        private readonly APIService _apiServiceKorisniciDetails = new APIService("KorisniciDetails");
        private int KorisnikId;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #region BindingProperties
        string _username = String.Empty;
        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        string _email = String.Empty;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        string _ime = String.Empty;
        public string Ime
        {
            get { return _ime; }
            set { _ime = value; OnPropertyChanged(nameof(Ime)); }
        }

        string _prezime = String.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; OnPropertyChanged(nameof(Prezime)); }
        }


        string _telefon = String.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; OnPropertyChanged(nameof(Telefon)); }
        }

        string _drzava = String.Empty;
        public string Drzava
        {
            get { return _drzava; }
            set { _drzava = value; OnPropertyChanged(nameof(Drzava)); }
        }

        string _grad = String.Empty;
        public string Grad
        {
            get { return _grad; }
            set { _grad = value; OnPropertyChanged(nameof(Grad)); }
        }

        string _postalCode = String.Empty;
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; OnPropertyChanged(nameof(PostalCode)); }
        }

        string _adresa = String.Empty;

        public string Adresa
        {
            get { return _adresa; }
            set { _adresa = value; OnPropertyChanged(nameof(Adresa)); }
        }

        #endregion

        public async void LoadUser()
        {
            try
            {
                var userDetails = await _apiServiceKorisniciDetails.GetbyId<KorisniciDetailsGetRequest>(APIService.UserDetailsId);

                KorisnikId = APIService.UserId;
                Username = APIService.Username;
                Email = APIService.Email;
                Ime = userDetails.Ime;
                Prezime = userDetails.Prezime;
                Telefon = userDetails.BrojTelefona;
                Drzava = userDetails.DrzavaStanovanja;
                Grad = userDetails.GradStanovanja;
                PostalCode = userDetails.PostalCode;
                Adresa = userDetails.AdresaStanovanja;
            }
            catch (AmbiguousMatchException)
            {

            }
        }

        public async void UpdateUser()
        {
            KorisniciDetailsGetRequest model = new KorisniciDetailsGetRequest()
            {
                Ime = this.Ime,
                Prezime = this.Prezime,
                BrojTelefona = this.Telefon,
                DrzavaStanovanja = this.Drzava,
                GradStanovanja = this.Grad,
                AdresaStanovanja = this.Adresa,
                PostalCode = this.PostalCode
            };

            try
            {
                await _apiServiceKorisniciDetails.Update<KorisniciDetailsGetRequest>(model, KorisnikId);
                await PopupNavigation.Instance.PushAsync(new SuccessPopupView());
            }
            catch (AmbiguousMatchException)
            {

            }
        }
    }
}
