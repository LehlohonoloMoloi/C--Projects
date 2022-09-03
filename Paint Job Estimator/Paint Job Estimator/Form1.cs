//Lehlohonlo Moloi - 30586453

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class paintJobEstimator : Form
    {
        const double LABOUR_CHARGE_PER_HOUR = 20.00;
        const double WALL_SPACE = 115.00;
        const int STANDARD_HOURS = 8;

        private double gallons;
        private double labourHours;
        private double paintCost;
        private double labourCharge;
        private double userWallspace;
        private double totalCost;
        private double wallSpace;
        private double paintPerGallon;


        public paintJobEstimator()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get input from the user
                wallSpace = double.Parse(wallspaceTextbox.Text);
                paintPerGallon = double.Parse(gallonPriceTextbox.Text);

                //calculate gallons of paint needed
                gallons = Math.Round((wallSpace / WALL_SPACE), 4);

                //calculate labour hours
                labourHours = Math.Round(((wallSpace * STANDARD_HOURS) / WALL_SPACE), 4);

                //calculate cost of paint
                paintCost = Math.Round((gallons * paintPerGallon), 2);

                //calculate labour charge
                labourCharge = Math.Round((labourHours * LABOUR_CHARGE_PER_HOUR), 2);

                //calculate total cost of the paint job
                totalCost = labourCharge + paintCost;

                //return results to ouput labels

                gallonsOutputLabel.Text = "The number of gallons of paint required: " + gallons.ToString("n2");
                labourHourOuputLabel.Text = "The hours of labour required: " + labourHours.ToString("n2");
                paintCostOuputLabel.Text = "The cost of the paint: " + paintCost.ToString("c2");
                labourChargeOutputLabel.Text = "The labour charges: " + labourCharge.ToString("c2");
                totalOutputLabel.Text = "The total cost of the paint job: " + totalCost.ToString("c2");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gallonPriceTextbox.Text = "";
            wallspaceTextbox.Text = "";
            gallonsOutputLabel.Text = "";
            labourHourOuputLabel.Text = "";
            paintCostOuputLabel.Text = "";
            labourChargeOutputLabel.Text = "";
            totalOutputLabel.Text = "";

            //reset focus to wallspace textbox
            wallspaceTextbox.Focus();
        }

    }
}
