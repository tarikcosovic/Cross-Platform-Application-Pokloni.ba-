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
    public partial class frmNarudzbeDetails : MyMaterialForm
    {
        private readonly APIService _apiServiceNarudzbeDetails = new APIService(Properties.Settings.Default.RouteNarudzbeDetails);
        private readonly int _id;
        public frmNarudzbeDetails(int id)
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);

            _id = id;
        }

        private async void FrmNarudzbeDetails_Load(object sender, EventArgs e)
        {
            var result = await _apiServiceNarudzbeDetails.Get<IEnumerable<Model.Requests.Narudzba.NarudzbaDetailsVM>>();

            listaProizvoda.Items.Clear();

            foreach(var item in result)
            {
                if(item.NarudzbaId == _id)
                {
                    ListViewItem temp = new ListViewItem();
                    temp.SubItems.Add(item.Proizvod.Naziv);
                    temp.SubItems.Add(item.Kolicina.ToString());
                    temp.SubItems.Add(item.Popust.ToString());
                    temp.SubItems.Add(item.Ukupno.ToString());

                    listaProizvoda.Items.Add(temp);
                }
            }
        }
    }
}
