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
        private readonly APIService _apiService = new APIService("Korisnici");
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
                var model = new Model.Requests.KorisniciInsertRequest()
                {
                    Username = Username.Text,
                    Email = Email.Text,
                    Password = Password.Text,
                    PasswordConfirmation = PasswordConfirmation.Text,
                    Status = true,
                    UlogaId = ++Uloga.SelectedIndex
                };

                await _apiService.Inset<Model.Requests.KorisniciInsertRequest>(model);

                MessageBox.Show("Uspješno ste dodali korisnika..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
