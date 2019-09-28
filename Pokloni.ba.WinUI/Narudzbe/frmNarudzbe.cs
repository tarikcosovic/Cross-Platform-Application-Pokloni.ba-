using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Narudzbe
{
    public partial class frmNarudzbe : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteNarudzbe);
        public frmNarudzbe()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private void FrmNarudzbe_Load(object sender, EventArgs e)
        {
           BtnPrikazi_Click(null, null);
        }

        private async void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<IEnumerable<Model.Requests.Narudzba.NarudzbaVM>>();

            listaNarudzbi.Items.Clear();
            var counter = 1;
            foreach(var item in result)
            {
                ListViewItem temp = new ListViewItem();
                temp.SubItems.Add($"#{ counter++.ToString()}");
                temp.SubItems.Add(item.KorisnikId.ToString());
                temp.SubItems.Add(item.ZaposlenikId.ToString());
                temp.SubItems.Add(item.DostavaId.ToString());
                temp.SubItems.Add(item.StatusPoruka.ToString());
                temp.SubItems.Add(item.DatumNarudzbe.ToString());

                listaNarudzbi.Items.Add(temp);
            }
        }
    }
}
