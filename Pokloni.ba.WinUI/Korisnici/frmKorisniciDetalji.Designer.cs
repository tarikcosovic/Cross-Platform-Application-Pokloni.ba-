namespace Pokloni.ba.WinUI.Korisnici
{
    partial class frmKorisniciDetalji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKorisniciDetalji));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Prezime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Drzava = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Grad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Adresa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BrojTelefona = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ZipCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Ime
            // 
            this.Ime.Depth = 0;
            this.Ime.Hint = "";
            this.Ime.Location = new System.Drawing.Point(89, 129);
            this.Ime.MaxLength = 32767;
            this.Ime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Ime.Name = "Ime";
            this.Ime.PasswordChar = '\0';
            this.Ime.SelectedText = "";
            this.Ime.SelectionLength = 0;
            this.Ime.SelectionStart = 0;
            this.Ime.Size = new System.Drawing.Size(263, 23);
            this.Ime.TabIndex = 15;
            this.Ime.TabStop = false;
            this.Ime.UseSystemPasswordChar = false;
            // 
            // Prezime
            // 
            this.Prezime.Depth = 0;
            this.Prezime.Hint = "";
            this.Prezime.Location = new System.Drawing.Point(89, 195);
            this.Prezime.MaxLength = 32767;
            this.Prezime.MouseState = MaterialSkin.MouseState.HOVER;
            this.Prezime.Name = "Prezime";
            this.Prezime.PasswordChar = '\0';
            this.Prezime.SelectedText = "";
            this.Prezime.SelectionLength = 0;
            this.Prezime.SelectionStart = 0;
            this.Prezime.Size = new System.Drawing.Size(263, 23);
            this.Prezime.TabIndex = 16;
            this.Prezime.TabStop = false;
            this.Prezime.UseSystemPasswordChar = false;
            // 
            // Drzava
            // 
            this.Drzava.Depth = 0;
            this.Drzava.Hint = "";
            this.Drzava.Location = new System.Drawing.Point(446, 129);
            this.Drzava.MaxLength = 32767;
            this.Drzava.MouseState = MaterialSkin.MouseState.HOVER;
            this.Drzava.Name = "Drzava";
            this.Drzava.PasswordChar = '\0';
            this.Drzava.SelectedText = "";
            this.Drzava.SelectionLength = 0;
            this.Drzava.SelectionStart = 0;
            this.Drzava.Size = new System.Drawing.Size(263, 23);
            this.Drzava.TabIndex = 17;
            this.Drzava.TabStop = false;
            this.Drzava.UseSystemPasswordChar = false;
            // 
            // Grad
            // 
            this.Grad.Depth = 0;
            this.Grad.Hint = "";
            this.Grad.Location = new System.Drawing.Point(446, 195);
            this.Grad.MaxLength = 32767;
            this.Grad.MouseState = MaterialSkin.MouseState.HOVER;
            this.Grad.Name = "Grad";
            this.Grad.PasswordChar = '\0';
            this.Grad.SelectedText = "";
            this.Grad.SelectionLength = 0;
            this.Grad.SelectionStart = 0;
            this.Grad.Size = new System.Drawing.Size(263, 23);
            this.Grad.TabIndex = 18;
            this.Grad.TabStop = false;
            this.Grad.UseSystemPasswordChar = false;
            // 
            // Adresa
            // 
            this.Adresa.Depth = 0;
            this.Adresa.Hint = "";
            this.Adresa.Location = new System.Drawing.Point(446, 266);
            this.Adresa.MaxLength = 32767;
            this.Adresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.Adresa.Name = "Adresa";
            this.Adresa.PasswordChar = '\0';
            this.Adresa.SelectedText = "";
            this.Adresa.SelectionLength = 0;
            this.Adresa.SelectionStart = 0;
            this.Adresa.Size = new System.Drawing.Size(263, 23);
            this.Adresa.TabIndex = 19;
            this.Adresa.TabStop = false;
            this.Adresa.UseSystemPasswordChar = false;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Depth = 0;
            this.BrojTelefona.Hint = "";
            this.BrojTelefona.Location = new System.Drawing.Point(89, 266);
            this.BrojTelefona.MaxLength = 32767;
            this.BrojTelefona.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.PasswordChar = '\0';
            this.BrojTelefona.SelectedText = "";
            this.BrojTelefona.SelectionLength = 0;
            this.BrojTelefona.SelectionStart = 0;
            this.BrojTelefona.Size = new System.Drawing.Size(263, 23);
            this.BrojTelefona.TabIndex = 20;
            this.BrojTelefona.TabStop = false;
            this.BrojTelefona.UseSystemPasswordChar = false;
            // 
            // ZipCode
            // 
            this.ZipCode.Depth = 0;
            this.ZipCode.Hint = "";
            this.ZipCode.Location = new System.Drawing.Point(730, 195);
            this.ZipCode.MaxLength = 32767;
            this.ZipCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.PasswordChar = '\0';
            this.ZipCode.SelectedText = "";
            this.ZipCode.SelectionLength = 0;
            this.ZipCode.SelectionStart = 0;
            this.ZipCode.Size = new System.Drawing.Size(107, 23);
            this.ZipCode.TabIndex = 21;
            this.ZipCode.TabStop = false;
            this.ZipCode.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(85, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(34, 19);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "Ime";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(85, 173);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Prezime";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(442, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 29;
            this.materialLabel2.Text = "Grad";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(85, 244);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 19);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Broj Telefona";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(442, 244);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(56, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Adresa";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(726, 173);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 19);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "Postal Code";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(442, 107);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(54, 19);
            this.materialLabel7.TabIndex = 33;
            this.materialLabel7.Text = "Država";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(614, 310);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(95, 55);
            this.materialRaisedButton1.TabIndex = 34;
            this.materialRaisedButton1.Text = "Sačuvaj";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // frmKorisniciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 445);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.ZipCode);
            this.Controls.Add(this.BrojTelefona);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Grad);
            this.Controls.Add(this.Drzava);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Ime);
            this.Name = "frmKorisniciDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji korisnika";
            this.Load += new System.EventHandler(this.FrmKorisniciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialSingleLineTextField Ime;
        private MaterialSkin.Controls.MaterialSingleLineTextField ZipCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField BrojTelefona;
        private MaterialSkin.Controls.MaterialSingleLineTextField Adresa;
        private MaterialSkin.Controls.MaterialSingleLineTextField Grad;
        private MaterialSkin.Controls.MaterialSingleLineTextField Drzava;
        private MaterialSkin.Controls.MaterialSingleLineTextField Prezime;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}