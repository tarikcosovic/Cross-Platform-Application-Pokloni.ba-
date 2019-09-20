using MaterialSkin.Controls;
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
    public partial class frmProizvodiInsert : MyMaterialForm
    {
        private readonly APIService _apiServiceProizvodi = new APIService(Properties.Settings.Default.RouteProizvodi);
        private readonly APIService _apiServiceKategorije = new APIService(Properties.Settings.Default.RouteKategorije);
        private readonly APIService _apiServiceProizvodaci = new APIService(Properties.Settings.Default.RouteProizvodaci);

        private byte[] _slika;
        public frmProizvodiInsert()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private async void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            MaterialSingleLineTextField[] temp = new MaterialSingleLineTextField[2] { Naziv, Sifra};
            if (ValidationHelper.ValidateTextBoxes(temp, errorProvider)
                && ValidationHelper.IsValidInteger(StanjeNaLageru, errorProvider)
                && ValidationHelper.IsValidDecimal(Cijena, errorProvider)
                && ValidationHelper.IsComboBoxSelected(Kategorija, errorProvider)
                && ValidationHelper.IsComboBoxSelected(Proizvodac, errorProvider))
            {
                var ComboBoxKategorija = Kategorija.SelectedItem;
                var ComboBoxProizvodac = Proizvodac.SelectedItem;
                var model = new Model.Requests.Proizvodi.ProizvodVM()
                {
                    Naziv = Naziv.Text,
                    Sifra = Sifra.Text,
                    Opis = Opis.Text,
                    Cijena = decimal.Parse(Cijena.Text),
                    StanjeNaLageru = int.Parse(StanjeNaLageru.Text),
                    KategorijaId = ((Model.Requests.Proizvodi.Kategorije)ComboBoxKategorija).KategorijaId,
                    ProizvodacId = ((Model.Requests.Proizvodi.ProizvodacPoklona)ComboBoxProizvodac).ProizvodacPoklonaId,
                    Slika = _slika
                };

                await _apiServiceProizvodi.Insert<Model.Requests.Proizvodi.ProizvodVM>(model);

                MessageBox.Show("Uspješno ste dodali proizvod..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
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

        private async void FrmProizvodiInsert_Load(object sender, EventArgs e)
        {
            _slika = ImageToByte(Properties.Resources.DefaultProductsImage);
            pictureBox.Image = Properties.Resources.DefaultProductsImage;
            //TO DO HERE:
            //POSTAVITI SLIKA VALUE DA JE PO DEFAULTU JEDNAKA ONOJ U PROPERTIES!

            await LoadKategorije();
            await LoadProizvodac();
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            var vrijednost = int.Parse(StanjeNaLageru.Text);
            ++vrijednost;

            StanjeNaLageru.Text = vrijednost.ToString();
        }

        private void PictureBox5_Click_1(object sender, EventArgs e)
        {
            var vrijednost = int.Parse(StanjeNaLageru.Text);
            --vrijednost;

            StanjeNaLageru.Text = vrijednost.ToString();

        }

        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);
                _slika = file;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;

            }
        }

    }
}
