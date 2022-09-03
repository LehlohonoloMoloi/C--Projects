namespace KasiFoodJoint
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
            this.gbDrinks = new System.Windows.Forms.GroupBox();
            this.rbCreamsoda = new System.Windows.Forms.RadioButton();
            this.rbFantaOrange = new System.Windows.Forms.RadioButton();
            this.rbCoke = new System.Windows.Forms.RadioButton();
            this.gbSides = new System.Windows.Forms.GroupBox();
            this.cbWings = new System.Windows.Forms.CheckBox();
            this.cbFries = new System.Windows.Forms.CheckBox();
            this.cbSalad = new System.Windows.Forms.CheckBox();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.tbDrinks = new System.Windows.Forms.TextBox();
            this.lblBurgers = new System.Windows.Forms.Label();
            this.tbBurgers = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.lblTopOfTheForm = new System.Windows.Forms.Label();
            this.btnComputePrice = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblOutputAmountDue = new System.Windows.Forms.Label();
            this.gbOrderInformation = new System.Windows.Forms.GroupBox();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.lblTotalDrinksPrice = new System.Windows.Forms.Label();
            this.lblTotalSidesPrice = new System.Windows.Forms.Label();
            this.lblTotalBurgersPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityPanel = new System.Windows.Forms.Panel();
            this.lblTotalBurgers = new System.Windows.Forms.Label();
            this.lblTotalSides = new System.Windows.Forms.Label();
            this.lblTotalDrinks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextOrder = new System.Windows.Forms.Button();
            this.gbDrinks.SuspendLayout();
            this.gbSides.SuspendLayout();
            this.gbOrderInformation.SuspendLayout();
            this.pricePanel.SuspendLayout();
            this.quantityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDrinks
            // 
            this.gbDrinks.Controls.Add(this.rbCreamsoda);
            this.gbDrinks.Controls.Add(this.rbFantaOrange);
            this.gbDrinks.Controls.Add(this.rbCoke);
            this.gbDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrinks.Location = new System.Drawing.Point(12, 38);
            this.gbDrinks.Name = "gbDrinks";
            this.gbDrinks.Size = new System.Drawing.Size(200, 121);
            this.gbDrinks.TabIndex = 0;
            this.gbDrinks.TabStop = false;
            this.gbDrinks.Text = "Drinks";
            // 
            // rbCreamsoda
            // 
            this.rbCreamsoda.AutoSize = true;
            this.rbCreamsoda.Location = new System.Drawing.Point(7, 90);
            this.rbCreamsoda.Name = "rbCreamsoda";
            this.rbCreamsoda.Size = new System.Drawing.Size(87, 17);
            this.rbCreamsoda.TabIndex = 2;
            this.rbCreamsoda.Text = "Creamsoda";
            this.rbCreamsoda.UseVisualStyleBackColor = true;
            // 
            // rbFantaOrange
            // 
            this.rbFantaOrange.AutoSize = true;
            this.rbFantaOrange.Location = new System.Drawing.Point(7, 56);
            this.rbFantaOrange.Name = "rbFantaOrange";
            this.rbFantaOrange.Size = new System.Drawing.Size(102, 17);
            this.rbFantaOrange.TabIndex = 1;
            this.rbFantaOrange.Text = "Fanta Orange";
            this.rbFantaOrange.UseVisualStyleBackColor = true;
            // 
            // rbCoke
            // 
            this.rbCoke.AutoSize = true;
            this.rbCoke.Checked = true;
            this.rbCoke.Location = new System.Drawing.Point(7, 20);
            this.rbCoke.Name = "rbCoke";
            this.rbCoke.Size = new System.Drawing.Size(54, 17);
            this.rbCoke.TabIndex = 0;
            this.rbCoke.TabStop = true;
            this.rbCoke.Text = "Coke";
            this.rbCoke.UseVisualStyleBackColor = true;
            // 
            // gbSides
            // 
            this.gbSides.Controls.Add(this.cbWings);
            this.gbSides.Controls.Add(this.cbFries);
            this.gbSides.Controls.Add(this.cbSalad);
            this.gbSides.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSides.Location = new System.Drawing.Point(238, 38);
            this.gbSides.Name = "gbSides";
            this.gbSides.Size = new System.Drawing.Size(202, 121);
            this.gbSides.TabIndex = 1;
            this.gbSides.TabStop = false;
            this.gbSides.Text = "Sides";
            // 
            // cbWings
            // 
            this.cbWings.AutoSize = true;
            this.cbWings.Location = new System.Drawing.Point(24, 90);
            this.cbWings.Name = "cbWings";
            this.cbWings.Size = new System.Drawing.Size(61, 17);
            this.cbWings.TabIndex = 2;
            this.cbWings.Text = "Wings";
            this.cbWings.UseVisualStyleBackColor = true;
            // 
            // cbFries
            // 
            this.cbFries.AutoSize = true;
            this.cbFries.Location = new System.Drawing.Point(24, 56);
            this.cbFries.Name = "cbFries";
            this.cbFries.Size = new System.Drawing.Size(53, 17);
            this.cbFries.TabIndex = 1;
            this.cbFries.Text = "Fries";
            this.cbFries.UseVisualStyleBackColor = true;
            // 
            // cbSalad
            // 
            this.cbSalad.AutoSize = true;
            this.cbSalad.Location = new System.Drawing.Point(24, 20);
            this.cbSalad.Name = "cbSalad";
            this.cbSalad.Size = new System.Drawing.Size(58, 17);
            this.cbSalad.TabIndex = 0;
            this.cbSalad.Text = "Salad";
            this.cbSalad.UseVisualStyleBackColor = true;
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinks.Location = new System.Drawing.Point(9, 188);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(134, 13);
            this.lblDrinks.TabIndex = 9;
            this.lblDrinks.Text = "Enter the number of drinks:";
            // 
            // tbDrinks
            // 
            this.tbDrinks.Location = new System.Drawing.Point(149, 185);
            this.tbDrinks.Name = "tbDrinks";
            this.tbDrinks.Size = new System.Drawing.Size(100, 20);
            this.tbDrinks.TabIndex = 2;
            // 
            // lblBurgers
            // 
            this.lblBurgers.AutoSize = true;
            this.lblBurgers.Location = new System.Drawing.Point(9, 227);
            this.lblBurgers.Name = "lblBurgers";
            this.lblBurgers.Size = new System.Drawing.Size(141, 13);
            this.lblBurgers.TabIndex = 10;
            this.lblBurgers.Text = "Enter the number of burgers:";
            // 
            // tbBurgers
            // 
            this.tbBurgers.Location = new System.Drawing.Point(156, 224);
            this.tbBurgers.Name = "tbBurgers";
            this.tbBurgers.Size = new System.Drawing.Size(100, 20);
            this.tbBurgers.TabIndex = 3;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(9, 275);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(313, 13);
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "What day of the week is it today (first letter shoud be uppercase):";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(331, 272);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(100, 20);
            this.tbDay.TabIndex = 4;
            // 
            // lblTopOfTheForm
            // 
            this.lblTopOfTheForm.AutoSize = true;
            this.lblTopOfTheForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopOfTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopOfTheForm.Location = new System.Drawing.Point(114, 9);
            this.lblTopOfTheForm.Name = "lblTopOfTheForm";
            this.lblTopOfTheForm.Size = new System.Drawing.Size(271, 18);
            this.lblTopOfTheForm.TabIndex = 8;
            this.lblTopOfTheForm.Text = "Burger is R25, a drink R15, a side R20";
            // 
            // btnComputePrice
            // 
            this.btnComputePrice.Location = new System.Drawing.Point(19, 325);
            this.btnComputePrice.Name = "btnComputePrice";
            this.btnComputePrice.Size = new System.Drawing.Size(131, 40);
            this.btnComputePrice.TabIndex = 5;
            this.btnComputePrice.Text = "Compute Price";
            this.btnComputePrice.UseVisualStyleBackColor = true;
            this.btnComputePrice.Click += new System.EventHandler(this.btnComputePrice_Click);
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(298, 326);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(142, 39);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(15, 19);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(169, 134);
            this.lbOrder.TabIndex = 11;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(3, 80);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(78, 13);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.Text = "Amount due:";
            // 
            // lblOutputAmountDue
            // 
            this.lblOutputAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputAmountDue.Location = new System.Drawing.Point(110, 79);
            this.lblOutputAmountDue.Name = "lblOutputAmountDue";
            this.lblOutputAmountDue.Size = new System.Drawing.Size(54, 15);
            this.lblOutputAmountDue.TabIndex = 13;
            this.lblOutputAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOrderInformation
            // 
            this.gbOrderInformation.Controls.Add(this.pricePanel);
            this.gbOrderInformation.Controls.Add(this.quantityPanel);
            this.gbOrderInformation.Controls.Add(this.lbOrder);
            this.gbOrderInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderInformation.Location = new System.Drawing.Point(493, 12);
            this.gbOrderInformation.Name = "gbOrderInformation";
            this.gbOrderInformation.Size = new System.Drawing.Size(211, 370);
            this.gbOrderInformation.TabIndex = 8;
            this.gbOrderInformation.TabStop = false;
            this.gbOrderInformation.Text = "Order Information";
            // 
            // pricePanel
            // 
            this.pricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePanel.Controls.Add(this.lblTotalDrinksPrice);
            this.pricePanel.Controls.Add(this.lblTotalSidesPrice);
            this.pricePanel.Controls.Add(this.lblTotalBurgersPrice);
            this.pricePanel.Controls.Add(this.label6);
            this.pricePanel.Controls.Add(this.label5);
            this.pricePanel.Controls.Add(this.label4);
            this.pricePanel.Controls.Add(this.lblAmountDue);
            this.pricePanel.Controls.Add(this.lblOutputAmountDue);
            this.pricePanel.Location = new System.Drawing.Point(15, 260);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(169, 100);
            this.pricePanel.TabIndex = 15;
            // 
            // lblTotalDrinksPrice
            // 
            this.lblTotalDrinksPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDrinksPrice.Location = new System.Drawing.Point(110, 6);
            this.lblTotalDrinksPrice.Name = "lblTotalDrinksPrice";
            this.lblTotalDrinksPrice.Size = new System.Drawing.Size(54, 15);
            this.lblTotalDrinksPrice.TabIndex = 19;
            this.lblTotalDrinksPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSidesPrice
            // 
            this.lblTotalSidesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSidesPrice.Location = new System.Drawing.Point(110, 30);
            this.lblTotalSidesPrice.Name = "lblTotalSidesPrice";
            this.lblTotalSidesPrice.Size = new System.Drawing.Size(54, 15);
            this.lblTotalSidesPrice.TabIndex = 18;
            this.lblTotalSidesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBurgersPrice
            // 
            this.lblTotalBurgersPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBurgersPrice.Location = new System.Drawing.Point(110, 52);
            this.lblTotalBurgersPrice.Name = "lblTotalBurgersPrice";
            this.lblTotalBurgersPrice.Size = new System.Drawing.Size(54, 15);
            this.lblTotalBurgersPrice.TabIndex = 17;
            this.lblTotalBurgersPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Burgers price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sides price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Drinks price:";
            // 
            // quantityPanel
            // 
            this.quantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityPanel.Controls.Add(this.lblTotalBurgers);
            this.quantityPanel.Controls.Add(this.lblTotalSides);
            this.quantityPanel.Controls.Add(this.lblTotalDrinks);
            this.quantityPanel.Controls.Add(this.label3);
            this.quantityPanel.Controls.Add(this.label2);
            this.quantityPanel.Controls.Add(this.label1);
            this.quantityPanel.Location = new System.Drawing.Point(15, 159);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.Size = new System.Drawing.Size(169, 89);
            this.quantityPanel.TabIndex = 14;
            // 
            // lblTotalBurgers
            // 
            this.lblTotalBurgers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBurgers.Location = new System.Drawing.Point(110, 56);
            this.lblTotalBurgers.Name = "lblTotalBurgers";
            this.lblTotalBurgers.Size = new System.Drawing.Size(54, 16);
            this.lblTotalBurgers.TabIndex = 19;
            this.lblTotalBurgers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSides
            // 
            this.lblTotalSides.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSides.Location = new System.Drawing.Point(110, 35);
            this.lblTotalSides.Name = "lblTotalSides";
            this.lblTotalSides.Size = new System.Drawing.Size(54, 16);
            this.lblTotalSides.TabIndex = 18;
            this.lblTotalSides.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDrinks
            // 
            this.lblTotalDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDrinks.Location = new System.Drawing.Point(110, 13);
            this.lblTotalDrinks.Name = "lblTotalDrinks";
            this.lblTotalDrinks.Size = new System.Drawing.Size(54, 16);
            this.lblTotalDrinks.TabIndex = 17;
            this.lblTotalDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of burgers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number of sides:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of drinks: ";
            // 
            // btnNextOrder
            // 
            this.btnNextOrder.Location = new System.Drawing.Point(156, 326);
            this.btnNextOrder.Name = "btnNextOrder";
            this.btnNextOrder.Size = new System.Drawing.Size(127, 39);
            this.btnNextOrder.TabIndex = 6;
            this.btnNextOrder.Text = "&Next Order";
            this.btnNextOrder.UseVisualStyleBackColor = true;
            this.btnNextOrder.Click += new System.EventHandler(this.btnNextOrder_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnComputePrice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(725, 393);
            this.Controls.Add(this.btnNextOrder);
            this.Controls.Add(this.gbOrderInformation);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnComputePrice);
            this.Controls.Add(this.lblTopOfTheForm);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.tbBurgers);
            this.Controls.Add(this.lblBurgers);
            this.Controls.Add(this.tbDrinks);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.gbSides);
            this.Controls.Add(this.gbDrinks);
            this.Name = "Form1";
            this.Text = "Junk City";
            this.gbDrinks.ResumeLayout(false);
            this.gbDrinks.PerformLayout();
            this.gbSides.ResumeLayout(false);
            this.gbSides.PerformLayout();
            this.gbOrderInformation.ResumeLayout(false);
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDrinks;
        private System.Windows.Forms.RadioButton rbCreamsoda;
        private System.Windows.Forms.RadioButton rbFantaOrange;
        private System.Windows.Forms.RadioButton rbCoke;
        private System.Windows.Forms.GroupBox gbSides;
        private System.Windows.Forms.CheckBox cbWings;
        private System.Windows.Forms.CheckBox cbFries;
        private System.Windows.Forms.CheckBox cbSalad;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.TextBox tbDrinks;
        private System.Windows.Forms.Label lblBurgers;
        private System.Windows.Forms.TextBox tbBurgers;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label lblTopOfTheForm;
        private System.Windows.Forms.Button btnComputePrice;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblOutputAmountDue;
        private System.Windows.Forms.GroupBox gbOrderInformation;
        private System.Windows.Forms.Panel pricePanel;
        private System.Windows.Forms.Panel quantityPanel;
        private System.Windows.Forms.Label lblTotalBurgers;
        private System.Windows.Forms.Label lblTotalSides;
        private System.Windows.Forms.Label lblTotalDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDrinksPrice;
        private System.Windows.Forms.Label lblTotalSidesPrice;
        private System.Windows.Forms.Label lblTotalBurgersPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNextOrder;
    }
}

