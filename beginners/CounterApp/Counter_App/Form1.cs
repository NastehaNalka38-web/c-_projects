using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_App
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
            //initializing value using parse method
            count = int.Parse(lblCount.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void increaseBtn_Click(object sender, EventArgs e)
        {
            //increasing count by 1
            //count += 1;

            count++;
            lblCount.Text = count.ToString();
        }

        private void decreaseBtn_Click(object sender, EventArgs e)
        {
            //checking whether count is greater than 0 to decrease
            if (count > 0)
            {
                //decrease the count
                //count -=1

                count--;
                lblCount.Text = count.ToString();
            }
        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            //reset to default
            //lblCount.Text = "0";

            count = 0;
            lblCount.Text = count.ToString();
        }
    }
}
