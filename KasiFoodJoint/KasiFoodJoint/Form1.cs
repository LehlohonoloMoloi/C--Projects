//LS Moloi, 30586453

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasiFoodJoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputePrice_Click(object sender, EventArgs e)
        {
            const decimal BURGER_PRICE = 25m;
            const decimal PRICE_0FF = 10m;
            const decimal SIDES_PRICE = 20m;
            const decimal DRINKS_PRICE = 15m;


            int cokeNum = 0,
                fantaNum = 0,
                creamsodaNum = 0,
                sidesNum = 0,
                burgerNum = 0;
            decimal amountDue = 0m, totalSides = 0m, totalDrinks = 0m, totalBurgers = 0m;
            string day;
            bool priceOff = false;
            string monSpecial = "Free drink on us. We got you ;)";
            string wedSpecial = "Free burger on us. We got you ;)";
            string friSpecial = "Free side on us. We got you ;)";
            string satSpecial = "R10 off your order. We got you ;)";

            day = tbDay.Text;

            //coke
            if (rbCoke.Checked)
            {

                if(int.TryParse(tbDrinks.Text, out cokeNum))
                {
                    if (cokeNum >= 0 && cokeNum < 11)
                    {


                        if (int.TryParse(tbBurgers.Text, out burgerNum))
                        {
                            if (burgerNum >= 0 && burgerNum < 11)
                            {
                                
                                lbOrder.Items.Clear();
                                if(cokeNum > 0)
                                {
                                    lbOrder.Items.Add("Coke");
                                }
                                

                                if (burgerNum > 0)
                                {
                                    lbOrder.Items.Add("Burger");
                                }


                                if (cbSalad.Checked)
                                {
                                    lbOrder.Items.Add("Salad");
                                    sidesNum++;
                                }
                                if (cbFries.Checked)
                                {
                                    lbOrder.Items.Add("Fries");
                                    sidesNum++;
                                }
                                if (cbWings.Checked)
                                {
                                    lbOrder.Items.Add("Wings");
                                    sidesNum++;
                                }




                                switch (day)
                                {
                                    case "Monday":
                                        if(cokeNum > 2)
                                        {
                                            MessageBox.Show(monSpecial);
                                            cokeNum++;   //extra free drink on monday
                                            totalDrinks = ((decimal)cokeNum * DRINKS_PRICE) - 15m;
                                        }
                                        else
                                        {
                                            totalDrinks = ((decimal)cokeNum * DRINKS_PRICE);
                                        }                                        
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;                                        
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    case "Wednesday":
                                        if(burgerNum > 2)
                                        {
                                            MessageBox.Show(wedSpecial);
                                            burgerNum++;  //extra free burger on wednesday
                                            totalBurgers = ((decimal)burgerNum * BURGER_PRICE) - 25m;
                                        }
                                        else
                                        {
                                            totalBurgers = ((decimal)burgerNum * BURGER_PRICE);
                                        }                                        
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)cokeNum * DRINKS_PRICE;                                        
                                        break;
                                    case "Friday":
                                        if(sidesNum > 2)
                                        {
                                            MessageBox.Show(friSpecial);
                                            sidesNum++;  //extra free side on friday
                                            totalSides = ((decimal)sidesNum * SIDES_PRICE) - 20m;
                                        }
                                        else
                                        {
                                            totalSides = ((decimal)sidesNum * SIDES_PRICE);
                                        }                                                                              
                                        totalDrinks = (decimal)cokeNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    case "Saturday":
                                        if(burgerNum > 2 || cokeNum > 2 || sidesNum > 2)
                                        {
                                            MessageBox.Show(satSpecial);
                                            priceOff = true;
                                        }                                       
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)cokeNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    default:   //regular menu
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)cokeNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                }

                                amountDue = totalSides + totalBurgers + totalDrinks;

                                if (priceOff)
                                {
                                    amountDue -= PRICE_0FF;
                                }

                                //display quantities
                                lblTotalBurgers.Text = burgerNum.ToString();
                                lblTotalDrinks.Text = cokeNum.ToString();
                                lblTotalSides.Text = sidesNum.ToString();

                                //display prices
                                lblTotalBurgersPrice.Text = totalBurgers.ToString("c1");
                                lblTotalDrinksPrice.Text = totalDrinks.ToString("c1");
                                lblTotalSidesPrice.Text = totalSides.ToString("c1");
                                lblOutputAmountDue.Text = amountDue.ToString("c1");
                            }
                            else
                            {
                                MessageBox.Show("Number of burgers must be between 0 and 10!");
                                tbBurgers.Text = "";
                                tbBurgers.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input for number of burgers!");
                            tbBurgers.Text = "";
                            tbBurgers.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of drinks must be between 0 and 10!");
                        tbDrinks.Text = "";
                        tbDrinks.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for number of drinks!");
                    tbDrinks.Text = "";
                    tbDrinks.Focus();
                }
            }

            //fanta Orange
            else if (rbFantaOrange.Checked)
            {
                if (int.TryParse(tbDrinks.Text, out fantaNum))
                {
                    if (fantaNum >= 0 && fantaNum < 11)
                    {


                        if (int.TryParse(tbBurgers.Text, out burgerNum))
                        {
                            if (burgerNum >= 0 && burgerNum < 11)
                            {

                                lbOrder.Items.Clear();
                                if(fantaNum > 0)
                                {
                                    lbOrder.Items.Add("Fanta Orange");
                                }
                                
                                if (burgerNum > 0)
                                {
                                    lbOrder.Items.Add("Burger");
                                }

                                if (cbSalad.Checked)
                                {
                                    lbOrder.Items.Add("Salad");
                                    sidesNum++;
                                }
                                if (cbFries.Checked)
                                {
                                    lbOrder.Items.Add("Fries");
                                    sidesNum++;
                                }
                                if (cbWings.Checked)
                                {
                                    lbOrder.Items.Add("Wings");
                                    sidesNum++;
                                }



                                switch (day)
                                {
                                    case "Monday":
                                        if(fantaNum > 2)
                                        {
                                            MessageBox.Show(monSpecial);
                                            fantaNum++;   //extra free drink on monday
                                            totalDrinks = ((decimal)fantaNum * DRINKS_PRICE) - 15m;
                                        }
                                        else
                                        {
                                            totalDrinks = ((decimal)fantaNum * DRINKS_PRICE);
                                        }                                       
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;                                       
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    case "Wednesday":
                                        if(burgerNum > 2)
                                        {
                                            MessageBox.Show(wedSpecial);
                                            burgerNum++;  //extra free burger on wednesday
                                            totalBurgers = ((decimal)burgerNum * BURGER_PRICE) - 25m;
                                        }
                                        else
                                        {
                                            totalBurgers = ((decimal)burgerNum * BURGER_PRICE);
                                        }
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)fantaNum * DRINKS_PRICE;                                      
                                        break;
                                    case "Friday":
                                        if(sidesNum > 2)
                                        {
                                            MessageBox.Show(friSpecial);
                                            sidesNum++;  //extra free side on friday
                                            totalSides = ((decimal)sidesNum * SIDES_PRICE) - 20m;
                                        }
                                        else
                                        {
                                            totalSides = ((decimal)sidesNum * SIDES_PRICE);
                                        }                                       
                                        totalDrinks = (decimal)fantaNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    case "Saturday":
                                        if(fantaNum > 0 || burgerNum > 0 || sidesNum > 0)
                                        {
                                            MessageBox.Show(satSpecial);
                                            priceOff = true;
                                        }                                     
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)fantaNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    default:   //regular menu
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)fantaNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                }

                                amountDue = totalSides + totalBurgers + totalDrinks;

                                if (priceOff)
                                {
                                    amountDue -= PRICE_0FF;
                                }

                                //display quantities
                                lblTotalBurgers.Text = burgerNum.ToString();
                                lblTotalDrinks.Text = fantaNum.ToString();
                                lblTotalSides.Text = sidesNum.ToString();

                                //display prices
                                lblTotalBurgersPrice.Text = totalBurgers.ToString("c1");
                                lblTotalDrinksPrice.Text = totalDrinks.ToString("c1");
                                lblTotalSidesPrice.Text = totalSides.ToString("c1");
                                lblOutputAmountDue.Text = amountDue.ToString("c1");
                            }
                            else
                            {
                                MessageBox.Show("Number of burgers must be between 0 and 10!");
                                tbBurgers.Text = "";
                                tbBurgers.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input for number of burgers!");
                            tbBurgers.Text = "";
                            tbBurgers.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of drinks must be between 0 and 10!");
                        tbDrinks.Text = "";
                        tbDrinks.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for number of drinks!");
                    tbDrinks.Text = "";
                    tbDrinks.Focus();
                }
            }

            //creamSoda
            else if (rbCreamsoda.Checked)
            {
                if (int.TryParse(tbDrinks.Text, out creamsodaNum))
                {
                    if (creamsodaNum >= 0 && creamsodaNum < 11)
                    {



                        if (int.TryParse(tbBurgers.Text, out burgerNum))
                        {
                            if (burgerNum >= 0 && burgerNum < 11)
                            {


                                lbOrder.Items.Clear();
                                if(creamsodaNum > 0)
                                {
                                    lbOrder.Items.Add("Creamsoda");
                                }
                                
                                if (burgerNum > 0)
                                {
                                    lbOrder.Items.Add("Burger");
                                }


                                if (cbSalad.Checked)
                                {
                                    lbOrder.Items.Add("Salad");
                                    sidesNum++;
                                }
                                if (cbFries.Checked)
                                {
                                    lbOrder.Items.Add("Fries");
                                    sidesNum++;
                                }
                                if (cbWings.Checked)
                                {
                                    lbOrder.Items.Add("Wings");
                                    sidesNum++;
                                }



                                switch (day)
                                {
                                    case "Monday":
                                        if(creamsodaNum > 2)
                                        {
                                            MessageBox.Show(monSpecial);
                                            creamsodaNum++;   //extra free drink on monday
                                            totalDrinks = ((decimal)creamsodaNum * DRINKS_PRICE) - 15m;
                                        }
                                        else
                                        {
                                            totalDrinks = ((decimal)creamsodaNum * DRINKS_PRICE);
                                        }
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;                                      
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    case "Wednesday":
                                        if(burgerNum > 0)
                                        {
                                            MessageBox.Show(wedSpecial);
                                            burgerNum++;  //extra free burger on wednesday
                                            totalBurgers = ((decimal)burgerNum * BURGER_PRICE) - 25m;
                                        }
                                        else
                                        {
                                            totalBurgers = ((decimal)burgerNum * BURGER_PRICE);
                                        }                                      
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)creamsodaNum * DRINKS_PRICE;                                       
                                        break;
                                    case "Friday":
                                        if(sidesNum > 2)
                                        {
                                            MessageBox.Show(friSpecial);
                                            sidesNum++;  //extra free side on friday
                                            totalSides = ((decimal)sidesNum * SIDES_PRICE) - 20m;
                                        }
                                        else
                                        {
                                            totalSides = ((decimal)sidesNum * SIDES_PRICE);
                                        }                                                                             
                                        totalDrinks = (decimal)creamsodaNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    case "Saturday":
                                        if(creamsodaNum > 0 || burgerNum > 0 || sidesNum > 0)
                                        {
                                            MessageBox.Show(satSpecial);
                                            priceOff = true;
                                        }                                       
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)creamsodaNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                    default:   //regular menu
                                        totalSides = (decimal)sidesNum * SIDES_PRICE;
                                        totalDrinks = (decimal)creamsodaNum * DRINKS_PRICE;
                                        totalBurgers = (decimal)burgerNum * BURGER_PRICE;
                                        break;
                                }

                                amountDue = totalSides + totalBurgers + totalDrinks;

                                if (priceOff)
                                {
                                    amountDue -= PRICE_0FF;
                                }

                                //display quantities
                                lblTotalBurgers.Text = burgerNum.ToString();
                                lblTotalDrinks.Text = creamsodaNum.ToString();
                                lblTotalSides.Text = sidesNum.ToString();

                                //display prices
                                lblTotalBurgersPrice.Text = totalBurgers.ToString("c1");
                                lblTotalDrinksPrice.Text = totalDrinks.ToString("c1");
                                lblTotalSidesPrice.Text = totalSides.ToString("c1");
                                lblOutputAmountDue.Text = amountDue.ToString("c1");
                            }
                            else
                            {
                                MessageBox.Show("Number of burgers must be between 0 and 10!");
                                tbBurgers.Text = "";
                                tbBurgers.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input for number of burgers!");
                            tbBurgers.Text = "";
                            tbBurgers.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of drinks must be between 0 and 10!");
                        tbDrinks.Text = "";
                        tbDrinks.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for number of drinks!");
                    tbDrinks.Text = "";
                    tbDrinks.Focus();
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextOrder_Click(object sender, EventArgs e)
        {
            cbSalad.Checked = false;
            cbFries.Checked = false;
            cbWings.Checked = false;

            rbCoke.Checked = true;

            //clear textboxes
            tbBurgers.Text = "";
            tbDay.Text = "";
            tbDrinks.Text = "";

            //clear listbox
            lbOrder.Items.Clear();

            //clear quantities
            lblTotalDrinks.Text = "";
            lblTotalBurgers.Text = "";
            lblTotalSides.Text = "";

            //clear prices
            lblTotalDrinksPrice.Text = "";
            lblTotalBurgersPrice.Text = "";
            lblTotalSidesPrice.Text = "";
            lblOutputAmountDue.Text = "";

            gbDrinks.Focus();
        }
    }
}
