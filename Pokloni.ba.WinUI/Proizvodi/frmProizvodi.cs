using Pokloni.ba.Model.Requests.Proizvodi;
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
        private readonly APIService _apiServiceKategorije = new APIService(Properties.Settings.Default.RouteKategorije);
        private readonly APIService _apiServiceProizvodaci = new APIService(Properties.Settings.Default.RouteProizvodaci);
        private List<ProizvodVM> listaProizvodaLokal = new List<ProizvodVM>();
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
            listaProizvodaLokal.Clear();
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
                listaProizvodaLokal.Add(item);
            }
        }

        private async void FrmProizvodi_Load(object sender, EventArgs e)
        {
            BtnPrikazi_Click(sender, e);

            await LoadKategorije();
            await LoadProizvodac();
        }

        private void ListaProizvoda_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var id = listaProizvoda.SelectedItems[0].Tag.ToString();

            frmProizvodiDetalji frm = new frmProizvodiDetalji(int.Parse(id));
            frm.Show();
        }

        private async Task LoadKategorije()
        {
            var result = await _apiServiceKategorije.Get<List<Model.Requests.Proizvodi.Kategorije>>();
            result.Insert(0, new Model.Requests.Proizvodi.Kategorije() { KategorijaId = 0 });

            Kategorija.DataSource = result;
            Kategorija.DisplayMember = "Naziv";
            Kategorija.Tag = "UlogaId";
        }

        private async Task LoadProizvodac()
        {
            var result = await _apiServiceProizvodaci.Get<List<Model.Requests.Proizvodi.ProizvodacPoklona>>();
            result.Insert(0, new Model.Requests.Proizvodi.ProizvodacPoklona() { ProizvodacPoklonaId = 0 });

            Proizvodac.DataSource = result;
            Proizvodac.DisplayMember = "Naziv";
            Proizvodac.Tag = "UlogaId";
        }

        private void Proizvodac_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajListu();
        }

        private void Kategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajListu();
        }

        private void FiltrirajListu()
        {
            listaProizvoda.Items.Clear();

            bool proizvod = false;
            bool kategorija = false;

            foreach (var item in listaProizvodaLokal)
            {
                ListViewItem temp = new ListViewItem();
                temp.SubItems.Add(item.Naziv);
                temp.SubItems.Add(item.Sifra);
                temp.SubItems.Add(item.Kategorija.Naziv);
                temp.SubItems.Add(item.Proizvodac.Naziv);
                temp.SubItems.Add(item.Cijena.ToString());
                temp.SubItems.Add(item.StanjeNaLageru.ToString());
                temp.Tag = item.ProizvodId.ToString();

                if (Proizvodac.Text != String.Empty && item.Proizvodac.Naziv.Equals(Proizvodac.Text))
                    proizvod = true;
                if (Proizvodac.Text == String.Empty)
                    proizvod = true;

                if (Kategorija.Text != String.Empty && item.Kategorija.Naziv.Equals(Kategorija.Text))
                    kategorija = true;
                if (Kategorija.Text == String.Empty)
                    kategorija = true;

                if(proizvod && kategorija)
                    listaProizvoda.Items.Add(temp);

                proizvod = false;
                kategorija = false;
            }
        }
    }
}
