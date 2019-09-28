using Pokloni.ba.WinUI.Kategorije;
using Pokloni.ba.WinUI.Korisnici;
using Pokloni.ba.WinUI.Narudzbe;
using Pokloni.ba.WinUI.Proizvodaci;
using Pokloni.ba.WinUI.Proizvodi;
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
        //Početna stranica
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            logiraniKorisnik.Text += APIService.Username;
            logiraniKorisnik.ForeColor = Color.White;
            btnOdjava.ForeColor = Color.White;

            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
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

        private void PretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmProizvodi"] as frmProizvodi) != null)
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

                frmProizvodi frm = new frmProizvodi();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void NoviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProizvodiInsert frm = new frmProizvodiInsert();

            frm.Show();
        }

        private void ProizvođačiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmProizvodaci"] as frmProizvodaci) != null)
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

                frmProizvodaci frm = new frmProizvodaci();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void UnosNovogProizvođačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProizvodaciInsert frm = new frmProizvodaciInsert();

            frm.Show();
        }

        private void KategorijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmKategorije"] as frmKategorije) != null)
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

                frmKategorije frm = new frmKategorije();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void NovaKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijeInsert frm = new frmKategorijeInsert();

            frm.Show();
        }

        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            APIService.Username = "";
            APIService.Password = "";

            this.Close();

            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void NarudžbeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmNarudzbe"] as frmNarudzbe) != null)
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

                frmNarudzbe frm = new frmNarudzbe();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }
    }
}
