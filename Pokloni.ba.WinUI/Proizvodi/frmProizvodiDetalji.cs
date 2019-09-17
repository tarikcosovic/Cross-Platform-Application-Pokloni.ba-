using Pokloni.ba.WinUI.Korisnici;
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
    public partial class frmProizvodiDetalji : MyMaterialForm
    {
        private readonly APIService _APIService = new APIService(Properties.Settings.Default.RouteProizvodi);
        private readonly APIService _APIServiceProizvodaci = new APIService(Properties.Settings.Default.RouteProizvodaci);
        private readonly APIService _APIServiceKategorije = new APIService(Properties.Settings.Default.RouteKategorije);

        private readonly int? _id = null;
        public frmProizvodiDetalji(int id)
        {
            InitializeComponent();

            InitialiseMyMaterialDesign(this);
            _id = id;
        }

        private async void FrmProizvodiDetalji_Load(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var result = await _APIService.GetbyId<Model.Requests.Proizvodi.ProizvodVM>(_id);

                NazivProizvoda.Text = result.Naziv;
                Sifra.Text = result.Sifra;
                Opis.Text = result.Opis.ToString();
                Cijena.Text = result.Cijena.ToString();
                StanjeNaLageru.Text = result.StanjeNaLageru.ToString();

                await GetKategorije(result.KategorijaId);
                await GetProizvodaci(result.ProizvodacId);
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();

            frm.Show();
        }

        private async Task GetProizvodaci(int selectedId)
        {
            var model = await _APIServiceProizvodaci.Get<List<Model.Requests.Proizvodi.ProizvodacPoklona>>("");
            model.Insert(0, new Model.Requests.Proizvodi.ProizvodacPoklona());

            Proizvodac.DataSource = model;
            Proizvodac.DisplayMember = "Naziv";
            Proizvodac.ValueMember = "ProizvodacPoklonaId";
            Proizvodac.SelectedItem = model.Where(k => k.ProizvodacPoklonaId == selectedId).FirstOrDefault();
        }


        private async Task GetKategorije(int selectedId)
        {
            var model = await _APIServiceKategorije.Get<List<Model.Requests.Proizvodi.Kategorije>>("");
            model.Insert(0, new Model.Requests.Proizvodi.Kategorije());

            Kategorija.DataSource = model;
            Kategorija.DisplayMember = "Naziv";
            Kategorija.ValueMember = "KategorijaId";
            Kategorija.SelectedItem = model.Where(k => k.KategorijaId == selectedId).FirstOrDefault();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            var vrijednost = int.Parse(StanjeNaLageru.Text);
            ++vrijednost;

            StanjeNaLageru.Text = vrijednost.ToString();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            var vrijednost = int.Parse(StanjeNaLageru.Text);
            --vrijednost;

            StanjeNaLageru.Text = vrijednost.ToString();
        }
    }
}
