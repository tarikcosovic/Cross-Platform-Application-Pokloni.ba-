using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI.Kategorije
{
    public partial class frmKategorijeDetails : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteKategorije);
        private int? _id;
        public frmKategorijeDetails(int id)
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);

            _id = id;
        }

        private async void FrmKategorijeDetails_Load_1(object sender, EventArgs e)
        {
            var result = await _apiService.GetbyId<Model.Requests.Proizvodi.Kategorije>(_id);

            Naziv.Text = result.Naziv;
            Opis.Text = result.Opis;
        }
        private async void Sacuvaj_Click_1(object sender, EventArgs e)
        {
            if (ValidationHelper.ValidateTextBoxes(new MaterialSingleLineTextField[1] { Naziv }, errorProvider1) && _id.HasValue)
            {
                Model.Requests.Proizvodi.Kategorije model = new Model.Requests.Proizvodi.Kategorije()
                {
                    KategorijaId = (int)_id,
                    Naziv = Naziv.Text,
                    Opis = Opis.Text
                };

                await _apiService.Update<Model.Requests.Proizvodi.Kategorije>(model, _id);
                MessageBox.Show("Uspješno ste ažurirali kategoriju..", " !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private async void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da želite izbrisati kategoriju?", "Brisanje kategorije!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                await _apiService.Delete(_id);
                this.Close();
                MessageBox.Show("Uspješno ste izbrisali kategoriju..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
