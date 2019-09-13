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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();

            //InitialiseMyMaterialDesign(this);
        }

        private void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmKorisnici"] as frmKorisnici) != null)
            {
                //Forma otvorena
            }
            else
            {
                foreach (Form fr in this.MdiChildren)
                {
                    fr.Dispose();
                    fr.Close();
                }

                frmKorisnici frm = new frmKorisnici();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void NoviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciInsert frm = new frmKorisniciInsert();

            frm.Show();
        }
    }
}
