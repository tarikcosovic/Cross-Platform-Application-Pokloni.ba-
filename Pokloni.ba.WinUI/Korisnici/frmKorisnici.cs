using System;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using System.Collections.Generic;

namespace Pokloni.ba.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var queries = txtPretraga.Text;

            var result = await _apiService.Get<IEnumerable<Model.Korisnik>>(queries);
      
            dgvKorisnici.DataSource = result;
        }

        private void TxtPretraga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
