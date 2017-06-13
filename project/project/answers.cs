using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class answers : Form
    {
        public answers()
        {
            InitializeComponent();

            if (iqtest.timeup == false)
            {
                MessageBox.Show("Sorry, Time is up!");
            }

            if (iqtest.q1)
                an1.BackColor = Color.Green;
            else
                an1.BackColor = Color.Red;

            if (iqtest.q2)
                an2.BackColor = Color.Green;
            else
                an2.BackColor = Color.Red;

            if (iqtest.q3)
                an3.BackColor = Color.Green;
            else
                an3.BackColor = Color.Red;

            if (iqtest.q4)
                an4.BackColor = Color.Green;
            else
                an4.BackColor = Color.Red;

            if (iqtest.q5)
                an5.BackColor = Color.Green;
            else
                an5.BackColor = Color.Red;

            if (iqtest.q6)
                an6.BackColor = Color.Green;
            else
                an6.BackColor = Color.Red;

            if (iqtest.q7)
                an7.BackColor = Color.Green;
            else
                an7.BackColor = Color.Red;

            if (iqtest.q8)
                an8.BackColor = Color.Green;
            else
                an8.BackColor = Color.Red;

            if (iqtest.q9)
                an9.BackColor = Color.Green;
            else
                an9.BackColor = Color.Red;

            if (iqtest.q10)
                an10.BackColor = Color.Green;
            else
                an10.BackColor = Color.Red;

            an1.Text += " " + iqtest.a1;
            an2.Text += " " + iqtest.a2;
            an3.Text += " " + iqtest.a3;
            an4.Text += " " + iqtest.a4;
            an5.Text += " " + iqtest.a5;
            an6.Text += " " + iqtest.a6;
            an7.Text += " " + iqtest.a7;
            an8.Text += " " + iqtest.a8;
            an9.Text += " " + iqtest.a9;
            an10.Text += " " + iqtest.a10;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            certificate cert = new certificate();
            this.Close();
            cert.Show();
        }
    }
}
