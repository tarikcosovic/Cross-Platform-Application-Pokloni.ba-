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

namespace Pokloni.ba.WinUI.Proizvodaci
{
    public partial class frmProizvodaciInsert : MyMaterialForm
    {
        private readonly APIService _apiService = new APIService(Properties.Settings.Default.RouteProizvodaci);
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
                    Opis = Opis.Text
                };

                await _apiService.Insert<Model.Requests.Proizvodi.ProizvodacPoklona>(model);
                MessageBox.Show("Uspješno ste dodali proizvođača..", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
