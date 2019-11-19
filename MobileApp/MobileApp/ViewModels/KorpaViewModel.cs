using System;
using System.Collections.Generic;
using System.Text;
using Pokloni.ba.Model.Requests.Narudzba;
using Pokloni.ba.Model.Requests.Proizvodi;
using Pokloni.ba.Model;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using MobileApp.Views.Popups;
using Flurl.Http;
using System.Reflection;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Linq;
using Pokloni.ba.Model.Requests.Korisnici;
using Pokloni.ba.Model.Requests.Dostava;

namespace MobileApp.ViewModels
{
    public class KorpaViewModel : INotifyPropertyChanged
    {

        private readonly APIService _apiServiceNarudzbe = new APIService("Narudzbe");
        private readonly APIService _apiServiceNarudzbeDetalji = new APIService("NarudzbeDetails");
        private readonly APIService _apiServiceProizvodi = new APIService("Proizvodi");
        private readonly APIService _apiServiceKorisnikDetails = new APIService("KorisniciDetails");
        private readonly APIService _apiServiceDostava = new APIService("Dostave");


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        string _ukupno = String.Empty;

        public string UkupnaCijena
        {
            get { return _ukupno; }
            set { _ukupno = value; OnPropertyChanged(); }
        }

        bool _isBusy = false;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }

        double _dostava = 0;

        public double Dostava
        {
            get { return _dostava; }
            set { _dostava = value; OnPropertyChanged(); }
        }

        public void UpdateDostava(double param) => Dostava = param;

        public ObservableCollection<KorpaModel> _ListaKorpe
        {
            get { return ListaKorpe; }
            set { ListaKorpe = value; OnPropertyChanged(); }
        }

        public static ObservableCollection<KorpaModel> ListaKorpe { get; set; } = new ObservableCollection<KorpaModel>();

        public static void AddToCart(NarudzbaDetailsVM model, ProizvodVM poklon)
        {
            foreach (var item in ListaKorpe)
            {
                if (item.Proizvod.ProizvodId.Equals(model.ProizvodId))
                {
                    item.Narudzba.Kolicina++;
                    item.CijenaProizvoda += item.Proizvod.Cijena;
                    return;
                }
            }
            ListaKorpe.Add(new KorpaModel()
            {
                Narudzba = model,
                Proizvod = poklon,
                CijenaProizvoda = poklon.Cijena
            });
        }

