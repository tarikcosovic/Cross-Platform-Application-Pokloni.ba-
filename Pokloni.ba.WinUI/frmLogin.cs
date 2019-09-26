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
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteUloge);
        public frmLogin()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
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

                await _apiService.Get<dynamic>();

                frmIndex frm = new frmIndex();
                frm.Show();
                this.Visible = false;
                this.Enabled = false;
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(Password, "Username ili Password nisu tačni!" + ex.Message);
            }
        }

        private void MaterialRaisedButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MaterialRaisedButton1_Click(null, null);
        }
    }
}
