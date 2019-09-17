using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;

namespace Pokloni.ba.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService("KorisniciDetails");
        private readonly APIService _apiServiceKorisnici = new APIService(Properties.Settings.Default.RouteKorisnici);
        private readonly int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            _id = korisnikId;
            InitializeComponent();

            InitialiseMyMaterialDesign(this);
        }

        private async void FrmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var korisnik = await _apiService.GetbyId<Model.Requests.Korisnici.KorisniciDetailsGetRequest>(_id);
                
                Ime.Text = korisnik.Ime;
                Prezime.Text = korisnik.Prezime;
                Drzava.Text = korisnik.DrzavaStanovanja;
                Grad.Text = korisnik.GradStanovanja;
                ZipCode.Text = korisnik.PostalCode;
                Adresa.Text = korisnik.AdresaStanovanja;
                BrojTelefona.Text = korisnik.BrojTelefona;
            }
        }

        private async void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] temp = new MaterialSingleLineTextField[7] { Ime, Prezime, Drzava, Grad, ZipCode, Adresa, BrojTelefona };

            if (ValidationHelper.ValidateTextBoxes(temp, errorProvider))
            {
                var model = new Model.Requests.Korisnici.KorisniciDetailsGetRequest()
                {
                    Ime = Ime.Text,
                    Prezime = Prezime.Text,
                    DrzavaStanovanja = Drzava.Text,
                    GradStanovanja = Grad.Text,
                    PostalCode = ZipCode.Text,
                    AdresaStanovanja = Adresa.Text,
                    BrojTelefona = BrojTelefona.Text
                };

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Requests.Korisnici.KorisniciDetailsGetRequest>(model, _id);

                    MessageBox.Show("Uspješno ste ažurirali korisnika..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika?", "Brisanje korisničkog računa", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var result = await _apiServiceKorisnici.Get<List<Model.Korisnik>>();
                int? korisnikId = result.Where(k => k.KorisnikDetailsId == _id).Select(x => x.KorisnikId).FirstOrDefault();

                if(korisnikId.HasValue)
                { 
                    await _apiServiceKorisnici.Delete(korisnikId);
                    this.Close();
                    MessageBox.Show("Uspješno ste izbrisali korisnika..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Nepostojeći korisnik..", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
