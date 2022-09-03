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

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal dorm;
        private decimal meal;
        private decimal total;
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string dormItem;
            string mealItem;

           

            if (lbDorm.SelectedIndex == -1 && lbMeal.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a Dorm and a Meal Plan");
            }
            else
            {

                if (lbDorm.SelectedIndex > -1)
                {
                    if (lbMeal.SelectedIndex > -1)
                    {
                        dormItem = lbDorm.SelectedItem.ToString();
                        mealItem = lbMeal.SelectedItem.ToString();

                        switch (dormItem)
                        {
                            case "Allan Hall":
                                dorm = 1500m;
                                break;
                            case "Pike Hall":
                                dorm = 1600m;
                                break;
                            case "Farthing Hall":
                                dorm = 1800m;
                                break;
                            case "University Suites":
                                dorm = 2500m;
                                break;
                        }

                        switch (mealItem)
                        {
                            case "7 meals per week":
                                meal = 600m;
                                break;
                            case "14 meals per week":
                                meal = 1200m;
                                break;
                            case "Unlimited meals":
                                meal = 1700m;
                                break;
                        }

                        total = calcTotal(dorm, meal);

                        ResultForm results = new ResultForm();

                        results.lblDorm.Text = dorm.ToString("c2") + " per semester";
                        results.lblMeal.Text = meal.ToString("c2") + " per semester";
                        results.lblTotal.Text = total.ToString("c2");

                        results.ShowDialog();

                        
                    }
                    else
                    {
                        MessageBox.Show("You must select a meal plan");
                        lbMeal.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("You must select a dorm");
                    lbDorm.Focus();
                }

            }


        }

        private decimal calcTotal(decimal dorm, decimal meal)
        {
            return dorm + meal;
        }


    }
}
