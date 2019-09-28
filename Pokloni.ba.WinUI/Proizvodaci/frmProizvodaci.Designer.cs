namespace Pokloni.ba.WinUI.Proizvodaci
{
    partial class frmProizvodaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProizvodaci));
            this.listaProizvodaca = new MaterialSkin.Controls.MaterialListView();
            this.dsvNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dsvOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikazi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPretraga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loadingBar = new System.Windows.Forms.PictureBox();
            Dummy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.loadingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Dummy
            // 
            Dummy.Text = "";
            Dummy.Width = 0;
            // 
            // listaProizvodaca
            // 
            this.listaProizvodaca.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listaProizvodaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProizvodaca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Dummy,
            this.dsvNaziv,
            this.dsvOpis});
            this.listaProizvodaca.Depth = 0;
            this.listaProizvodaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listaProizvodaca.FullRowSelect = true;
            this.listaProizvodaca.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaProizvodaca.Location = new System.Drawing.Point(54, 143);
            this.listaProizvodaca.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaProizvodaca.MouseState = MaterialSkin.MouseState.OUT;
            this.listaProizvodaca.Name = "listaProizvodaca";
            this.listaProizvodaca.OwnerDraw = true;
            this.listaProizvodaca.Size = new System.Drawing.Size(454, 295);
            this.listaProizvodaca.TabIndex = 6;
            this.listaProizvodaca.UseCompatibleStateImageBehavior = false;
            this.listaProizvodaca.View = System.Windows.Forms.View.Details;
            this.listaProizvodaca.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListaProizvodaca_MouseDoubleClick);
            // 
            // dsvNaziv
            // 
            this.dsvNaziv.Text = "Naziv";
            this.dsvNaziv.Width = 146;
            // 
            // dsvOpis
            // 
            this.dsvOpis.Text = "Opis";
            this.dsvOpis.Width = 303;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrikazi.Depth = 0;
            this.btnPrikazi.Icon = null;
            this.btnPrikazi.Location = new System.Drawing.Point(540, 83);
            this.btnPrikazi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Primary = true;
            this.btnPrikazi.Size = new System.Drawing.Size(84, 36);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Pretraži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Depth = 0;
            this.txtPretraga.Hint = "";
            this.txtPretraga.Location = new System.Drawing.Point(54, 96);
            this.txtPretraga.MaxLength = 32767;
            this.txtPretraga.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.PasswordChar = '\0';
            this.txtPretraga.SelectedText = "";
            this.txtPretraga.SelectionLength = 0;
            this.txtPretraga.SelectionStart = 0;
            this.txtPretraga.Size = new System.Drawing.Size(454, 23);
            this.txtPretraga.TabIndex = 4;
            this.txtPretraga.TabStop = false;
            this.txtPretraga.UseSystemPasswordChar = false;
            // 
            // loadingBar
            // 
            this.loadingBar.Image = ((System.Drawing.Image)(resources.GetObject("loadingBar.Image")));
            this.loadingBar.Location = new System.Drawing.Point(239, 248);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(48, 46);
            this.loadingBar.TabIndex = 7;
            this.loadingBar.TabStop = false;
            // 
            // frmProizvodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.listaProizvodaca);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmProizvodaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodači";
            this.Load += new System.EventHandler(this.FrmProizvodaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listaProizvodaca;
        private System.Windows.Forms.ColumnHeader dsvNaziv;
        private System.Windows.Forms.ColumnHeader dsvOpis;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrikazi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraga;
        private System.Windows.Forms.PictureBox loadingBar;
    }
}