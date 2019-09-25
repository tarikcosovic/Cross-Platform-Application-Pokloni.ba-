using MaterialSkin.Controls;
using Pokloni.ba.Model.Requests.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI
{
    public partial class frmRegister : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmRegister()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private async void Register_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] temp = new MaterialSingleLineTextField[4] { Username, Email, Password, PasswordConfirmation };
            if (ValidationHelper.ValidateTextBoxes(temp, errorProvider1) && ValidationHelper.PasswordCheck(Password.Text, PasswordConfirmation.Text, Password, errorProvider1) && ValidationHelper.EmailCheck(Email.Text, Email, errorProvider1))
            {
                var model = new Model.Requests.KorisniciInsertRequest()
                {
                    Username = Username.Text,
                    Email = Email.Text,
                    Password = Password.Text,
                    PasswordConfirmation = PasswordConfirmation.Text,
                    UlogaId = 0,
                    Status = true,
                };

                await _apiService.Insert<Model.Requests.KorisniciInsertRequest>(model);

                MessageBox.Show("Uspješno ste dodali korisnika..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
            }
        }
    }
}
