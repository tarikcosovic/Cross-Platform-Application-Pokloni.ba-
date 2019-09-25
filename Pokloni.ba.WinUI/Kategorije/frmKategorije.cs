using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Kategorije
{
    public partial class frmKategorije : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteKategorije);

        public frmKategorije()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private void FrmKategorije_Load(object sender, EventArgs e)
        {
            BtnPrikazi_Click_1(null, null);
        }

        private void ListaKategorija_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = int.TryParse(listaKategorija.SelectedItems[0].Tag.ToString(), out int res);

            if (id)
            {
                frmKategorijeDetails frm = new frmKategorijeDetails(res);
                frm.Show();
            }
            else MessageBox.Show("Greška pri dobavljanju kategorije..", "Greška!", MessageBoxButtons.OK);
        }

        private async void BtnPrikazi_Click_1(object sender, EventArgs e)
        {
            var queries = txtPretraga.Text;
            var result = await _apiService.Get<IEnumerable<Model.Requests.Proizvodi.Kategorije>>("Naziv", queries);

            listaKategorija.Items.Clear();
            foreach (var item in result)
            {
                ListViewItem temp = new ListViewItem();

                temp.SubItems.Add(item.Naziv);
                temp.SubItems.Add(item.Opis);
                temp.Tag = item.KategorijaId;

                listaKategorija.Items.Add(temp);
            }
        }
    }
}
