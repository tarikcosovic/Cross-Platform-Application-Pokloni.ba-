using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _apiService = new APIService("KorisniciDetails");
        private readonly int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            _id = korisnikId;
            InitializeComponent();
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
        private async void Button1_Click(object sender, EventArgs e)
        {
            TextBox[] temp = new TextBox[7] { Ime, Prezime, Drzava, Grad, ZipCode, Adresa, BrojTelefona };

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
                    var request = await _apiService.Update<Model.Requests.Korisnici.KorisniciDetailsGetRequest>(model, _id);

                    MessageBox.Show("Uspjeh!", "Uspješno ste ažurirali.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

    }
}
