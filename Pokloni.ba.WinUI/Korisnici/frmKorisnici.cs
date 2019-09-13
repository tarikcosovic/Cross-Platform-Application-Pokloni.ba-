using System;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using System.Collections.Generic;

namespace Pokloni.ba.WinUI.Korisnici
{
    public partial class frmKorisnici : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();

            InitialiseMyMaterialDesign(this);
        }


        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var queries = txtPretraga.Text;
            var result = await _apiService.Get<IEnumerable<Model.Korisnik>>(queries);

            listaKorisnika.Items.Clear();
            foreach (var item in result)
            {
                ListViewItem temp = new ListViewItem();
                temp.SubItems.Add(item.KorisnikDetailsId.ToString());
                temp.SubItems.Add(item.Username);
                temp.SubItems.Add(item.Email);
                temp.SubItems.Add(item.Status.ToString());

                listaKorisnika.Items.Add(temp);
            }
        }

        private void ListaKorisnika_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = listaKorisnika.SelectedItems[0].SubItems[1].Text;

            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id));
            frm.Show();
        }
    }
}
