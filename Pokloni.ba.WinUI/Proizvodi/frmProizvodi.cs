using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Proizvodi
{
    public partial class frmProizvodi : MyMaterialForm
    {
        private readonly APIService _APIService = new APIService(Properties.Settings.Default.RouteProizvodi);
        public frmProizvodi()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var queries = txtPretraga.Text;
            var result = await _APIService.Get<IEnumerable<Model.Requests.Proizvodi.ProizvodVM>>("Naziv", queries);

            listaProizvoda.Items.Clear();
            foreach (var item in result)
            {
                ListViewItem temp = new ListViewItem();
                temp.SubItems.Add(item.Naziv);
                temp.SubItems.Add(item.Sifra);
                temp.SubItems.Add(item.Kategorija.Naziv);
                temp.SubItems.Add(item.Proizvodac.Naziv);
                temp.SubItems.Add(item.Cijena.ToString());
                temp.SubItems.Add(item.StanjeNaLageru.ToString());
                temp.Tag = item.ProizvodId.ToString();

                listaProizvoda.Items.Add(temp);
            }
        }

        private void FrmProizvodi_Load(object sender, EventArgs e)
        {
            BtnPrikazi_Click(sender, e);
        }

        private void ListaProizvoda_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var id = listaProizvoda.SelectedItems[0].Tag.ToString();

            frmProizvodiDetalji frm = new frmProizvodiDetalji(int.Parse(id));
            frm.Show();
        }
    }
}
