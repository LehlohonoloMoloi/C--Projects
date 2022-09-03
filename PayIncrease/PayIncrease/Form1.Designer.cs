namespace PayIncrease
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
            this.lblCompensationPrompt = new System.Windows.Forms.Label();
            this.lbPayDetail = new System.Windows.Forms.ListBox();
            this.txtCompensation = new System.Windows.Forms.TextBox();
            this.btnShowPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompensationPrompt
            // 
            this.lblCompensationPrompt.AutoSize = true;
            this.lblCompensationPrompt.Location = new System.Drawing.Point(40, 29);
            this.lblCompensationPrompt.Name = "lblCompensationPrompt";
            this.lblCompensationPrompt.Size = new System.Drawing.Size(185, 13);
            this.lblCompensationPrompt.TabIndex = 0;
            this.lblCompensationPrompt.Text = "Enter a teacher\'s initial compensation:";
            // 
            // lbPayDetail
            // 
            this.lbPayDetail.FormattingEnabled = true;
            this.lbPayDetail.Location = new System.Drawing.Point(43, 74);
            this.lbPayDetail.Name = "lbPayDetail";
            this.lbPayDetail.Size = new System.Drawing.Size(182, 134);
            this.lbPayDetail.TabIndex = 1;
            // 
            // txtCompensation
            // 
            this.txtCompensation.Location = new System.Drawing.Point(231, 26);
            this.txtCompensation.Name = "txtCompensation";
            this.txtCompensation.Size = new System.Drawing.Size(100, 20);
            this.txtCompensation.TabIndex = 0;
            // 
            // btnShowPay
            // 
            this.btnShowPay.Location = new System.Drawing.Point(256, 74);
            this.btnShowPay.Name = "btnShowPay";
            this.btnShowPay.Size = new System.Drawing.Size(75, 36);
            this.btnShowPay.TabIndex = 1;
            this.btnShowPay.Text = "Show Pay";
            this.btnShowPay.UseVisualStyleBackColor = true;
            this.btnShowPay.Click += new System.EventHandler(this.btnShowPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(256, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShowPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(372, 237);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowPay);
            this.Controls.Add(this.txtCompensation);
            this.Controls.Add(this.lbPayDetail);
            this.Controls.Add(this.lblCompensationPrompt);
            this.Name = "Form1";
            this.Text = "Teacher\'s Pay Increase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompensationPrompt;
        private System.Windows.Forms.ListBox lbPayDetail;
        private System.Windows.Forms.TextBox txtCompensation;
        private System.Windows.Forms.Button btnShowPay;
        private System.Windows.Forms.Button btnExit;
    }
}

