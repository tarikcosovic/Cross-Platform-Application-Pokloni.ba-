namespace Pokloni.ba.WinUI.Proizvodi
{
    partial class frmProizvodiInsert
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProizvodiInsert));
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Sifra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Opis = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Cijena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelbraca = new MaterialSkin.Controls.MaterialLabel();
            this.StanjeNaLageru = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Kategorija = new System.Windows.Forms.ComboBox();
            this.Proizvodac = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Naziv = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDodajSliku = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(714, 131);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 42;
            this.materialLabel4.Text = "Sifra";
            // 
            // Sifra
            // 
            this.Sifra.Depth = 0;
            this.Sifra.Hint = "";
            this.Sifra.Location = new System.Drawing.Point(718, 153);
            this.Sifra.MaxLength = 32767;
            this.Sifra.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sifra.Name = "Sifra";
            this.Sifra.PasswordChar = '\0';
            this.Sifra.SelectedText = "";
            this.Sifra.SelectionLength = 0;
            this.Sifra.SelectionStart = 0;
            this.Sifra.Size = new System.Drawing.Size(112, 23);
            this.Sifra.TabIndex = 41;
            this.Sifra.TabStop = false;
            this.Sifra.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(748, 355);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(82, 36);
            this.materialRaisedButton1.TabIndex = 40;
            this.materialRaisedButton1.Text = "Sačuvaj";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(206, 131);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(39, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Opis";
            // 
            // Opis
            // 
            this.Opis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opis.Location = new System.Drawing.Point(210, 153);
            this.Opis.Multiline = true;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(187, 139);
            this.Opis.TabIndex = 38;
            this.Opis.Text = "Upišite vaš željeni opis ovdje..";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(714, 182);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 37;
            this.materialLabel5.Text = "Cijena";
            // 
            // Cijena
            // 
            this.Cijena.Depth = 0;
            this.Cijena.Hint = "";
            this.Cijena.Location = new System.Drawing.Point(718, 204);
            this.Cijena.MaxLength = 32767;
            this.Cijena.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cijena.Name = "Cijena";
            this.Cijena.PasswordChar = '\0';
            this.Cijena.SelectedText = "";
            this.Cijena.SelectionLength = 0;
            this.Cijena.SelectionStart = 0;
            this.Cijena.Size = new System.Drawing.Size(112, 23);
            this.Cijena.TabIndex = 36;
            this.Cijena.TabStop = false;
            this.Cijena.UseSystemPasswordChar = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(771, 285);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 26);
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(741, 285);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 26);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // labelbraca
            // 
            this.labelbraca.AutoSize = true;
            this.labelbraca.Depth = 0;
            this.labelbraca.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelbraca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelbraca.Location = new System.Drawing.Point(714, 234);
            this.labelbraca.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelbraca.Name = "labelbraca";
            this.labelbraca.Size = new System.Drawing.Size(116, 19);
            this.labelbraca.TabIndex = 33;
            this.labelbraca.Text = "Stanje na lageru";
            // 
            // StanjeNaLageru
            // 
            this.StanjeNaLageru.Depth = 0;
            this.StanjeNaLageru.Hint = "";
            this.StanjeNaLageru.Location = new System.Drawing.Point(718, 256);
            this.StanjeNaLageru.MaxLength = 32767;
            this.StanjeNaLageru.MouseState = MaterialSkin.MouseState.HOVER;
            this.StanjeNaLageru.Name = "StanjeNaLageru";
            this.StanjeNaLageru.PasswordChar = '\0';
            this.StanjeNaLageru.SelectedText = "";
            this.StanjeNaLageru.SelectionLength = 0;
            this.StanjeNaLageru.SelectionStart = 0;
            this.StanjeNaLageru.Size = new System.Drawing.Size(112, 23);
            this.StanjeNaLageru.TabIndex = 32;
            this.StanjeNaLageru.TabStop = false;
            this.StanjeNaLageru.Text = "0";
            this.StanjeNaLageru.UseSystemPasswordChar = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(660, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(660, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // Kategorija
            // 
            this.Kategorija.FormattingEnabled = true;
            this.Kategorija.Location = new System.Drawing.Point(449, 258);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(205, 21);
            this.Kategorija.TabIndex = 29;
            // 
            // Proizvodac
            // 
            this.Proizvodac.FormattingEnabled = true;
            this.Proizvodac.Location = new System.Drawing.Point(449, 206);
            this.Proizvodac.Name = "Proizvodac";
            this.Proizvodac.Size = new System.Drawing.Size(205, 21);
            this.Proizvodac.TabIndex = 28;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(445, 234);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Kategorija";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(445, 184);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Proizvođač";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(445, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Naziv";
            // 
            // Naziv
            // 
            this.Naziv.Depth = 0;
            this.Naziv.Hint = "";
            this.Naziv.Location = new System.Drawing.Point(449, 153);
            this.Naziv.MaxLength = 32767;
            this.Naziv.MouseState = MaterialSkin.MouseState.HOVER;
            this.Naziv.Name = "Naziv";
            this.Naziv.PasswordChar = '\0';
            this.Naziv.SelectedText = "";
            this.Naziv.SelectionLength = 0;
            this.Naziv.SelectionStart = 0;
            this.Naziv.Size = new System.Drawing.Size(205, 23);
            this.Naziv.TabIndex = 24;
            this.Naziv.TabStop = false;
            this.Naziv.UseSystemPasswordChar = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Pokloni.ba.WinUI.Properties.Resources.DefaultProductsImage;
            this.pictureBox.Location = new System.Drawing.Point(34, 135);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(155, 153);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.AutoSize = true;
            this.btnDodajSliku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDodajSliku.Depth = 0;
            this.btnDodajSliku.Icon = null;
            this.btnDodajSliku.Location = new System.Drawing.Point(77, 297);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDodajSliku.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Primary = false;
            this.btnDodajSliku.Size = new System.Drawing.Size(65, 36);
            this.btnDodajSliku.TabIndex = 43;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProizvodiInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 424);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.Cijena);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelbraca);
            this.Controls.Add(this.StanjeNaLageru);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.Proizvodac);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.pictureBox);
            this.Name = "frmProizvodiInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Proizvod";
            this.Load += new System.EventHandler(this.FrmProizvodiInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField Sifra;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox Opis;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Cijena;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialLabel labelbraca;
        private MaterialSkin.Controls.MaterialSingleLineTextField StanjeNaLageru;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Kategorija;
        private System.Windows.Forms.ComboBox Proizvodac;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Naziv;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialFlatButton btnDodajSliku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}