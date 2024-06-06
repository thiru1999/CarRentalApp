namespace CarRentalApp
{
    partial class AddCarRentalRecords
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblTypeOfCar = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.pickerIn = new System.Windows.Forms.DateTimePicker();
            this.pickerOut = new System.Windows.Forms.DateTimePicker();
            this.cmbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(232, 31);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(266, 39);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Add Car Rental";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(63, 111);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(142, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name ";
            // 
            // lblTypeOfCar
            // 
            this.lblTypeOfCar.AutoSize = true;
            this.lblTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfCar.Location = new System.Drawing.Point(63, 273);
            this.lblTypeOfCar.Name = "lblTypeOfCar";
            this.lblTypeOfCar.Size = new System.Drawing.Size(104, 20);
            this.lblTypeOfCar.TabIndex = 2;
            this.lblTypeOfCar.Text = "Type Of Car";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(485, 184);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(128, 20);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "Date Returned";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(63, 184);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(112, 20);
            this.lblIn.TabIndex = 4;
            this.lblIn.Text = "Date Rented";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(485, 111);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 20);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Cost";
            // 
            // pickerIn
            // 
            this.pickerIn.Location = new System.Drawing.Point(67, 223);
            this.pickerIn.Name = "pickerIn";
            this.pickerIn.Size = new System.Drawing.Size(200, 20);
            this.pickerIn.TabIndex = 6;
            // 
            // pickerOut
            // 
            this.pickerOut.Location = new System.Drawing.Point(489, 222);
            this.pickerOut.Name = "pickerOut";
            this.pickerOut.Size = new System.Drawing.Size(200, 20);
            this.pickerOut.TabIndex = 7;
            // 
            // cmbTypeOfCar
            // 
            this.cmbTypeOfCar.FormattingEnabled = true;
            this.cmbTypeOfCar.Location = new System.Drawing.Point(67, 313);
            this.cmbTypeOfCar.Name = "cmbTypeOfCar";
            this.cmbTypeOfCar.Size = new System.Drawing.Size(200, 21);
            this.cmbTypeOfCar.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(489, 273);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(230, 84);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(67, 145);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(489, 145);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 11;
            // 
            // AddCarRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbTypeOfCar);
            this.Controls.Add(this.pickerOut);
            this.Controls.Add(this.pickerIn);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblTypeOfCar);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblHeading);
            this.Name = "AddCarRentalRecords";
            this.Text = "Add Car Rental ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblTypeOfCar;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DateTimePicker pickerIn;
        private System.Windows.Forms.DateTimePicker pickerOut;
        private System.Windows.Forms.ComboBox cmbTypeOfCar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCost;
    }
}

