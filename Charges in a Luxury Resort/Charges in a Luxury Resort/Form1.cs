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

namespace Charges_in_a_Luxury_Resort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal DAILY_ACCOMMODATION_CHARGE = 550m;

        private int days;
        private decimal restaurantCharges;
        private decimal spaCharges;
        private decimal rentalCharges;
        private decimal medicationCharges;
        private decimal stayCharges;
        private decimal miscCharges;
        private decimal totalBill;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtDays.Text, out days))
            {

                if(decimal.TryParse(txtRestaurant.Text, out restaurantCharges))
                {

                    if(decimal.TryParse(txtSpa.Text, out spaCharges))
                    {

                        if(decimal.TryParse(txtRental.Text, out rentalCharges))
                        {

                            if(decimal.TryParse(txtMedication.Text, out medicationCharges))
                            {
                                
                                stayCharges = CalcStayCharges(days);
                                miscCharges = CalcMiscCharges(restaurantCharges, spaCharges, rentalCharges, medicationCharges);
                                totalBill = CalcTotalCharges(miscCharges, stayCharges);

                                lbOutput.Items.Clear();

                                lbOutput.Items.Add("Stay charges: " + stayCharges.ToString("c2"));
                                lbOutput.Items.Add("Miscellaneous charges: " + miscCharges.ToString("c2"));
                                lbOutput.Items.Add("Total Bill: " + totalBill.ToString("c2"));
                                
                            }
                            else
                            {
                                MessageBox.Show("Invalid input for Medication and Rehabilitaion Bill");
                                txtMedication.Clear();
                                txtMedication.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid input for Car Rental");
                            txtRental.Clear();
                            txtRental.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Spa and Health Treatment Charges");
                        txtSpa.Clear();
                        txtSpa.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid input for Restaurant Charges");
                    txtRestaurant.Clear();
                    txtRestaurant.Focus();
                }

            }
            else
            {
                MessageBox.Show("Invalid input for No. of Days");
                txtDays.Clear();
                txtDays.Focus();
            }


        }

        private decimal CalcStayCharges(int days)
        {
            return days * DAILY_ACCOMMODATION_CHARGE;
        }

        private decimal CalcMiscCharges(decimal restaurantCharges, decimal spaCharges, decimal rentalCharges, decimal medicationCharges)
        {
            return restaurantCharges + spaCharges + rentalCharges + medicationCharges;
        }

        private decimal CalcTotalCharges(decimal miscCharges, decimal stayCharges)
        {
            return miscCharges + stayCharges;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
