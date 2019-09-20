namespace Pokloni.ba.WinUI.Kategorije
{
    partial class frmKategorijeDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.Sacuvaj = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Opis = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Naziv = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(249, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 56;
            this.button1.Text = "Obriši Proizvođača";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Sacuvaj
            // 
            this.Sacuvaj.AutoSize = true;
            this.Sacuvaj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sacuvaj.Depth = 0;
            this.Sacuvaj.Icon = null;
            this.Sacuvaj.Location = new System.Drawing.Point(486, 367);
            this.Sacuvaj.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sacuvaj.Name = "Sacuvaj";
            this.Sacuvaj.Primary = true;
            this.Sacuvaj.Size = new System.Drawing.Size(82, 36);
            this.Sacuvaj.TabIndex = 55;
            this.Sacuvaj.Text = "Sačuvaj";
            this.Sacuvaj.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(245, 167);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(39, 19);
            this.materialLabel6.TabIndex = 54;
            this.materialLabel6.Text = "Opis";
            // 
            // Opis
            // 
            this.Opis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Opis.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opis.Location = new System.Drawing.Point(249, 189);
            this.Opis.Multiline = true;
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(319, 142);
            this.Opis.TabIndex = 53;
            this.Opis.Text = "Upišite vaš željeni opis ovdje..";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(245, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 52;
            this.materialLabel1.Text = "Naziv";
            // 
            // Naziv
            // 
            this.Naziv.Depth = 0;
            this.Naziv.Hint = "";
            this.Naziv.Location = new System.Drawing.Point(249, 114);
            this.Naziv.MaxLength = 32767;
            this.Naziv.MouseState = MaterialSkin.MouseState.HOVER;
            this.Naziv.Name = "Naziv";
            this.Naziv.PasswordChar = '\0';
            this.Naziv.SelectedText = "";
            this.Naziv.SelectionLength = 0;
            this.Naziv.SelectionStart = 0;
            this.Naziv.Size = new System.Drawing.Size(205, 23);
            this.Naziv.TabIndex = 51;
            this.Naziv.TabStop = false;
            this.Naziv.UseSystemPasswordChar = false;
            // 
            // frmKategorijeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sacuvaj);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Naziv);
            this.Name = "frmKategorijeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji Kategorij";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialRaisedButton Sacuvaj;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox Opis;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Naziv;
    }
}