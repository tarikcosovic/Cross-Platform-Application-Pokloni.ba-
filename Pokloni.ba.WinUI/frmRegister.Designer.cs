namespace Pokloni.ba.WinUI
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.Register = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordConfirmation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Register.Depth = 0;
            this.Register.Icon = null;
            this.Register.Location = new System.Drawing.Point(436, 490);
            this.Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.Register.Name = "Register";
            this.Register.Primary = true;
            this.Register.Size = new System.Drawing.Size(83, 36);
            this.Register.TabIndex = 13;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Pokloni.ba.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(375, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(370, 411);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Confirm Password";
            // 
            // PasswordConfirmation
            // 
            this.PasswordConfirmation.Depth = 0;
            this.PasswordConfirmation.Hint = "";
            this.PasswordConfirmation.Location = new System.Drawing.Point(374, 433);
            this.PasswordConfirmation.MaxLength = 64;
            this.PasswordConfirmation.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordConfirmation.Name = "PasswordConfirmation";
            this.PasswordConfirmation.PasswordChar = '♟';
            this.PasswordConfirmation.SelectedText = "";
            this.PasswordConfirmation.SelectionLength = 0;
            this.PasswordConfirmation.SelectionStart = 0;
            this.PasswordConfirmation.Size = new System.Drawing.Size(202, 23);
            this.PasswordConfirmation.TabIndex = 28;
            this.PasswordConfirmation.TabStop = false;
            this.PasswordConfirmation.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(370, 351);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 27;
            this.materialLabel3.Text = "Password";
            // 
            // Password
            // 
            this.Password.Depth = 0;
            this.Password.Hint = "";
            this.Password.Location = new System.Drawing.Point(374, 373);
            this.Password.MaxLength = 64;
            this.Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '♟';
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(202, 23);
            this.Password.TabIndex = 26;
            this.Password.TabStop = false;
            this.Password.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(370, 289);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "E-mail";
            // 
            // Email
            // 
            this.Email.Depth = 0;
            this.Email.Hint = "";
            this.Email.Location = new System.Drawing.Point(374, 311);
            this.Email.MaxLength = 100;
            this.Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.Size = new System.Drawing.Size(202, 23);
            this.Email.TabIndex = 24;
            this.Email.TabStop = false;
            this.Email.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(370, 226);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(77, 19);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = "Username";
            // 
            // Username
            // 
            this.Username.Depth = 0;
            this.Username.Hint = "";
            this.Username.Location = new System.Drawing.Point(374, 248);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.SelectedText = "";
            this.Username.SelectionLength = 0;
            this.Username.SelectionStart = 0;
            this.Username.Size = new System.Drawing.Size(202, 23);
            this.Username.TabIndex = 22;
            this.Username.TabStop = false;
            this.Username.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 556);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.PasswordConfirmation);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton Register;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordConfirmation;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Email;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField Username;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}