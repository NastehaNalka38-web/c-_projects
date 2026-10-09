using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temprature_ConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            //Use exception handling to catch and handle errors.
            //so the program doesn't crash unexpectedly.
            try
            {
                //Declare variables to hold the input value and the converted value.
                double celcius;
                double fahrenheit;

                //Check if the input value is empty or not a number.
                if (!C2FBtn.Checked && !F2CBtn.Checked)
                {
                    MessageBox.Show("Please select a conversion type.");
                    return;
                }

                //Check if user has chosed celcius to fehrenheit, then the formula (C * 9/5) + 32.
                if (C2FBtn.Checked)
                {
                    celcius = double.Parse(txtValue.Text);
                    fahrenheit = (celcius * 9 / 5) + 32;
                    lblResultOut.Text = Convert.ToString(fahrenheit + "°F");
                }

                //Check if user has chosed fehrenheit to celcius, then the formula (F - 32) * 5/9.
                if (F2CBtn.Checked)
                {
                    fahrenheit = double.Parse(txtValue.Text);
                    celcius = (fahrenheit - 32) * 5 / 9;
                    lblResultOut.Text = Convert.ToString( celcius + "°C");
                }
            }
            //Catch any exceptions that may occur during the conversion process and display an error message.
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //Reset the input value, output value, and radio buttons to their default state.
            txtValue.Text = "";
            lblResultOut.Text = "";
            C2FBtn.Checked = false;
            F2CBtn.Checked = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Close the application when the exit button is clicked.
            Application.Exit();
        }
    }
}
