namespace Newton_Converter_Application
{
    partial class newtonConverter
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
            this.massPromptLabel = new System.Windows.Forms.Label();
            this.massTextbox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // massPromptLabel
            // 
            this.massPromptLabel.AutoSize = true;
            this.massPromptLabel.Location = new System.Drawing.Point(12, 22);
            this.massPromptLabel.Name = "massPromptLabel";
            this.massPromptLabel.Size = new System.Drawing.Size(101, 13);
            this.massPromptLabel.TabIndex = 4;
            this.massPromptLabel.Text = "Enter the mass (kg):";
            // 
            // massTextbox
            // 
            this.massTextbox.Location = new System.Drawing.Point(120, 19);
            this.massTextbox.Name = "massTextbox";
            this.massTextbox.Size = new System.Drawing.Size(100, 20);
            this.massTextbox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(77, 56);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(143, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert to mass (Newton)";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(77, 95);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(143, 23);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(77, 135);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newtonConverter
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(272, 180);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.massTextbox);
            this.Controls.Add(this.massPromptLabel);
            this.Name = "newtonConverter";
            this.Text = "Newton Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label massPromptLabel;
        private System.Windows.Forms.TextBox massTextbox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

