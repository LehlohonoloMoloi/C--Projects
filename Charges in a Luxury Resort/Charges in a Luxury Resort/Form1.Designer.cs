namespace Charges_in_a_Luxury_Resort
{
    partial class Form1
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
            this.lblDaysDescription = new System.Windows.Forms.Label();
            this.lblRestaurantDescription = new System.Windows.Forms.Label();
            this.lblSpaAndHealthDescription = new System.Windows.Forms.Label();
            this.lblCarRentalDescription = new System.Windows.Forms.Label();
            this.lblMedicationDescription = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.txtSpa = new System.Windows.Forms.TextBox();
            this.txtRental = new System.Windows.Forms.TextBox();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDaysDescription
            // 
            this.lblDaysDescription.AutoSize = true;
            this.lblDaysDescription.Location = new System.Drawing.Point(16, 18);
            this.lblDaysDescription.Name = "lblDaysDescription";
            this.lblDaysDescription.Size = new System.Drawing.Size(99, 13);
            this.lblDaysDescription.TabIndex = 0;
            this.lblDaysDescription.Text = "No. of Days Stayed";
            // 
            // lblRestaurantDescription
            // 
            this.lblRestaurantDescription.AutoSize = true;
            this.lblRestaurantDescription.Location = new System.Drawing.Point(16, 53);
            this.lblRestaurantDescription.Name = "lblRestaurantDescription";
            this.lblRestaurantDescription.Size = new System.Drawing.Size(170, 13);
            this.lblRestaurantDescription.TabIndex = 1;
            this.lblRestaurantDescription.Text = "Restaurant Charges including VAT";
            // 
            // lblSpaAndHealthDescription
            // 
            this.lblSpaAndHealthDescription.AutoSize = true;
            this.lblSpaAndHealthDescription.Location = new System.Drawing.Point(16, 91);
            this.lblSpaAndHealthDescription.Name = "lblSpaAndHealthDescription";
            this.lblSpaAndHealthDescription.Size = new System.Drawing.Size(174, 13);
            this.lblSpaAndHealthDescription.TabIndex = 2;
            this.lblSpaAndHealthDescription.Text = "Spa and Health Treatment Charges";
            // 
            // lblCarRentalDescription
            // 
            this.lblCarRentalDescription.AutoSize = true;
            this.lblCarRentalDescription.Location = new System.Drawing.Point(16, 131);
            this.lblCarRentalDescription.Name = "lblCarRentalDescription";
            this.lblCarRentalDescription.Size = new System.Drawing.Size(99, 13);
            this.lblCarRentalDescription.TabIndex = 3;
            this.lblCarRentalDescription.Text = "Car Rental Charges";
            // 
            // lblMedicationDescription
            // 
            this.lblMedicationDescription.AutoSize = true;
            this.lblMedicationDescription.Location = new System.Drawing.Point(16, 171);
            this.lblMedicationDescription.Name = "lblMedicationDescription";
            this.lblMedicationDescription.Size = new System.Drawing.Size(163, 13);
            this.lblMedicationDescription.TabIndex = 4;
            this.lblMedicationDescription.Text = "Medication and Rehabilitation Bill";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(228, 15);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 5;
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Location = new System.Drawing.Point(228, 50);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.Size = new System.Drawing.Size(100, 20);
            this.txtRestaurant.TabIndex = 6;
            // 
            // txtSpa
            // 
            this.txtSpa.Location = new System.Drawing.Point(228, 88);
            this.txtSpa.Name = "txtSpa";
            this.txtSpa.Size = new System.Drawing.Size(100, 20);
            this.txtSpa.TabIndex = 7;
            // 
            // txtRental
            // 
            this.txtRental.Location = new System.Drawing.Point(228, 128);
            this.txtRental.Name = "txtRental";
            this.txtRental.Size = new System.Drawing.Size(100, 20);
            this.txtRental.TabIndex = 8;
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(228, 168);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(100, 20);
            this.txtMedication.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(19, 212);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Total Charges";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(228, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(19, 261);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(308, 95);
            this.lbOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(362, 383);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtRental);
            this.Controls.Add(this.txtSpa);
            this.Controls.Add(this.txtRestaurant);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblMedicationDescription);
            this.Controls.Add(this.lblCarRentalDescription);
            this.Controls.Add(this.lblSpaAndHealthDescription);
            this.Controls.Add(this.lblRestaurantDescription);
            this.Controls.Add(this.lblDaysDescription);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resort charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysDescription;
        private System.Windows.Forms.Label lblRestaurantDescription;
        private System.Windows.Forms.Label lblSpaAndHealthDescription;
        private System.Windows.Forms.Label lblCarRentalDescription;
        private System.Windows.Forms.Label lblMedicationDescription;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtRestaurant;
        private System.Windows.Forms.TextBox txtSpa;
        private System.Windows.Forms.TextBox txtRental;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbOutput;
    }
}

