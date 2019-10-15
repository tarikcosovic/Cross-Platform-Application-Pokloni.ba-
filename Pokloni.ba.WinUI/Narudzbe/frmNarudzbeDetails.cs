using System;
using System.Collections.Generic;
using Pokloni.ba.Model.Requests.Narudzba;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Narudzbe
{
    public partial class frmNarudzbeDetails : MyMaterialForm
    {
        private readonly APIService _apiServiceNarudzbeDetails = new APIService(Properties.Settings.Default.RouteNarudzbeDetails);
        private readonly APIService _apiServiceNarudzbe = new APIService(Properties.Settings.Default.RouteNarudzbe);
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
                    var tempUkupno = (item.Proizvod.Cijena - popust) * item.Kolicina;
                    Math.Round((double)ukupno, 2);

                    temp.SubItems.Add(item.Proizvod.Naziv);
                    temp.SubItems.Add(item.Kolicina.ToString());

                    if (item.Popust == 0)
                        temp.SubItems.Add("Nema");
                    else
                        temp.SubItems.Add(item.Popust.ToString() + "%");

                    temp.SubItems.Add(((double)tempUkupno).ToString() + "$");

                    listaProizvoda.Items.Add(temp);
                }
            }
            UkupnaCijena.Text = ((double)ukupno).ToString() + "$";
        }

        private async void BtnOdbij_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Da li ste sigurni da želite odbiti narudžbu?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(test == DialogResult.Yes)
            {
                try
                {
                    var temp = await _apiServiceNarudzbe.GetbyId<NarudzbaVM>(_id);
                    temp.StatusPoruka = "Odbijeno";

                    await _apiServiceNarudzbe.Update<NarudzbaVM>(temp, _id);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Dogodila se greška nad dobavljanjem narudžbe sa servera..", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Uspješno ste odbili narudžbu..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnPrihvati_Click(object sender, EventArgs e)
        {
            DialogResult test = MessageBox.Show("Da li ste sigurni da želite prihvatiti narudžbu?", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (test == DialogResult.Yes)
            {
                try
                {
                    var temp = await _apiServiceNarudzbe.GetbyId<NarudzbaVM>(_id);
                    temp.StatusPoruka = "Prihvaćeno";

                    await _apiServiceNarudzbe.Update<NarudzbaVM>(temp, _id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dogodila se greška nad dobavljanjem narudžbe sa servera..", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Uspješno ste prihvatili narudžbu..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
