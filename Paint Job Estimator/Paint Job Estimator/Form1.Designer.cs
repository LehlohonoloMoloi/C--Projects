namespace Paint_Job_Estimator
{
    partial class paintJobEstimator
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
            this.wallspacePromptLabel = new System.Windows.Forms.Label();
            this.gallonPricePromptLabel = new System.Windows.Forms.Label();
            this.wallspaceTextbox = new System.Windows.Forms.TextBox();
            this.gallonPriceTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.labourChargeOutputLabel = new System.Windows.Forms.Label();
            this.paintCostOuputLabel = new System.Windows.Forms.Label();
            this.labourHourOuputLabel = new System.Windows.Forms.Label();
            this.gallonsOutputLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallspacePromptLabel
            // 
            this.wallspacePromptLabel.AutoSize = true;
            this.wallspacePromptLabel.Location = new System.Drawing.Point(13, 13);
            this.wallspacePromptLabel.Name = "wallspacePromptLabel";
            this.wallspacePromptLabel.Size = new System.Drawing.Size(130, 13);
            this.wallspacePromptLabel.TabIndex = 0;
            this.wallspacePromptLabel.Text = "Square feet of wall space:";
            // 
            // gallonPricePromptLabel
            // 
            this.gallonPricePromptLabel.AutoSize = true;
            this.gallonPricePromptLabel.Location = new System.Drawing.Point(13, 45);
            this.gallonPricePromptLabel.Name = "gallonPricePromptLabel";
            this.gallonPricePromptLabel.Size = new System.Drawing.Size(121, 13);
            this.gallonPricePromptLabel.TabIndex = 1;
            this.gallonPricePromptLabel.Text = "Price of paint per gallon:";
            // 
            // wallspaceTextbox
            // 
            this.wallspaceTextbox.Location = new System.Drawing.Point(150, 13);
            this.wallspaceTextbox.Name = "wallspaceTextbox";
            this.wallspaceTextbox.Size = new System.Drawing.Size(100, 20);
            this.wallspaceTextbox.TabIndex = 2;
            this.wallspaceTextbox.UseSystemPasswordChar = true;
            // 
            // gallonPriceTextbox
            // 
            this.gallonPriceTextbox.Location = new System.Drawing.Point(150, 37);
            this.gallonPriceTextbox.Name = "gallonPriceTextbox";
            this.gallonPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.gallonPriceTextbox.TabIndex = 3;
            this.gallonPriceTextbox.UseSystemPasswordChar = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 85);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(175, 85);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 85);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totalOutputLabel);
            this.panel1.Controls.Add(this.labourChargeOutputLabel);
            this.panel1.Controls.Add(this.paintCostOuputLabel);
            this.panel1.Controls.Add(this.labourHourOuputLabel);
            this.panel1.Controls.Add(this.gallonsOutputLabel);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 125);
            this.panel1.TabIndex = 7;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.Location = new System.Drawing.Point(1, 62);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.totalOutputLabel.TabIndex = 4;
            // 
            // labourChargeOutputLabel
            // 
            this.labourChargeOutputLabel.AutoSize = true;
            this.labourChargeOutputLabel.Location = new System.Drawing.Point(1, 49);
            this.labourChargeOutputLabel.Name = "labourChargeOutputLabel";
            this.labourChargeOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.labourChargeOutputLabel.TabIndex = 3;
            // 
            // paintCostOuputLabel
            // 
            this.paintCostOuputLabel.AutoSize = true;
            this.paintCostOuputLabel.Location = new System.Drawing.Point(3, 36);
            this.paintCostOuputLabel.Name = "paintCostOuputLabel";
            this.paintCostOuputLabel.Size = new System.Drawing.Size(0, 13);
            this.paintCostOuputLabel.TabIndex = 2;
            // 
            // labourHourOuputLabel
            // 
            this.labourHourOuputLabel.AutoSize = true;
            this.labourHourOuputLabel.Location = new System.Drawing.Point(3, 23);
            this.labourHourOuputLabel.Name = "labourHourOuputLabel";
            this.labourHourOuputLabel.Size = new System.Drawing.Size(0, 13);
            this.labourHourOuputLabel.TabIndex = 1;
            // 
            // gallonsOutputLabel
            // 
            this.gallonsOutputLabel.AutoSize = true;
            this.gallonsOutputLabel.Location = new System.Drawing.Point(3, 10);
            this.gallonsOutputLabel.Name = "gallonsOutputLabel";
            this.gallonsOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.gallonsOutputLabel.TabIndex = 0;
            // 
            // paintJobEstimator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.gallonPriceTextbox);
            this.Controls.Add(this.wallspaceTextbox);
            this.Controls.Add(this.gallonPricePromptLabel);
            this.Controls.Add(this.wallspacePromptLabel);
            this.Name = "paintJobEstimator";
            this.Text = "Paint Job Estimator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallspacePromptLabel;
        private System.Windows.Forms.Label gallonPricePromptLabel;
        private System.Windows.Forms.TextBox wallspaceTextbox;
        private System.Windows.Forms.TextBox gallonPriceTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gallonsOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label labourChargeOutputLabel;
        private System.Windows.Forms.Label paintCostOuputLabel;
        private System.Windows.Forms.Label labourHourOuputLabel;
    }
}

