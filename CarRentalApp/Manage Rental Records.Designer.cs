namespace CarRentalApp
{
    partial class Manage_Rental_Records
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
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.gvManageRentalRecords = new System.Windows.Forms.DataGridView();
            this.lblManageRentalRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageRentalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(552, 341);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(187, 56);
            this.btnDeleteRecord.TabIndex = 10;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(552, 222);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(187, 56);
            this.btnEditRecord.TabIndex = 9;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Location = new System.Drawing.Point(552, 97);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(187, 56);
            this.btnAddNewRecord.TabIndex = 8;
            this.btnAddNewRecord.Text = "Add New Record";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // gvManageRentalRecords
            // 
            this.gvManageRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManageRentalRecords.Location = new System.Drawing.Point(61, 97);
            this.gvManageRentalRecords.Name = "gvManageRentalRecords";
            this.gvManageRentalRecords.Size = new System.Drawing.Size(400, 332);
            this.gvManageRentalRecords.TabIndex = 7;
            // 
            // lblManageRentalRecords
            // 
            this.lblManageRentalRecords.AutoSize = true;
            this.lblManageRentalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRentalRecords.Location = new System.Drawing.Point(246, 21);
            this.lblManageRentalRecords.Name = "lblManageRentalRecords";
            this.lblManageRentalRecords.Size = new System.Drawing.Size(410, 39);
            this.lblManageRentalRecords.TabIndex = 6;
            this.lblManageRentalRecords.Text = "Manage Rental Records";
            this.lblManageRentalRecords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Manage_Rental_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnAddNewRecord);
            this.Controls.Add(this.gvManageRentalRecords);
            this.Controls.Add(this.lblManageRentalRecords);
            this.Name = "Manage_Rental_Records";
            this.Text = "Manage_Rental_Records";
            this.Load += new System.EventHandler(this.Manage_Rental_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageRentalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.DataGridView gvManageRentalRecords;
        private System.Windows.Forms.Label lblManageRentalRecords;
    }
}