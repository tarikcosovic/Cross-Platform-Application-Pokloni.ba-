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

namespace Pokloni.ba.WinUI.Proizvodaci
{
    public partial class frmProizvodaciInsert : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteProizvodaci);
        byte[] _slika;
        public frmProizvodaciInsert()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private async void Sacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.ValidateTextBoxes(new MaterialSingleLineTextField[1] { Naziv }, errorProvider1))
            {
                Model.Requests.Proizvodi.ProizvodacPoklona model = new Model.Requests.Proizvodi.ProizvodacPoklona()
                {
                    Naziv = Naziv.Text,
                    Opis = Opis.Text,
                    Slika = _slika
                };

                await _apiService.Insert<Model.Requests.Proizvodi.ProizvodacPoklona>(model);
                MessageBox.Show("Uspješno ste dodali proizvođača..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
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

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void FrmProizvodaciInsert_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(ImageToByte(Properties.Resources.DefaultProductsImage));
            pictureBox1.Image = Image.FromStream(ms);
            _slika = ImageToByte(Properties.Resources.DefaultProductsImage);
        }
    }
}
