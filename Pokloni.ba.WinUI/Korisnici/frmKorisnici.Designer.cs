namespace Pokloni.ba.WinUI.Korisnici
{
    partial class frmKorisnici
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.KorisnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UlogaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisnici);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikID,
            this.KorisnikDetailsID,
            this.UlogaID,
            this.username,
            this.Email,
            this.Status});
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 16);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(769, 312);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvKorisnici_MouseDoubleClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(533, 69);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(78, 32);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 76);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(468, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // KorisnikID
            // 
            this.KorisnikID.DataPropertyName = "KorisnikID";
            this.KorisnikID.HeaderText = "KorisnikID";
            this.KorisnikID.Name = "KorisnikID";
            this.KorisnikID.ReadOnly = true;
            this.KorisnikID.Visible = false;
            // 
            // KorisnikDetailsID
            // 
            this.KorisnikDetailsID.DataPropertyName = "KorisnikDetailsID";
            this.KorisnikDetailsID.HeaderText = "KorisnikDetailsID";
            this.KorisnikDetailsID.Name = "KorisnikDetailsID";
            this.KorisnikDetailsID.ReadOnly = true;
            this.KorisnikDetailsID.Visible = false;
            // 
            // UlogaID
            // 
            this.UlogaID.DataPropertyName = "UlogaID";
            this.UlogaID.HeaderText = "UlogaID";
            this.UlogaID.Name = "UlogaID";
            this.UlogaID.ReadOnly = true;
            this.UlogaID.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "Username";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmKorisnici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UlogaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}