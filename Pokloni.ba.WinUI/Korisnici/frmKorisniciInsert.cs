using MaterialSkin;
using MaterialSkin.Controls;

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
    public partial class frmKorisniciInsert : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteKorisnici);
        private readonly APIService _apiServiceUloge = new APIService(Properties.Settings.Default.RouteUloge);
        public frmKorisniciInsert()
        {
            InitializeComponent();

            InitialiseMyMaterialDesign(this);

        }

        private async void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] temp = new MaterialSingleLineTextField[4] { Username, Email, Password, PasswordConfirmation };
            if (ValidationHelper.ValidateTextBoxes(temp, errorProvider) && ValidationHelper.PasswordCheck(Password.Text, PasswordConfirmation.Text, Password, errorProvider) && ValidationHelper.EmailCheck(Email.Text, Email, errorProvider))
            {
                var ComboBoxUloga = Uloga.SelectedItem;
                var model = new Model.Requests.KorisniciInsertRequest()
                {
                    Username = Username.Text,
                    Email = Email.Text,
                    Password = Password.Text,
                    PasswordConfirmation = PasswordConfirmation.Text,
                    Status = true,
                    UlogaId = ((Model.Requests.Korisnici.Uloga)ComboBoxUloga).UlogaId
            };

                await _apiService.Insert<Model.Requests.KorisniciInsertRequest>(model);

                MessageBox.Show("Uspješno ste dodali korisnika..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private async void FrmKorisniciInsert_Load(object sender, EventArgs e)
        {
            await LoadUloge();
        }

        private async Task LoadUloge()
        {
            var result = await _apiServiceUloge.Get<List<Model.Requests.Korisnici.Uloga>>();
            result.Insert(0, new Model.Requests.Korisnici.Uloga() { UlogaId = 0});

            Uloga.DataSource = result;
            Uloga.DisplayMember = "Naziv";
            Uloga.Tag = "UlogaId";
        }

    }
}
