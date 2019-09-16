namespace Pokloni.ba.WinUI.Korisnici
{
    partial class frmKorisniciInsert
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
            this.Uloga = new System.Windows.Forms.ComboBox();
            this.Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordConfirmation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Uloga
            // 
            this.Uloga.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uloga.FormattingEnabled = true;
            this.Uloga.Items.AddRange(new object[] {
            "Admin",
            "Korisnik",
            "Zaposlenik",
            "Dostavljać"});
            this.Uloga.Location = new System.Drawing.Point(169, 364);
            this.Uloga.Name = "Uloga";
            this.Uloga.Size = new System.Drawing.Size(104, 27);
            this.Uloga.TabIndex = 10;
            // 
            // Username
            // 
            this.Username.Depth = 0;
            this.Username.Hint = "";
            this.Username.Location = new System.Drawing.Point(169, 108);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.SelectedText = "";
            this.Username.SelectionLength = 0;
            this.Username.SelectionStart = 0;
            this.Username.Size = new System.Drawing.Size(202, 23);
            this.Username.TabIndex = 12;
            this.Username.TabStop = false;
            this.Username.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(165, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(165, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "E-mail";
            // 
            // Email
            // 
            this.Email.Depth = 0;
            this.Email.Hint = "";
            this.Email.Location = new System.Drawing.Point(169, 171);
            this.Email.MaxLength = 100;
            this.Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.Size = new System.Drawing.Size(202, 23);
            this.Email.TabIndex = 14;
            this.Email.TabStop = false;
            this.Email.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(165, 211);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Depth = 0;
            this.Password.Hint = "";
            this.Password.Location = new System.Drawing.Point(169, 233);
            this.Password.MaxLength = 64;
            this.Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '♟';
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(202, 23);
            this.Password.TabIndex = 16;
            this.Password.TabStop = false;
            this.Password.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(165, 271);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Confirm Password";
            // 
            // PasswordConfirmation
            // 
            this.PasswordConfirmation.Depth = 0;
            this.PasswordConfirmation.Hint = "";
            this.PasswordConfirmation.Location = new System.Drawing.Point(169, 293);
            this.PasswordConfirmation.MaxLength = 64;
            this.PasswordConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordConfirmation.Name = "PasswordConfirmation";
            this.PasswordConfirmation.PasswordChar = '♟';
            this.PasswordConfirmation.SelectedText = "";
            this.PasswordConfirmation.SelectionLength = 0;
            this.PasswordConfirmation.SelectionStart = 0;
            this.PasswordConfirmation.Size = new System.Drawing.Size(202, 23);
            this.PasswordConfirmation.TabIndex = 18;
            this.PasswordConfirmation.TabStop = false;
            this.PasswordConfirmation.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(165, 332);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Uloga";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(281, 430);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(82, 36);
            this.materialRaisedButton1.TabIndex = 22;
            this.materialRaisedButton1.Text = "Sačuvaj";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmKorisniciInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 511);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.PasswordConfirmation);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Uloga);
            this.Name = "frmKorisniciInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unesite novog korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Uloga;
        private MaterialSkin.Controls.MaterialSingleLineTextField Username;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Email;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordConfirmation;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}