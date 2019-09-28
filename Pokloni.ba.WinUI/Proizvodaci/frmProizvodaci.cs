using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Proizvodaci
{
    public partial class frmProizvodaci : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteProizvodaci);

        public frmProizvodaci()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }
        private void FrmProizvodaci_Load(object sender, EventArgs e)
        {
            BtnPrikazi_Click(null, null);
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            loadingBar.Visible = true;

            var queries = txtPretraga.Text;
            var result = await _apiService.Get<IEnumerable<Model.Requests.Proizvodi.ProizvodacPoklona>>("Naziv", queries);

            listaProizvodaca.Items.Clear();
            foreach(var item in result)
            {
                ListViewItem temp = new ListViewItem();

                temp.SubItems.Add(item.Naziv);
                temp.SubItems.Add(item.Opis);
                temp.Tag = item.ProizvodacPoklonaId;

                listaProizvodaca.Items.Add(temp);
            }
            loadingBar.Visible = false;
        }
        private void ListaProizvodaca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = int.TryParse(listaProizvodaca.SelectedItems[0].Tag.ToString(), out int res);

            if (id)
            {
                frmProizvodaciDetails frm = new frmProizvodaciDetails(res);
                frm.Show();
            }
            else MessageBox.Show("Greška pri dobavljanju proizvoda..", "Greška!", MessageBoxButtons.OK);
        }
    }
}
