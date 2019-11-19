using Pokloni.ba.Model;
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
    public partial class frmLogin : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteKorisnici);
        public frmLogin()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe != null && Properties.Settings.Default.RememberMe.Length > 3)
                Username.Text = Properties.Settings.Default.RememberMe;
        }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();

            frm.Show();
            this.Visible = false;
            this.Enabled = false;
        }

        private async void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = Username.Text;
                APIService.Password = Password.Text;

                loadingBar.Visible = true;
                var model = await _apiService.GetUserByUsername<Korisnik>(Username.Text);
                loadingBar.Visible = false;

                if (model.UlogaId != 1 && model.UlogaId != 3)
                {
                    errorProvider1.SetError(Username, "Nemate privilegije za pristup ovoj aplikaciji!");
                    return;
                }

                APIService.UserId = model.KorisnikId;

                if(rememberCheckbox.Checked)
                {
                    Properties.Settings.Default.RememberMe = Username.Text;
                    Properties.Settings.Default.Save();
                }

                frmIndex frm = new frmIndex();
                frm.Show();
                this.Visible = false;
                this.Enabled = false;
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(Password, "Username ili Password nisu tačni!");
            }
        }

        private void MaterialRaisedButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MaterialRaisedButton1_Click(null, null);
        }
    }
}
