namespace LOL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.Computer_tap = new System.Windows.Forms.RibbonTab();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.Backup_menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.Restpre_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.About_Menu_Item = new System.Windows.Forms.RibbonOrbMenuItem();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.Backup_menu_Item);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.Restpre_Menu_Item);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.About_Menu_Item);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1142, 49);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.Computer_tap);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.Text = "ribbon1";
            // 
            // Computer_tap
            // 
            this.Computer_tap.Name = "Computer_tap";
            this.Computer_tap.Text = "Computer";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "ribbonTab2";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "ribbonTab3";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "ribbonTab4";
            // 
            // Backup_menu_Item
            // 
            this.Backup_menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Backup_menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Backup_menu_Item.Image")));
            this.Backup_menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("Backup_menu_Item.LargeImage")));
            this.Backup_menu_Item.Name = "Backup_menu_Item";
            this.Backup_menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Backup_menu_Item.SmallImage")));
            this.Backup_menu_Item.Text = "BackUp";
            // 
            // Restpre_Menu_Item
            // 
            this.Restpre_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.Restpre_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("Restpre_Menu_Item.Image")));
            this.Restpre_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("Restpre_Menu_Item.LargeImage")));
            this.Restpre_Menu_Item.Name = "Restpre_Menu_Item";
            this.Restpre_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("Restpre_Menu_Item.SmallImage")));
            this.Restpre_Menu_Item.Text = "Restore";
            // 
            // About_Menu_Item
            // 
            this.About_Menu_Item.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.About_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.Image")));
            this.About_Menu_Item.LargeImage = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.LargeImage")));
            this.About_Menu_Item.Name = "About_Menu_Item";
            this.About_Menu_Item.SmallImage = ((System.Drawing.Image)(resources.GetObject("About_Menu_Item.SmallImage")));
            this.About_Menu_Item.Text = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 589);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab Computer_tap;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonOrbMenuItem Backup_menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem Restpre_Menu_Item;
        private System.Windows.Forms.RibbonOrbMenuItem About_Menu_Item;
    }
}

