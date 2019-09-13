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

        private async void Button1_Click(object sender, EventArgs e)
        {
            var queries = txtPretraga.Text;

            var result = await _apiService.Get<IEnumerable<Model.Korisnik>>(queries);
      
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }

        private void DgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[1].Value;

            frmKorisniciDetalji frm = new frmKorisniciDetalji((int)id);
            frm.Show();
        }
    }
}
