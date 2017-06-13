using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace project
{
    
    public partial class iqtest : Form
    {

      public static bool timeup = true;


        public static int iq = 80;
        public static bool q1 = false;
        public static string a1 = "";
        public static bool q2 = false;
        public static string a2 = "";
        public static bool q3 = false;
        public static string a3 = "";
        public static bool q4 = false;
        public static string a4 = "";
        public static bool q5 = false;
        public static string a5 = "";
        public static bool q6 = false;
        public static string a6 = "";
        public static bool q7 = false;
        public static string a7 = "";
        public static bool q8 = false;
        public static string a8 = "";
        public static bool q9 = false;
        public static string a9 = "";
        public static bool q10 = false;
        public static string a10 = "";

        private Stopwatch stopWatch;

        public iqtest()
        {
            InitializeComponent();
        }
        private void buttons()
        {
            button1.BackgroundImage = Properties.Resources.nextpic;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Text = "";

            button2.BackgroundImage = Properties.Resources.nextpic;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Text = "";

            button3.BackgroundImage = Properties.Resources.nextpic;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Text = "";

            button4.BackgroundImage = Properties.Resources.nextpic;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Text = "";

            button5.BackgroundImage = Properties.Resources.nextpic;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Text = "";

            button6.BackgroundImage = Properties.Resources.nextpic;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Text = "";

            button7.BackgroundImage = Properties.Resources.nextpic;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Text = "";

            button8.BackgroundImage = Properties.Resources.nextpic;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Text = "";

            button9.BackgroundImage = Properties.Resources.nextpic;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Text = "";
            

        }
        private void iqtest_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            timer1.Enabled = true;
            stopWatch.Start();
            buttons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                iq += 8;
                q1 = true;
                a1 = radioButton2.Text;
            }

            else if (radioButton1.Checked)
                a1 = radioButton1.Text;
            else if (radioButton3.Checked)
                a1 = radioButton3.Text;
            else if (radioButton4.Checked)
                a1 = radioButton4.Text;


            groupBox2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                iq += 8;
                q2 = true;
                a2 = radioButton8.Text;
            }
            else if (radioButton5.Checked)
                a2 = radioButton5.Text;
            else if (radioButton6.Checked)
                a2 = radioButton6.Text;
            else if (radioButton7.Checked)
                a2 = radioButton7.Text;
            groupBox3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                iq += 8;
                q3 = true;
                a3 = radioButton10.Text;
            }
            else if (radioButton9.Checked)
                a3 = radioButton9.Text;
            else if (radioButton11.Checked)
                a3 = radioButton11.Text;
            else if (radioButton12.Checked)
                a3 = radioButton12.Text;
            groupBox4.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                iq += 8;
                q4 = true;
                a4 = radioButton15.Text;
            }
            else if (radioButton13.Checked)
                a4 = radioButton13.Text;
            else if (radioButton14.Checked)
                a4 = radioButton14.Text;
            else if (radioButton16.Checked)
                a4 = radioButton16.Text;
            groupBox5.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                iq += 8;
                q5 = true;
                a5 = radioButton18.Text;
            }
            else if (radioButton17.Checked)
                a5 = radioButton17.Text;
            else if (radioButton19.Checked)
                a5 = radioButton19.Text;
            else if (radioButton20.Checked)
                a5 = radioButton20.Text;
            groupBox6.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                iq += 8;
                q6 = true;
                a6 = radioButton21.Text;
            }
            else if (radioButton22.Checked)
                a6 = radioButton22.Text;
            else if (radioButton23.Checked)
                a6 = radioButton23.Text;
            else if (radioButton24.Checked)
                a6 = radioButton24.Text;
            groupBox7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                iq += 8;
                q7 = true;
                a7 = radioButton28.Text;
            }
            else if (radioButton25.Checked)
                a7 = radioButton25.Text;
            else if (radioButton26.Checked)
                a7 = radioButton26.Text;
            else if (radioButton27.Checked)
                a7 = radioButton27.Text;
            groupBox8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                iq += 8;
                q8 = true;
                a8 = radioButton31.Text;
            }
            else if (radioButton29.Checked)
                a8 = radioButton29.Text;
            else if (radioButton30.Checked)
                a8 = radioButton30.Text;
            else if (radioButton32.Checked)
                a8 = radioButton32.Text;
            groupBox9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                iq += 8;
                q9 = true;
                a9 = radioButton33.Text;
            }
            else if (radioButton34.Checked)
                a9 = radioButton34.Text;
            else if (radioButton35.Checked)
                a9=radioButton35.Text;
            else if (radioButton36.Checked)
                a9 = radioButton36.Text;
            
            groupBox10.Show();
            groupBox9.Hide();
            groupBox8.Hide();
            groupBox7.Hide();
            groupBox6.Hide();
            groupBox5.Hide();
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox2.Hide();
            groupBox1.Hide();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton40.Checked)
            {
                iq += 8;
                q10 = true;
                a10 = radioButton40.Text;
            }
            else if (radioButton37.Checked)
                a10 = radioButton37.Text;
            else if (radioButton38.Checked)
                a10 = radioButton38.Text;
            else if (radioButton39.Checked)
                a10 = radioButton39.Text;


            timer1.Stop();
            string time = stopWatch.Elapsed.Minutes.ToString("00") + ":" +
         stopWatch.Elapsed.Seconds.ToString("00");
            MessageBox.Show("Thank you, the test is finished!\n"+time);
            this.Close();
            answers ans = new answers();
            ans.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stopWatch.Elapsed.Minutes ==10) {
                timeup = false;
                
                this.Close();
                answers ans = new answers();
                ans.Show();
            }
            timer.Text = "Time Elapsed : "+
        (9 - stopWatch.Elapsed.Minutes).ToString("00") + ":" +
        (59 - stopWatch.Elapsed.Seconds).ToString("00");
        }
    }
}
