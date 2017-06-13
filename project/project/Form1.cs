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
    public partial class Form1 : Form
    {
        public static string name;
        public static string surname;
        public static int age;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
    
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length < 2 || textBox2.Text.Length < 2 || textBox3.Text.Length == 0)
            {
                label5.Text = "Invalid Input";
            }
            else
            {
                
                bool valid = true;
                string[] symbols= new string[36] { "1","2","3","4","5","6","7","8","9","0","!","@","#","$","%","^","&","*","(",")","_","-","+","=","[","]","{","}", "|","?", "/","'",";",":",".",","};
                for(int i = 0; i < 36; i++)
                {
                    if (textBox1.Text.Contains(symbols[i]) || textBox2.Text.Contains(symbols[i]))
                    {
                        label5.Text = "Invalid Name/Surname";
                        valid = false;
                        break;
                    }
                }
                if (valid == true)
                {
                    name = textBox1.Text;
                    surname = textBox2.Text;
                    try
                    {
                        age = Convert.ToInt32(textBox3.Text);
                        this.Hide();
                        iqtest iq = new iqtest();
                        iq.Show();
                    }
                    catch
                    {
                        label5.Text = "Invalid Age";
                    }
                }

               
               
                /*
                */
                
            }
        }
    }
}
