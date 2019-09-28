namespace Pokloni.ba.WinUI.Narudzbe
{
    partial class frmNarudzbe
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
            this.listaNarudzbi = new MaterialSkin.Controls.MaterialListView();
            this.lblIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKorisnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblZaposlenik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDostavljac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikazi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPretraga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NarudzbeCount = new MaterialSkin.Controls.MaterialLabel();
            Dummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Dummy
            // 
            Dummy.Text = "";
            Dummy.Width = 0;
            // 
            // listaNarudzbi
            // 
            this.listaNarudzbi.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listaNarudzbi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaNarudzbi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Dummy,
            this.lblIndex,
            this.lblKorisnik,
            this.lblZaposlenik,
            this.lblDostavljac,
            this.lblStatus,
            this.lblDatum});
            this.listaNarudzbi.Depth = 0;
            this.listaNarudzbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listaNarudzbi.FullRowSelect = true;
            this.listaNarudzbi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaNarudzbi.Location = new System.Drawing.Point(52, 154);
            this.listaNarudzbi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaNarudzbi.MouseState = MaterialSkin.MouseState.OUT;
            this.listaNarudzbi.Name = "listaNarudzbi";
            this.listaNarudzbi.OwnerDraw = true;
            this.listaNarudzbi.Size = new System.Drawing.Size(797, 279);
            this.listaNarudzbi.TabIndex = 6;
            this.listaNarudzbi.UseCompatibleStateImageBehavior = false;
            this.listaNarudzbi.View = System.Windows.Forms.View.Details;
            // 
            // lblIndex
            // 
            this.lblIndex.Text = "Narudžba";
            this.lblIndex.Width = 100;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.Text = "Korisnik";
            this.lblKorisnik.Width = 100;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.Text = "Zaposlenik";
            this.lblZaposlenik.Width = 100;
            // 
            // lblDostavljac
            // 
            this.lblDostavljac.Text = "Dostavljač";
            this.lblDostavljac.Width = 100;
            // 
            // lblStatus
            // 
            this.lblStatus.Text = "Status";
            this.lblStatus.Width = 120;
            // 
            // lblDatum
            // 
            this.lblDatum.Text = "Datum";
            this.lblDatum.Width = 200;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrikazi.Depth = 0;
            this.btnPrikazi.Icon = null;
            this.btnPrikazi.Location = new System.Drawing.Point(555, 100);
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
            this.txtPretraga.Location = new System.Drawing.Point(52, 113);
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
            // NarudzbeCount
            // 
            this.NarudzbeCount.AutoSize = true;
            this.NarudzbeCount.Depth = 0;
            this.NarudzbeCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.NarudzbeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NarudzbeCount.Location = new System.Drawing.Point(48, 448);
            this.NarudzbeCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.NarudzbeCount.Name = "NarudzbeCount";
            this.NarudzbeCount.Size = new System.Drawing.Size(142, 19);
            this.NarudzbeCount.TabIndex = 7;
            this.NarudzbeCount.Text = "Aktivnih Narudžbi: 6";
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 595);
            this.Controls.Add(this.NarudzbeCount);
            this.Controls.Add(this.listaNarudzbi);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.FrmNarudzbe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listaNarudzbi;
        private System.Windows.Forms.ColumnHeader lblKorisnik;
        private System.Windows.Forms.ColumnHeader lblZaposlenik;
        private System.Windows.Forms.ColumnHeader lblDostavljac;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrikazi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraga;
        private System.Windows.Forms.ColumnHeader lblStatus;
        private System.Windows.Forms.ColumnHeader lblDatum;
        private MaterialSkin.Controls.MaterialLabel NarudzbeCount;
        private System.Windows.Forms.ColumnHeader lblIndex;
    }
}