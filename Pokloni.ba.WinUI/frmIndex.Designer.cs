namespace Pokloni.ba.WinUI
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.narudžbeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.korisniciToolStripMenuItem;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(135, 513);
            this.menuStrip.TabIndex = 0;
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.korisniciToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("korisniciToolStripMenuItem.Image")));
            this.korisniciToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(128, 98);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.PretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.noviKorisnikToolStripMenuItem.Text = "Novi Korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.NoviKorisnikToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productsToolStripMenuItem.Image")));
            this.productsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(128, 98);
            this.productsToolStripMenuItem.Text = "products";
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.narudžbeToolStripMenuItem.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narudžbeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.narudžbeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("narudžbeToolStripMenuItem.Image")));
            this.narudžbeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 30);
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(128, 98);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(96, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1,
            this.test2ToolStripMenuItem});
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            this.materialContextMenuStrip2.Size = new System.Drawing.Size(100, 48);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.testToolStripMenuItem1.Text = "Test";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.test2ToolStripMenuItem.Text = "test2";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1117, 513);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIndex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokloni.ba";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
    }
}



