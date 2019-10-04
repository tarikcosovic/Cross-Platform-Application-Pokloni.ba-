﻿namespace Pokloni.ba.WinUI.Narudzbe
{
    partial class frmNarudzbeDetails
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
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnKontakt = new System.Windows.Forms.Button();
            this.listaProizvoda = new MaterialSkin.Controls.MaterialListView();
            this.DUMMY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UkupnaCijena = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.Brown;
            this.btnOdbij.FlatAppearance.BorderSize = 0;
            this.btnOdbij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdbij.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdbij.Location = new System.Drawing.Point(47, 400);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(109, 36);
            this.btnOdbij.TabIndex = 37;
            this.btnOdbij.Text = "Odbij ";
            this.btnOdbij.UseVisualStyleBackColor = false;
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrihvati.FlatAppearance.BorderSize = 0;
            this.btnPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihvati.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrihvati.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrihvati.Location = new System.Drawing.Point(816, 400);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(109, 36);
            this.btnPrihvati.TabIndex = 38;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            // 
            // btnKontakt
            // 
            this.btnKontakt.BackColor = System.Drawing.Color.Teal;
            this.btnKontakt.FlatAppearance.BorderSize = 0;
            this.btnKontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontakt.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontakt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKontakt.Location = new System.Drawing.Point(194, 400);
            this.btnKontakt.Name = "btnKontakt";
            this.btnKontakt.Size = new System.Drawing.Size(136, 36);
            this.btnKontakt.TabIndex = 39;
            this.btnKontakt.Text = "Kontaktiraj Kupca";
            this.btnKontakt.UseVisualStyleBackColor = false;
            // 
            // listaProizvoda
            // 
            this.listaProizvoda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProizvoda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DUMMY,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.listaProizvoda.Depth = 0;
            this.listaProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listaProizvoda.FullRowSelect = true;
            this.listaProizvoda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaProizvoda.Location = new System.Drawing.Point(47, 118);
            this.listaProizvoda.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listaProizvoda.MouseState = MaterialSkin.MouseState.OUT;
            this.listaProizvoda.Name = "listaProizvoda";
            this.listaProizvoda.OwnerDraw = true;
            this.listaProizvoda.Size = new System.Drawing.Size(683, 217);
            this.listaProizvoda.TabIndex = 40;
            this.listaProizvoda.UseCompatibleStateImageBehavior = false;
            this.listaProizvoda.View = System.Windows.Forms.View.Details;
            // 
            // DUMMY
            // 
            this.DUMMY.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proizvod";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Količina";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Popust";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ukupno";
            this.columnHeader1.Width = 100;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(865, 285);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Ukupno";
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSize = true;
            this.UkupnaCijena.Depth = 0;
            this.UkupnaCijena.Font = new System.Drawing.Font("Roboto", 11F);
            this.UkupnaCijena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UkupnaCijena.Location = new System.Drawing.Point(864, 316);
            this.UkupnaCijena.MouseState = MaterialSkin.MouseState.HOVER;
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Size = new System.Drawing.Size(61, 19);
            this.UkupnaCijena.TabIndex = 42;
            this.UkupnaCijena.Text = "152.12$";
            // 
            // frmNarudzbeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 493);
            this.Controls.Add(this.UkupnaCijena);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listaProizvoda);
            this.Controls.Add(this.btnKontakt);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.btnOdbij);
            this.Name = "frmNarudzbeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudzba";
            this.Load += new System.EventHandler(this.FrmNarudzbeDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnKontakt;
        private MaterialSkin.Controls.MaterialListView listaProizvoda;
        private System.Windows.Forms.ColumnHeader DUMMY;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel UkupnaCijena;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}