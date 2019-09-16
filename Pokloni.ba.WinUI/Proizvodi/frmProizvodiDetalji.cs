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
        public frmProizvodiDetalji()
        {
            InitializeComponent();

            InitialiseMyMaterialDesign(this);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();

            frm.Show();
        }
    }
}
