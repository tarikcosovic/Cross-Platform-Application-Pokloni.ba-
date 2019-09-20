namespace Pokloni.ba.WinUI.Kategorije
{
    partial class frmKategorije
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
            this.listaKorisnika = new MaterialSkin.Controls.MaterialListView();
            this.test1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.test2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikazi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPretraga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            Dummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaKorisnika
            // 
            this.listaKorisnika.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listaKorisnika.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaKorisnika.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Dummy,
            this.test1,
            this.test2});
            this.listaKorisnika.Depth = 0;
            this.listaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listaKorisnika.FullRowSelect = true;
            this.listaKorisnika.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaKorisnika.Location = new System.Drawing.Point(56, 143);
            this.listaKorisnika.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaKorisnika.MouseState = MaterialSkin.MouseState.OUT;
            this.listaKorisnika.Name = "listaKorisnika";
            this.listaKorisnika.OwnerDraw = true;
            this.listaKorisnika.Size = new System.Drawing.Size(454, 295);
            this.listaKorisnika.TabIndex = 9;
            this.listaKorisnika.UseCompatibleStateImageBehavior = false;
            this.listaKorisnika.View = System.Windows.Forms.View.Details;
            // 
            // Dummy
            // 
            Dummy.Text = "";
            Dummy.Width = 0;
            // 
            // test1
            // 
            this.test1.Text = "Naziv";
            this.test1.Width = 146;
            // 
            // test2
            // 
            this.test2.Text = "Opis";
            this.test2.Width = 303;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrikazi.Depth = 0;
            this.btnPrikazi.Icon = null;
            this.btnPrikazi.Location = new System.Drawing.Point(542, 83);
            this.btnPrikazi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Primary = true;
            this.btnPrikazi.Size = new System.Drawing.Size(84, 36);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Pretraži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Depth = 0;
            this.txtPretraga.Hint = "";
            this.txtPretraga.Location = new System.Drawing.Point(56, 96);
            this.txtPretraga.MaxLength = 32767;
            this.txtPretraga.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.PasswordChar = '\0';
            this.txtPretraga.SelectedText = "";
            this.txtPretraga.SelectionLength = 0;
            this.txtPretraga.SelectionStart = 0;
            this.txtPretraga.Size = new System.Drawing.Size(454, 23);
            this.txtPretraga.TabIndex = 7;
            this.txtPretraga.TabStop = false;
            this.txtPretraga.UseSystemPasswordChar = false;
            // 
            // frmKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.listaKorisnika);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmKategorije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listaKorisnika;
        private System.Windows.Forms.ColumnHeader test1;
        private System.Windows.Forms.ColumnHeader test2;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrikazi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraga;
    }
}