namespace Pokloni.ba.WinUI.Proizvodi
{
    partial class frmProizvodiDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProizvodiDetalji));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NazivProizvoda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Proizvodac = new System.Windows.Forms.ComboBox();
            this.Kategorija = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelbraca = new MaterialSkin.Controls.MaterialLabel();
            this.StanjeNaLageru = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Cijena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Opis = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.Sifra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NazivProizvoda
            // 
            this.NazivProizvoda.Depth = 0;
            this.NazivProizvoda.Hint = "";
            this.NazivProizvoda.Location = new System.Drawing.Point(445, 103);
            this.NazivProizvoda.MaxLength = 32767;
            this.NazivProizvoda.MouseState = MaterialSkin.MouseState.HOVER;
            this.NazivProizvoda.Name = "NazivProizvoda";
            this.NazivProizvoda.PasswordChar = '\0';
            this.NazivProizvoda.SelectedText = "";
            this.NazivProizvoda.SelectionLength = 0;
            this.NazivProizvoda.SelectionStart = 0;
            this.NazivProizvoda.Size = new System.Drawing.Size(205, 23);
            this.NazivProizvoda.TabIndex = 1;
            this.NazivProizvoda.TabStop = false;
            this.NazivProizvoda.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(441, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Naziv";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(441, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Proizvođač";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(441, 184);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Kategorija";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 218);
            this.dataGridView1.TabIndex = 7;
            // 
            // Proizvodac
            // 
            this.Proizvodac.FormattingEnabled = true;
            this.Proizvodac.Location = new System.Drawing.Point(445, 156);
            this.Proizvodac.Name = "Proizvodac";
            this.Proizvodac.Size = new System.Drawing.Size(205, 21);
            this.Proizvodac.TabIndex = 8;
            // 
            // Kategorija
            // 
            this.Kategorija.FormattingEnabled = true;
            this.Kategorija.Location = new System.Drawing.Point(445, 208);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(205, 21);
            this.Kategorija.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(656, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(656, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // labelbraca
            // 
            this.labelbraca.AutoSize = true;
            this.labelbraca.Depth = 0;
            this.labelbraca.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelbraca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelbraca.Location = new System.Drawing.Point(710, 184);
            this.labelbraca.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelbraca.Name = "labelbraca";
            this.labelbraca.Size = new System.Drawing.Size(116, 19);
            this.labelbraca.TabIndex = 13;
            this.labelbraca.Text = "Stanje na lageru";
            // 
            // StanjeNaLageru
            // 
            this.StanjeNaLageru.Depth = 0;
            this.StanjeNaLageru.Hint = "";
            this.StanjeNaLageru.Location = new System.Drawing.Point(714, 206);
            this.StanjeNaLageru.MaxLength = 32767;
            this.StanjeNaLageru.MouseState = MaterialSkin.MouseState.HOVER;
            this.StanjeNaLageru.Name = "StanjeNaLageru";
            this.StanjeNaLageru.PasswordChar = '\0';
            this.StanjeNaLageru.SelectedText = "";
            this.StanjeNaLageru.SelectionLength = 0;
            this.StanjeNaLageru.SelectionStart = 0;
            this.StanjeNaLageru.Size = new System.Drawing.Size(112, 23);
            this.StanjeNaLageru.TabIndex = 12;
            this.StanjeNaLageru.TabStop = false;
            this.StanjeNaLageru.Text = "23";
            this.StanjeNaLageru.UseSystemPasswordChar = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(737, 235);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 26);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(767, 235);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 26);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(710, 132);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Cijena";
            // 
            // Cijena
            // 
            this.Cijena.Depth = 0;
            this.Cijena.Hint = "";
            this.Cijena.Location = new System.Drawing.Point(714, 154);
            this.Cijena.MaxLength = 32767;
            this.Cijena.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cijena.Name = "Cijena";
            this.Cijena.PasswordChar = '\0';
            this.Cijena.SelectedText = "";
            this.Cijena.SelectionLength = 0;
            this.Cijena.SelectionStart = 0;
            this.Cijena.Size = new System.Drawing.Size(112, 23);
            this.Cijena.TabIndex = 16;
            this.Cijena.TabStop = false;
            this.Cijena.UseSystemPasswordChar = false;
            // 
            // Opis
            // 
            this.Opis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opis.Location = new System.Drawing.Point(206, 103);
            this.Opis.Multiline = true;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(187, 139);
            this.Opis.TabIndex = 18;
            this.Opis.Text = resources.GetString("Opis.Text");
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(202, 81);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(39, 19);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "Opis";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(877, 238);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(82, 36);
            this.materialRaisedButton1.TabIndex = 20;
            this.materialRaisedButton1.Text = "Sačuvaj";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(710, 81);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Sifra";
            // 
            // Sifra
            // 
            this.Sifra.Depth = 0;
            this.Sifra.Hint = "";
            this.Sifra.Location = new System.Drawing.Point(714, 103);
            this.Sifra.MaxLength = 32767;
            this.Sifra.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sifra.Name = "Sifra";
            this.Sifra.PasswordChar = '\0';
            this.Sifra.SelectedText = "";
            this.Sifra.SelectionLength = 0;
            this.Sifra.SelectionStart = 0;
            this.Sifra.Size = new System.Drawing.Size(112, 23);
            this.Sifra.TabIndex = 21;
            this.Sifra.TabStop = false;
            this.Sifra.UseSystemPasswordChar = false;
            // 
            // frmProizvodiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 531);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.NazivProizvoda);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmProizvodiDetalji";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji proizvoda";
            this.Load += new System.EventHandler(this.FrmProizvodiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField NazivProizvoda;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Proizvodac;
        private System.Windows.Forms.ComboBox Kategorija;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel labelbraca;
        private MaterialSkin.Controls.MaterialSingleLineTextField StanjeNaLageru;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Cijena;
        private System.Windows.Forms.TextBox Opis;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField Sifra;
    }
}