//Moloi LS - 30586453

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newton_Converter_Application
{
    public partial class newtonConverter : Form
    {
        public newtonConverter()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double mass,
                    weight;

                mass = double.Parse(massTextbox.Text);
                weight = Math.Round((mass * 9.8), 1);

                if (weight < 10)
                {
                    outputLabel.Text = "It is too light.";
                    outputLabel.BackColor = Color.Blue;
                }
                else if (weight <= 1000)
                {
                    outputLabel.Text = "The weight is " + weight.ToString() + ".";
                    outputLabel.BackColor = Color.Green;
                }
                else if (weight > 1000)
                {
                    outputLabel.Text = "It is too heavy.";
                    outputLabel.BackColor = Color.Red;
                }
                else
                {
                    outputLabel.Text = "Mass cannot be negative.";
                    outputLabel.BackColor = Color.Black;
                    outputLabel.ForeColor = Color.White;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                massTextbox.Text = "";
                massTextbox.Focus();
            }
        }
    }
}
