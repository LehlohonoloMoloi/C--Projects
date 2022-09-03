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

namespace Sales_Commission_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal commissionEarned;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal sale;
            decimal percentage;
            

            if(decimal.TryParse(txtRevenueSale.Text, out sale))
            {
                if(decimal.TryParse(txtCommissionPercentage.Text, out percentage))
                {

                    if(percentage >= 0 && percentage <= 100)
                    {
                        
                        commissionEarned = CalculateCommission(sale, percentage);
                        lblCommission.Text = commissionEarned.ToString("c2");

                    }
                    else
                    {
                        MessageBox.Show("Commission Percentage must be between 0 and 100");
                        txtCommissionPercentage.Clear();
                        txtCommissionPercentage.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid input for Commission Percentage");
                    txtCommissionPercentage.Clear();
                    txtCommissionPercentage.Focus();
                }

            }
            else
            {
                MessageBox.Show("Invalid input for Revenue Sale");
                txtRevenueSale.Clear();
                txtRevenueSale.Focus();
            }

            btnExit.Enabled = true;

        }

        private decimal CalculateCommission(decimal sale, decimal percentage)
        {
            decimal commission = sale * (percentage / 100);

            return commission;
        }

    }
}
