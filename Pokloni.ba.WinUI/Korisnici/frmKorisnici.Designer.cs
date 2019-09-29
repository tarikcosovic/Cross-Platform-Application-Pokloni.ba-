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
            System.Windows.Forms.ColumnHeader Dummy;
            this.txtPretraga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPrikazi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listaKorisnika = new MaterialSkin.Controls.MaterialListView();
            this.test1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.test2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.test3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Dummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Dummy
            // 
            Dummy.Text = "";
            Dummy.Width = 0;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Depth = 0;
            this.txtPretraga.Hint = "";
            this.txtPretraga.Location = new System.Drawing.Point(91, 101);
            this.txtPretraga.MaxLength = 32767;
            this.txtPretraga.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.PasswordChar = '\0';
            this.txtPretraga.SelectedText = "";
            this.txtPretraga.SelectionLength = 0;
            this.txtPretraga.SelectionStart = 0;
            this.txtPretraga.Size = new System.Drawing.Size(454, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TabStop = false;
            this.txtPretraga.UseSystemPasswordChar = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrikazi.Depth = 0;
            this.btnPrikazi.Icon = null;
            this.btnPrikazi.Location = new System.Drawing.Point(568, 88);
            this.btnPrikazi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Primary = true;
            this.btnPrikazi.Size = new System.Drawing.Size(84, 36);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Pretraži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // listaKorisnika
            // 
            this.listaKorisnika.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listaKorisnika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaKorisnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Dummy,
            this.test1,
            this.test2,
            this.test3,
            this.columnHeader1});
            this.listaKorisnika.Depth = 0;
            this.listaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listaKorisnika.FullRowSelect = true;
            this.listaKorisnika.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaKorisnika.Location = new System.Drawing.Point(91, 148);
            this.listaKorisnika.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaKorisnika.MouseState = MaterialSkin.MouseState.OUT;
            this.listaKorisnika.Name = "listaKorisnika";
            this.listaKorisnika.OwnerDraw = true;
            this.listaKorisnika.Size = new System.Drawing.Size(561, 263);
            this.listaKorisnika.TabIndex = 3;
            this.listaKorisnika.UseCompatibleStateImageBehavior = false;
            this.listaKorisnika.View = System.Windows.Forms.View.Details;
            this.listaKorisnika.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaKorisnika_MouseDoubleClick);
            // 
            // test1
            // 
            this.test1.Text = "Username";
            this.test1.Width = 120;
            // 
            // test2
            // 
            this.test2.Text = "E-mail";
            this.test2.Width = 150;
            // 
            // test3
            // 
            this.test3.Text = "Status";
            this.test3.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Uloga";
            this.columnHeader1.Width = 100;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(721, 413);
            this.ControlBox = false;
            this.Controls.Add(this.listaKorisnika);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKorisnici";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnički Panel";
            this.Load += new System.EventHandler(this.FrmKorisnici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnPrikazi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraga;
        private MaterialSkin.Controls.MaterialListView listaKorisnika;
        private System.Windows.Forms.ColumnHeader test1;
        private System.Windows.Forms.ColumnHeader test2;
        private System.Windows.Forms.ColumnHeader test3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}