        public void UpdateUkupnaCijena(Button ukupnolbl)
        {
            decimal sum = 0;
            foreach (var item in ListaKorpe)
                sum += item.Proizvod.Cijena * (decimal)item.Narudzba.Kolicina;
            sum += (decimal)Dostava;
            _ukupno = sum.ToString();

            ukupnolbl.Text = _ukupno;
        }
        public void UpdateList(ListView lw) { lw.ItemsSource = null; lw.ItemsSource = _ListaKorpe; }
        public async void Zavrsi()
        {
            #region ProvjeraDaLiJeKorpaPrazna
            if (!_ListaKorpe.Any())
            {
                await PopupNavigation.Instance.PushAsync(new NotAuthorisedPopupView("Vaša korpa je prazna!"));
                return;
            }
            #endregion

            Dostava dostavaModel = new Dostava();
            try
            {
                IsBusy = true;

                NarudzbaVM model = new NarudzbaVM()
                {
                    KorisnikId = APIService.UserId,
                    StatusPoruka = "Aktivno",
                    DatumNarudzbe = DateTime.Now,
                };
                List<NarudzbaDetailsVM> narudzbaDetailsList = new List<NarudzbaDetailsVM>();

                foreach(var item in ListaKorpe)
                {

                    #region ProvjeraValidacijeNarudzbe
                    var tempProizvod = await _apiServiceProizvodi.GetbyId<ProizvodVM>(item.Proizvod.ProizvodId);

                    if (tempProizvod.StanjeNaLageru < item.Narudzba.Kolicina)
                    {
                        narudzbaDetailsList.Clear();
                        await PopupNavigation.Instance.PushAsync(new NotAuthorisedPopupView("Nažalost poklon: " + item.Proizvod.Naziv + ", nemamo u toj količini, trenutno na lageru: " + tempProizvod.StanjeNaLageru.ToString()));
                        return;
                    }

                    var korisnikDetails = await _apiServiceKorisnikDetails.GetbyId<KorisniciDetailsGetRequest>(APIService.UserDetailsId);

                    if(korisnikDetails.AdresaStanovanja.Length < 3 
                        || korisnikDetails.BrojTelefona.Length < 3 
                        || korisnikDetails.DrzavaStanovanja.Length < 3
                        || korisnikDetails.GradStanovanja.Length < 3
                        || korisnikDetails.Ime.Length < 3
                        || korisnikDetails.Prezime.Length < 3
                        || korisnikDetails.PostalCode.Length < 3)
                    {
                        narudzbaDetailsList.Clear();
                        await PopupNavigation.Instance.PushAsync(new NotAuthorisedPopupView("Molimo popunite sve informacije na vašem profilu!"));
                        return;
                    }

                    Dostava dost = new Dostava()
                    {
                        AdresaDostave = korisnikDetails.AdresaStanovanja,
                        DrzavaDostave = korisnikDetails.DrzavaStanovanja,
                        GradDostave = korisnikDetails.GradStanovanja,
                        PostalCode = korisnikDetails.PostalCode,
                        KontaktTelefon = korisnikDetails.BrojTelefona,
                    };
                    switch(this.Dostava)
                    {
                        case 0:
                            dost.TipDostave = "Bez dostave";
                            break;
                        case 5:
                            dost.TipDostave = "Regularna dostava";
                            break;
                        case 10:
                            dost.TipDostave = "Expresna dostava";
                            break;
                    }
                    dostavaModel = dost;
                    #endregion

                    NarudzbaDetailsVM temp = new NarudzbaDetailsVM()
                    {
                        ProizvodId = item.Proizvod.ProizvodId,
                        Proizvod = item.Proizvod,
                        Kolicina = item.Narudzba.Kolicina,
                        Ukupno = item.Proizvod.Cijena * item.Narudzba.Kolicina,
                        Popust = item.Narudzba.Popust ?? 0,
                    };

                    //Updejta stanj na lageru proizvoda
                    temp.Proizvod.StanjeNaLageru -= (int)item.Narudzba.Kolicina;

                    temp.Ukupno += (decimal?)Dostava;
                    narudzbaDetailsList.Add(temp);
                }
                //DODAVANJE U BAZU
                var dostavaIdModel = await _apiServiceDostava.Insert<Dostava>(dostavaModel);

                model.DostavaId = dostavaIdModel.DostavaId;
                var narudzba = await _apiServiceNarudzbe.Insert<NarudzbaVM>(model);

                foreach (var narudzbaDetalj in narudzbaDetailsList)
                {
                    //UPDEJT STANJE NA LAGERU NE RADI!!! NEMOGUCI BUG
                    //await _apiServiceProizvodi.ProizvodUpdateInStock<ProizvodVM>(narudzbaDetalj.Proizvod, narudzbaDetalj.ProizvodId);
                    narudzbaDetalj.NarudzbaId = narudzba.NarudzbaId;
                    await _apiServiceNarudzbeDetalji.Insert<NarudzbaDetailsVM>(new NarudzbaDetailsVM {
                        Kolicina = narudzbaDetalj.Kolicina,
                        NarudzbaId = narudzbaDetalj.NarudzbaId,
                        Popust = narudzbaDetalj.Popust,
                        ProizvodId = narudzbaDetalj.ProizvodId,
                        Ukupno = narudzbaDetalj.Ukupno
                    });
                }

                ListaKorpe.Clear();
                await PopupNavigation.Instance.PushAsync(new FinishOrderPopupView());
            }
            catch (FlurlHttpException ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

        public void RefreshKolicina(int id, int kolicina)
        {

            foreach(var item in _ListaKorpe)
            {
                if(item.Proizvod.ProizvodId.Equals(id))
                {
                    if (kolicina <= 0)
                    {
                        _ListaKorpe.Remove(item);
                        return;
                    }

                    item.Narudzba.Kolicina = kolicina;
                    item.CijenaProizvoda = (decimal)item.Narudzba.Kolicina * item.Proizvod.Cijena;
                    break;
                }
            }
        }

        public class KorpaModel
        {
            public NarudzbaDetailsVM Narudzba { get; set; }
            public ProizvodVM Proizvod { get; set; }
            public decimal CijenaProizvoda { get; set; }
        }
    }
}
