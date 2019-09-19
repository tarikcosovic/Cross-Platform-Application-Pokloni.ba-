using MaterialSkin.Controls;
using Pokloni.ba.WinUI.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private byte[] _slika;
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

                Naziv.Text = result.Naziv;
                Sifra.Text = result.Sifra;
                Opis.Text = result.Opis.ToString();
                Cijena.Text = result.Cijena.ToString();
                StanjeNaLageru.Text = result.StanjeNaLageru.ToString();

                //POPRAVITI OVO I CITATI O STREAMS I BYTES AND STUFF
                //pictureBox1.Image = File.ReadAllBytes(result.Slika.ToString());


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

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
                var result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;

                    var file = File.ReadAllBytes(fileName);
                    _slika = file;

                    Image image = Image.FromFile(fileName);
                    pictureBox1.Image = image;

                }
         }

        private async void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] temp = new MaterialSingleLineTextField[2] { Naziv, Sifra };
            if (ValidationHelper.ValidateTextBoxes(temp, errorProvider1))
            {
                var ComboBoxKategorija = Kategorija.SelectedItem;
                var ComboBoxProizvodac = Proizvodac.SelectedItem;
                var model = new Model.Requests.Proizvodi.ProizvodVM()
                {
                    Naziv = Naziv.Text,
                    Sifra = Sifra.Text,
                    Opis = Opis.Text,
                    Cijena = int.Parse(Cijena.Text),
                    StanjeNaLageru = int.Parse(StanjeNaLageru.Text),
                    KategorijaId = ((Model.Requests.Proizvodi.Kategorije)ComboBoxKategorija).KategorijaId,
                    ProizvodacId = ((Model.Requests.Proizvodi.ProizvodacPoklona)ComboBoxProizvodac).ProizvodacPoklonaId,
                    Slika = _slika
                };

                await _APIService.Update<Model.Requests.Proizvodi.ProizvodVM>(model, _id);

                MessageBox.Show("Uspješno ste ažurirali proizvod..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
