//SL Moloi, 30586453

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Application
{
    public partial class caloriesBurnedThroughExercise : Form
    {
        public caloriesBurnedThroughExercise()
        {
            InitializeComponent();
        }

        private void btnCaloriesBurnt_Click(object sender, EventArgs e)
        {
            const double CYCLING_CALORIES_BURNED_PM = 1.0;
            const double RUNNING_CALORIES_BURNED_PM = 1.2;
            const double ROWING_CALORIES_BURNED_PM = 1.5;

            double weight, caloriesBurned = 0;

            if(double.TryParse(txtWeight.Text, out weight))
            {
                if (rbCycling.Checked)
                {
                    lbCaloriesBurned.Items.Clear();
                    lbCaloriesBurned.Items.Add("Minutes   Calories Burnt");
                    for(int minutes = 10; minutes <= 50; minutes += 10)
                    {
                        caloriesBurned += weight * CYCLING_CALORIES_BURNED_PM;
                        Math.Round(caloriesBurned);
                        lbCaloriesBurned.Items.Add(minutes + "\t" + caloriesBurned);
                    }
                }
                else if (rbRunning.Checked)
                {
                    lbCaloriesBurned.Items.Clear();
                    lbCaloriesBurned.Items.Add("Minutes   Calories Burnt");
                    for (int minutes = 10; minutes <=50; minutes += 10)
                    {
                        caloriesBurned += weight * RUNNING_CALORIES_BURNED_PM;
                        Math.Round(caloriesBurned);
                        lbCaloriesBurned.Items.Add(minutes + "\t" + caloriesBurned);
                    }
                }
                else if (rbRowing.Checked)
                {
                    lbCaloriesBurned.Items.Clear();
                    lbCaloriesBurned.Items.Add("Minutes   Calories Burnt");
                    for (int minutes = 10; minutes <= 50; minutes += 10)
                    {
                        caloriesBurned += weight * ROWING_CALORIES_BURNED_PM;
                        Math.Round(caloriesBurned);
                        lbCaloriesBurned.Items.Add(minutes + "\t" + caloriesBurned);
                    }
                }
                else
                {
                    MessageBox.Show("Pick an exercise!");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for weight!");
                txtWeight.Text = "";
                lbCaloriesBurned.Items.Clear();
                txtWeight.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
