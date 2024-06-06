namespace CarRentalApp
{
    partial class ManageVehicle
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.gvManageVehicle = new System.Windows.Forms.DataGridView();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(197, 22);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(278, 39);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Manage Vehicle";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvManageVehicle
            // 
            this.gvManageVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManageVehicle.Location = new System.Drawing.Point(12, 98);
            this.gvManageVehicle.Name = "gvManageVehicle";
            this.gvManageVehicle.Size = new System.Drawing.Size(400, 332);
            this.gvManageVehicle.TabIndex = 2;
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Location = new System.Drawing.Point(503, 98);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(187, 56);
            this.btnAddNewVehicle.TabIndex = 3;
            this.btnAddNewVehicle.Text = "Add New Vehicle";
            this.btnAddNewVehicle.UseVisualStyleBackColor = true;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Location = new System.Drawing.Point(503, 223);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(187, 56);
            this.btnEditVehicle.TabIndex = 4;
            this.btnEditVehicle.Text = "Edit Vehicle";
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(503, 342);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(187, 56);
            this.btnDeleteVehicle.TabIndex = 5;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // ManageVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnEditVehicle);
            this.Controls.Add(this.btnAddNewVehicle);
            this.Controls.Add(this.gvManageVehicle);
            this.Controls.Add(this.lblHeading);
            this.Name = "ManageVehicle";
            this.Text = "Manage Vehicle";
            this.Load += new System.EventHandler(this.ManageVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView gvManageVehicle;
        private System.Windows.Forms.Button btnAddNewVehicle;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
    }
}