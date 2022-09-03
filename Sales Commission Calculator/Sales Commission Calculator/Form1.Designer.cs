namespace Sales_Commission_Calculator
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
            this.lblRevenueSaleDescription = new System.Windows.Forms.Label();
            this.lblCommissionPercentageDescriptio = new System.Windows.Forms.Label();
            this.lblEarnedCommissionDescription = new System.Windows.Forms.Label();
            this.txtRevenueSale = new System.Windows.Forms.TextBox();
            this.txtCommissionPercentage = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRevenueSaleDescription
            // 
            this.lblRevenueSaleDescription.AutoSize = true;
            this.lblRevenueSaleDescription.Location = new System.Drawing.Point(13, 25);
            this.lblRevenueSaleDescription.Name = "lblRevenueSaleDescription";
            this.lblRevenueSaleDescription.Size = new System.Drawing.Size(78, 13);
            this.lblRevenueSaleDescription.TabIndex = 0;
            this.lblRevenueSaleDescription.Text = "Revenue Sale:";
            // 
            // lblCommissionPercentageDescriptio
            // 
            this.lblCommissionPercentageDescriptio.AutoSize = true;
            this.lblCommissionPercentageDescriptio.Location = new System.Drawing.Point(13, 62);
            this.lblCommissionPercentageDescriptio.Name = "lblCommissionPercentageDescriptio";
            this.lblCommissionPercentageDescriptio.Size = new System.Drawing.Size(123, 13);
            this.lblCommissionPercentageDescriptio.TabIndex = 1;
            this.lblCommissionPercentageDescriptio.Text = "Commission Percentage:";
            // 
            // lblEarnedCommissionDescription
            // 
            this.lblEarnedCommissionDescription.AutoSize = true;
            this.lblEarnedCommissionDescription.Location = new System.Drawing.Point(16, 112);
            this.lblEarnedCommissionDescription.Name = "lblEarnedCommissionDescription";
            this.lblEarnedCommissionDescription.Size = new System.Drawing.Size(102, 13);
            this.lblEarnedCommissionDescription.TabIndex = 2;
            this.lblEarnedCommissionDescription.Text = "Earned Commission:";
            // 
            // txtRevenueSale
            // 
            this.txtRevenueSale.Location = new System.Drawing.Point(97, 22);
            this.txtRevenueSale.Name = "txtRevenueSale";
            this.txtRevenueSale.Size = new System.Drawing.Size(179, 20);
            this.txtRevenueSale.TabIndex = 3;
            // 
            // txtCommissionPercentage
            // 
            this.txtCommissionPercentage.Location = new System.Drawing.Point(142, 59);
            this.txtCommissionPercentage.Name = "txtCommissionPercentage";
            this.txtCommissionPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtCommissionPercentage.TabIndex = 4;
            // 
            // lblCommission
            // 
            this.lblCommission.Location = new System.Drawing.Point(124, 107);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(118, 23);
            this.lblCommission.TabIndex = 5;
            this.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 172);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 27);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(174, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(311, 224);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtCommissionPercentage);
            this.Controls.Add(this.txtRevenueSale);
            this.Controls.Add(this.lblEarnedCommissionDescription);
            this.Controls.Add(this.lblCommissionPercentageDescriptio);
            this.Controls.Add(this.lblRevenueSaleDescription);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Commission Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenueSaleDescription;
        private System.Windows.Forms.Label lblCommissionPercentageDescriptio;
        private System.Windows.Forms.Label lblEarnedCommissionDescription;
        private System.Windows.Forms.TextBox txtRevenueSale;
        private System.Windows.Forms.TextBox txtCommissionPercentage;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

