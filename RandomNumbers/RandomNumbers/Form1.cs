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
using System.IO;
using System.Diagnostics;

namespace RandomNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRead.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter outFile;
            int randNum = 0;
            int numOfRandNums;

            Random rand = new Random();
            StreamWriter outputFile;

            if (int.TryParse(txtNumber.Text, out numOfRandNums))
            {
                try
                {
                    outputFile = File.CreateText("RandomNumbers.txt");

                    for (int i = 0; i < numOfRandNums; i++)
                    {
                        randNum = rand.Next(1, 101);
                        outputFile.WriteLine(randNum);
                    }
                    outputFile.Close();

                    MessageBox.Show("File saved successfully!");
                    btnRead.Enabled = true;
                }
                catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Invalid input for number!\nEnter number again.");
                txtNumber.Clear();
                txtNumber.Focus();
            }


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int count = 0;
            int number;
            int total = 0;
            StreamReader readFile;

            try
            {
                readFile = File.OpenText("RandomNumbers.txt");

                while (!readFile.EndOfStream)
                {
                    number = int.Parse(readFile.ReadLine());
                    total += number;
                    lbDetails.Items.Add(number);
                    count++;
                }

                lbDetails.Items.Add("");
                lbDetails.Items.Add("The number of random values read from file: " + count);
                lbDetails.Items.Add("The total of the numbers is: " + total);

                readFile.Close();

            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
