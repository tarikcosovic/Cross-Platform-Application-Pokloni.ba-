namespace Pokloni.ba.WinUI.Narudzbe
{
    partial class frmNarudzbe
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
            this.btnPrikazi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPretraga = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NarudzbeCount = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterNarudzbi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.AutoSize = true;
            this.btnPrikazi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrikazi.Depth = 0;
            this.btnPrikazi.Icon = null;
            this.btnPrikazi.Location = new System.Drawing.Point(555, 100);
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
            this.txtPretraga.Location = new System.Drawing.Point(52, 113);
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
            // NarudzbeCount
            // 
            this.NarudzbeCount.AutoSize = true;
            this.NarudzbeCount.Depth = 0;
            this.NarudzbeCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.NarudzbeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NarudzbeCount.Location = new System.Drawing.Point(48, 451);
            this.NarudzbeCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.NarudzbeCount.Name = "NarudzbeCount";
            this.NarudzbeCount.Size = new System.Drawing.Size(134, 19);
            this.NarudzbeCount.TabIndex = 7;
            this.NarudzbeCount.Text = "Aktivnih Narudžbi: ";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CausesValidation = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(52, 167);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 266);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Narudžba";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Korisnik";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zaposlenik";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dostavljač";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Datum";
            this.columnHeader7.Width = 250;
            // 
            // filterNarudzbi
            // 
            this.filterNarudzbi.FormattingEnabled = true;
            this.filterNarudzbi.Items.AddRange(new object[] {
            "Aktivno",
            "Prihvaćeno",
            "Završeno",
            "Odbijeno",
            "Sve"});
            this.filterNarudzbi.Location = new System.Drawing.Point(682, 115);
            this.filterNarudzbi.Name = "filterNarudzbi";
            this.filterNarudzbi.Size = new System.Drawing.Size(121, 21);
            this.filterNarudzbi.TabIndex = 9;
            this.filterNarudzbi.SelectedIndexChanged += new System.EventHandler(this.FilterNarudzbi_SelectedIndexChanged);
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 595);
            this.Controls.Add(this.filterNarudzbi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.NarudzbeCount);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.FrmNarudzbe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnPrikazi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPretraga;
        private MaterialSkin.Controls.MaterialLabel NarudzbeCount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox filterNarudzbi;
    }
}