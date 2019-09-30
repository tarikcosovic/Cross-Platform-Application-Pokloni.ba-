using MaterialSkin.Controls;
using Pokloni.ba.Model.Requests.Proizvodi;
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
                if(result.Slika != null && result.Slika.Length > 0)
                {
                    _slika = result.Slika;
                    pictureBox1.Image = GetImage(_slika);
                }
                else
                {
                    _slika = frmProizvodiInsert.ImageToByte(Properties.Resources.DefaultProductsImage);
                    pictureBox1.Image = Properties.Resources.DefaultProductsImage;
                }

                await GetKategorije(result.KategorijaId);
                await GetProizvodaci(result.ProizvodacId);

                //LoadFeedback(result.Ocjena);
                //LoadImageListView();
            }
        }
        //OVO NAMJESTITI I IZNAD OTKOMENTARISAT
        private async void LoadImageListView()
        {
            var result2 = await _APIService.Get<IEnumerable<Model.Requests.Proizvodi.ProizvodVM>>();
            ImageList test = new ImageList();

            foreach (var item in result2)
            {
                if (item.Slika != null && item.Slika.Length > 3)
                {
                    Image img = GetImage(item.Slika);
                    if (img != null)
                        test.Images.Add(item.Naziv, img);

                    var listViewItem = imgList.Items.Add("Test");
                    listViewItem.ImageKey = item.Naziv;
                }
            }
            imgList.View = View.LargeIcon;
            imgList.LargeImageList = test;
        }

        private void LoadFeedback(ICollection<OcjenaVM> ocjene)
        {
            listaOcjena.Clear();
            foreach(var ocjena in ocjene)
            {
                if(ocjena.ProizvodId == _id)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(ocjena.KorisnikId.ToString());
                    item.SubItems.Add(ocjena.NumerickaOcjena.ToString());
                    item.SubItems.Add(ocjena.Komentar);

                    listaOcjena.Items.Add(item);
                }
            }
        }
        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
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
            if (ValidationHelper.ValidateTextBoxes(new MaterialSingleLineTextField[2] { Naziv, Sifra }, errorProvider1) 
                && ValidationHelper.IsValidInteger( StanjeNaLageru , errorProvider1) 
                && ValidationHelper.IsValidDecimal(Cijena, errorProvider1)
                && ValidationHelper.IsComboBoxSelected(Kategorija, errorProvider1)
                && ValidationHelper.IsComboBoxSelected(Proizvodac, errorProvider1))
            {
                var ComboBoxKategorija = Kategorija.SelectedItem;
                var ComboBoxProizvodac = Proizvodac.SelectedItem;
                var model = new Model.Requests.Proizvodi.ProizvodVM()
                {
                    ProizvodId = (int)_id,
                    Naziv = Naziv.Text,
                    Sifra = Sifra.Text,
                    Opis = Opis.Text,
                    Cijena = decimal.Parse(Cijena.Text),
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

        private async void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite izbrisati proizvod?", "Brisanje proizvoda", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var result = await _APIService.Get<List<Model.Requests.Proizvodi.ProizvodVM>>();
                int? proizvodId = result.Where(k => k.ProizvodId == _id).Select(x => x.ProizvodId).FirstOrDefault();

                if (proizvodId.HasValue)
                {
                    await _APIService.Delete(proizvodId);
                    this.Close();
                    MessageBox.Show("Uspješno ste izbrisali proizvod..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Nepostojeći proizvod..", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
