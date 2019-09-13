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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PasswordConfirmation = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Uloga = new System.Windows.Forms.Label();
            this.UlogaBox = new System.Windows.Forms.ComboBox();
            this.Spremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(99, 65);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(67, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(99, 118);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(44, 16);
            this.Email.TabIndex = 3;
            this.Email.Text = "E-mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(99, 175);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(64, 16);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 20);
            this.textBox3.TabIndex = 4;
            // 
            // PasswordConfirmation
            // 
            this.PasswordConfirmation.AutoSize = true;
            this.PasswordConfirmation.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordConfirmation.Location = new System.Drawing.Point(99, 232);
            this.PasswordConfirmation.Name = "PasswordConfirmation";
            this.PasswordConfirmation.Size = new System.Drawing.Size(115, 16);
            this.PasswordConfirmation.TabIndex = 7;
            this.PasswordConfirmation.Text = "Confirm password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 20);
            this.textBox4.TabIndex = 6;
            // 
            // Uloga
            // 
            this.Uloga.AutoSize = true;
            this.Uloga.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uloga.Location = new System.Drawing.Point(99, 286);
            this.Uloga.Name = "Uloga";
            this.Uloga.Size = new System.Drawing.Size(43, 16);
            this.Uloga.TabIndex = 9;
            this.Uloga.Text = "Uloga";
            // 
            // UlogaBox
            // 
            this.UlogaBox.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlogaBox.FormattingEnabled = true;
            this.UlogaBox.Items.AddRange(new object[] {
            "Admin",
            "Korisnik",
            "Radnik Narudžbi",
            "Dostavljać"});
            this.UlogaBox.Location = new System.Drawing.Point(100, 305);
            this.UlogaBox.Name = "UlogaBox";
            this.UlogaBox.Size = new System.Drawing.Size(104, 27);
            this.UlogaBox.TabIndex = 10;
            // 
            // Spremi
            // 
            this.Spremi.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spremi.Location = new System.Drawing.Point(213, 359);
            this.Spremi.Name = "Spremi";
            this.Spremi.Size = new System.Drawing.Size(89, 34);
            this.Spremi.TabIndex = 11;
            this.Spremi.Text = "Spremi";
            this.Spremi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unos novog korisnika";
            // 
            // frmKorisniciInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spremi);
            this.Controls.Add(this.UlogaBox);
            this.Controls.Add(this.Uloga);
            this.Controls.Add(this.PasswordConfirmation);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox1);
            this.Name = "frmKorisniciInsert";
            this.Text = "frmKorisniciInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label PasswordConfirmation;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Uloga;
        private System.Windows.Forms.ComboBox UlogaBox;
        private System.Windows.Forms.Button Spremi;
        private System.Windows.Forms.Label label1;
    }
}