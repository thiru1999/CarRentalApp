namespace CarRentalApp
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuManageuser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVehicleToolStripMenuItem,
            this.manageCarRentalsToolStripMenuItem,
            this.toolStripMenuManageuser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVehicleToolStripMenuItem
            // 
            this.manageVehicleToolStripMenuItem.Name = "manageVehicleToolStripMenuItem";
            this.manageVehicleToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manageVehicleToolStripMenuItem.Text = "Manage Vehicle";
            this.manageVehicleToolStripMenuItem.Click += new System.EventHandler(this.manageVehicleToolStripMenuItem_Click);
            // 
            // manageCarRentalsToolStripMenuItem
            // 
            this.manageCarRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarRentalToolStripMenuItem,
            this.viewArchivesToolStripMenuItem});
            this.manageCarRentalsToolStripMenuItem.Name = "manageCarRentalsToolStripMenuItem";
            this.manageCarRentalsToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.manageCarRentalsToolStripMenuItem.Text = "Manage Car Rentals";
            this.manageCarRentalsToolStripMenuItem.Click += new System.EventHandler(this.manageCarRentalsToolStripMenuItem_Click);
            // 
            // addCarRentalToolStripMenuItem
            // 
            this.addCarRentalToolStripMenuItem.Name = "addCarRentalToolStripMenuItem";
            this.addCarRentalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCarRentalToolStripMenuItem.Text = "Add Car Rental";
            this.addCarRentalToolStripMenuItem.Click += new System.EventHandler(this.addCarRentalToolStripMenuItem_Click);
            // 
            // viewArchivesToolStripMenuItem
            // 
            this.viewArchivesToolStripMenuItem.Name = "viewArchivesToolStripMenuItem";
            this.viewArchivesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewArchivesToolStripMenuItem.Text = "View Archives";
            // 
            // toolStripMenuManageuser
            // 
            this.toolStripMenuManageuser.Name = "toolStripMenuManageuser";
            this.toolStripMenuManageuser.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuManageuser.Text = "Manage User";
            this.toolStripMenuManageuser.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Car Rental Management System ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCarRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuManageuser;
    }
}