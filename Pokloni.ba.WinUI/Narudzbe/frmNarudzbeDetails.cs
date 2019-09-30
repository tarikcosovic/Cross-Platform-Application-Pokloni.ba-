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

            decimal? ukupno = 0;

            listaProizvoda.Items.Clear();
            foreach(var item in result)
            {
                if(item.NarudzbaId == _id)
                {
                    ListViewItem temp = new ListViewItem();

                    decimal? popust = 0;
                    if (item.Popust != null)
                        popust = (item.Proizvod.Cijena * (item.Popust/100));
                    ukupno += (item.Proizvod.Cijena - popust) * item.Kolicina;
                    Math.Round((double)ukupno, 2);

                    temp.SubItems.Add(item.Proizvod.Naziv);
                    temp.SubItems.Add(item.Kolicina.ToString());

                    if (item.Popust == 0)
                        temp.SubItems.Add("Nema");
                    else
                        temp.SubItems.Add(item.Popust.ToString() + "%");

                    temp.SubItems.Add(((double)ukupno).ToString() + "$");

                    listaProizvoda.Items.Add(temp);
                }
            }
            UkupnaCijena.Text = ((double)ukupno).ToString() + "$";
        }
    }
}
