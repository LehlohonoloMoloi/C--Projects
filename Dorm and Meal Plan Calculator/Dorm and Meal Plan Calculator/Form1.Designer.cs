namespace Dorm_and_Meal_Plan_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDorm = new System.Windows.Forms.ListBox();
            this.lbMeal = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dormitory:";
            // 
            // lbDorm
            // 
            this.lbDorm.FormattingEnabled = true;
            this.lbDorm.Items.AddRange(new object[] {
            "Allan Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.lbDorm.Location = new System.Drawing.Point(31, 43);
            this.lbDorm.Name = "lbDorm";
            this.lbDorm.Size = new System.Drawing.Size(132, 121);
            this.lbDorm.TabIndex = 1;
            // 
            // lbMeal
            // 
            this.lbMeal.FormattingEnabled = true;
            this.lbMeal.Items.AddRange(new object[] {
            "7 meals per week",
            "14 meals per week",
            "Unlimited meals"});
            this.lbMeal.Location = new System.Drawing.Point(210, 43);
            this.lbMeal.Name = "lbMeal";
            this.lbMeal.Size = new System.Drawing.Size(132, 121);
            this.lbMeal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meal Plan:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(267, 188);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 251);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMeal);
            this.Controls.Add(this.lbDorm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program9_6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDorm;
        private System.Windows.Forms.ListBox lbMeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplay;
    }
}

