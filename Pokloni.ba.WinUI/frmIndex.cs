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

namespace Pokloni.ba.WinUI
{
    public partial class frmIndex : MyMaterialForm
    {
        public frmIndex()
        {
            InitializeComponent();

            InitialiseMyMaterialDesign(this);
        }

        private void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();

           // frm.MdiParent = this;
            frm.Show();
        }

        private void NoviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciInsert frm = new frmKorisniciInsert();

            frm.Show();
        }
    }
}
