//SL Moloi - 30586453

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayIncrease
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPay_Click(object sender, EventArgs e)
        {
            const decimal INCREASE_RATE = 0.05m;
            int index = 1;

            decimal pay;

            if(decimal.TryParse(txtCompensation.Text, out pay))
            {
                lbPayDetail.Items.Add("Year\tPay");

                while (index <= 5)
                {
                    if (index == 1)
                    {
                        lbPayDetail.Items.Add(index.ToString() + "\t" + pay.ToString("c2"));
                    }
                    else
                    {
                        pay += pay * INCREASE_RATE;

                        lbPayDetail.Items.Add(index.ToString() + "\t" + pay.ToString("c2"));
                    }
                    index++;
                }
            }
            else
            {
                MessageBox.Show("Invalid value for teacher's initial pay!");
                txtCompensation.Text = "";
                txtCompensation.Focus();
            }

            

            
        }
    }
}
