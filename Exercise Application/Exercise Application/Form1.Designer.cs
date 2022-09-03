namespace Exercise_Application
{
    partial class caloriesBurnedThroughExercise
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
            this.lblWeightPrompt = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblSIUnit = new System.Windows.Forms.Label();
            this.lbCaloriesBurned = new System.Windows.Forms.ListBox();
            this.gbExercise = new System.Windows.Forms.GroupBox();
            this.rbCycling = new System.Windows.Forms.RadioButton();
            this.rbRunning = new System.Windows.Forms.RadioButton();
            this.rbRowing = new System.Windows.Forms.RadioButton();
            this.btnShowCaloriesBurnt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeightPrompt
            // 
            this.lblWeightPrompt.AutoSize = true;
            this.lblWeightPrompt.Location = new System.Drawing.Point(13, 23);
            this.lblWeightPrompt.Name = "lblWeightPrompt";
            this.lblWeightPrompt.Size = new System.Drawing.Size(44, 13);
            this.lblWeightPrompt.TabIndex = 0;
            this.lblWeightPrompt.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(63, 20);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // lblSIUnit
            // 
            this.lblSIUnit.AutoSize = true;
            this.lblSIUnit.Location = new System.Drawing.Point(169, 23);
            this.lblSIUnit.Name = "lblSIUnit";
            this.lblSIUnit.Size = new System.Drawing.Size(19, 13);
            this.lblSIUnit.TabIndex = 2;
            this.lblSIUnit.Text = "kg";
            // 
            // lbCaloriesBurned
            // 
            this.lbCaloriesBurned.FormattingEnabled = true;
            this.lbCaloriesBurned.Location = new System.Drawing.Point(16, 62);
            this.lbCaloriesBurned.Name = "lbCaloriesBurned";
            this.lbCaloriesBurned.Size = new System.Drawing.Size(172, 199);
            this.lbCaloriesBurned.TabIndex = 3;
            // 
            // gbExercise
            // 
            this.gbExercise.Controls.Add(this.rbRowing);
            this.gbExercise.Controls.Add(this.rbRunning);
            this.gbExercise.Controls.Add(this.rbCycling);
            this.gbExercise.Location = new System.Drawing.Point(226, 23);
            this.gbExercise.Name = "gbExercise";
            this.gbExercise.Size = new System.Drawing.Size(123, 138);
            this.gbExercise.TabIndex = 4;
            this.gbExercise.TabStop = false;
            this.gbExercise.Text = "Exercise";
            // 
            // rbCycling
            // 
            this.rbCycling.AutoSize = true;
            this.rbCycling.Location = new System.Drawing.Point(20, 30);
            this.rbCycling.Name = "rbCycling";
            this.rbCycling.Size = new System.Drawing.Size(59, 17);
            this.rbCycling.TabIndex = 0;
            this.rbCycling.TabStop = true;
            this.rbCycling.Text = "Cycling";
            this.rbCycling.UseVisualStyleBackColor = true;
            // 
            // rbRunning
            // 
            this.rbRunning.AutoSize = true;
            this.rbRunning.Location = new System.Drawing.Point(20, 64);
            this.rbRunning.Name = "rbRunning";
            this.rbRunning.Size = new System.Drawing.Size(65, 17);
            this.rbRunning.TabIndex = 1;
            this.rbRunning.TabStop = true;
            this.rbRunning.Text = "Running";
            this.rbRunning.UseVisualStyleBackColor = true;
            // 
            // rbRowing
            // 
            this.rbRowing.AutoSize = true;
            this.rbRowing.Location = new System.Drawing.Point(20, 98);
            this.rbRowing.Name = "rbRowing";
            this.rbRowing.Size = new System.Drawing.Size(61, 17);
            this.rbRowing.TabIndex = 2;
            this.rbRowing.TabStop = true;
            this.rbRowing.Text = "Rowing";
            this.rbRowing.UseVisualStyleBackColor = true;
            // 
            // btnShowCaloriesBurnt
            // 
            this.btnShowCaloriesBurnt.Location = new System.Drawing.Point(226, 180);
            this.btnShowCaloriesBurnt.Name = "btnShowCaloriesBurnt";
            this.btnShowCaloriesBurnt.Size = new System.Drawing.Size(123, 23);
            this.btnShowCaloriesBurnt.TabIndex = 5;
            this.btnShowCaloriesBurnt.Text = "Show calories burnt";
            this.btnShowCaloriesBurnt.UseVisualStyleBackColor = true;
            this.btnShowCaloriesBurnt.Click += new System.EventHandler(this.btnCaloriesBurnt_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(226, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // caloriesBurnedThroughExercise
            // 
            this.AcceptButton = this.btnShowCaloriesBurnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(366, 290);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowCaloriesBurnt);
            this.Controls.Add(this.gbExercise);
            this.Controls.Add(this.lbCaloriesBurned);
            this.Controls.Add(this.lblSIUnit);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeightPrompt);
            this.Name = "caloriesBurnedThroughExercise";
            this.Text = "Calories burned through exercise";
            this.gbExercise.ResumeLayout(false);
            this.gbExercise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeightPrompt;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblSIUnit;
        private System.Windows.Forms.ListBox lbCaloriesBurned;
        private System.Windows.Forms.GroupBox gbExercise;
        private System.Windows.Forms.RadioButton rbRowing;
        private System.Windows.Forms.RadioButton rbRunning;
        private System.Windows.Forms.RadioButton rbCycling;
        private System.Windows.Forms.Button btnShowCaloriesBurnt;
        private System.Windows.Forms.Button btnExit;
    }
}

