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
    public partial class frmKategorijeInsert : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteKategorije);

        public frmKategorijeInsert()
        {
            InitializeComponent();
            InitialiseMyMaterialDesign(this);
        }

        private async void Sacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.ValidateTextBoxes(new MaterialSingleLineTextField[1] { Naziv }, errorProvider1))
            {
                Model.Requests.Proizvodi.Kategorije model = new Model.Requests.Proizvodi.Kategorije()
                {
                    Naziv = Naziv.Text,
                    Opis = Opis.Text
                };

                await _apiService.Insert<Model.Requests.Proizvodi.Kategorije>(model);
                MessageBox.Show("Uspješno ste dodali kategoriju..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
