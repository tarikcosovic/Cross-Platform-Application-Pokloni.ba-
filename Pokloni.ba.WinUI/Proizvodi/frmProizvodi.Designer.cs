namespace Pokloni.ba.WinUI.Proizvodi
{
    partial class frmProizvodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader Dummy;
            this.listaProizvoda = new MaterialSkin.Controls.MaterialListView();
            this.listNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSifra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listKategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listProizvodac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listStanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikazi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPretraga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            Dummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Dummy
            // 
            Dummy.Text = "";
            Dummy.Width = 0;
            // 
            // listaProizvoda
            // 
            this.listaProizvoda.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listaProizvoda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProizvoda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Dummy,
            this.listNaziv,
            this.listSifra,
            this.listKategorija,
            this.listProizvodac,
            this.listCijena,
            this.listStanje});
            this.listaProizvoda.Depth = 0;
            this.listaProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listaProizvoda.FullRowSelect = true;
            this.listaProizvoda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaProizvoda.Location = new System.Drawing.Point(120, 164);
            this.listaProizvoda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaProizvoda.MouseState = MaterialSkin.MouseState.OUT;
            this.listaProizvoda.MultiSelect = false;
            this.listaProizvoda.Name = "listaProizvoda";
            this.listaProizvoda.OwnerDraw = true;
            this.listaProizvoda.Size = new System.Drawing.Size(561, 284);
            this.listaProizvoda.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listaProizvoda.TabIndex = 6;
            this.listaProizvoda.UseCompatibleStateImageBehavior = false;
            this.listaProizvoda.View = System.Windows.Forms.View.Details;
            this.listaProizvoda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaProizvoda_MouseDoubleClick_1);
            // 
            // listNaziv
            // 
            this.listNaziv.Text = "Naziv";
            this.listNaziv.Width = 96;
            // 
            // listSifra
            // 
            this.listSifra.Text = "Šifra";
            this.listSifra.Width = 76;
            // 
            // listKategorija
            // 
            this.listKategorija.Text = "Kategorija";
            this.listKategorija.Width = 92;
            // 
            // listProizvodac
            // 
            this.listProizvodac.Text = "Proizvođač";
            this.listProizvodac.Width = 110;
            // 
            // listCijena
            // 
            this.listCijena.Text = "Cijena";
            this.listCijena.Width = 72;
            // 
            // listStanje
            // 
            this.listStanje.Text = "Stanje";
            this.listStanje.Width = 100;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrikazi.Depth = 0;
            this.btnPrikazi.Icon = null;
            this.btnPrikazi.Location = new System.Drawing.Point(597, 104);
            this.btnPrikazi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Primary = true;
            this.btnPrikazi.Size = new System.Drawing.Size(84, 36);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Pretraži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Depth = 0;
            this.txtPretraga.Hint = "";
            this.txtPretraga.Location = new System.Drawing.Point(120, 117);
            this.txtPretraga.MaxLength = 32767;
            this.txtPretraga.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.PasswordChar = '\0';
            this.txtPretraga.SelectedText = "";
            this.txtPretraga.SelectionLength = 0;
            this.txtPretraga.SelectionStart = 0;
            this.txtPretraga.Size = new System.Drawing.Size(454, 23);
            this.txtPretraga.TabIndex = 4;
            this.txtPretraga.TabStop = false;
            this.txtPretraga.UseSystemPasswordChar = false;
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaProizvoda);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmProizvodi";
            this.Text = "Lista proizvoda";
            this.Load += new System.EventHandler(this.FrmProizvodi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader listNaziv;
        private System.Windows.Forms.ColumnHeader listSifra;
        private System.Windows.Forms.ColumnHeader listKategorija;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrikazi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraga;
        private System.Windows.Forms.ColumnHeader listProizvodac;
        private System.Windows.Forms.ColumnHeader listCijena;
        private System.Windows.Forms.ColumnHeader listStanje;
        private MaterialSkin.Controls.MaterialListView listaProizvoda;
    }
}