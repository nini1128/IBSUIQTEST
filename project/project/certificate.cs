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
    public partial class certificate : Form
    {
        public certificate()
        {
            InitializeComponent();
            label1.Text = label1.Text+iqtest.iq.ToString();
            label3.Text = Form1.name;
            label4.Text = Form1.surname;
            label5.Text = DateTime.Now.ToShortDateString();
            label3.Text=label3.Text.ToUpper();
            label4.Text = label4.Text.ToUpper();
            string title = "";
            if (iqtest.iq < 100)
                title = "Unintelligent";
            else if (iqtest.iq < 120)
                title = "Intelligent";
            else
                title = "Genius";
            label8.Text += title+"\"";
            switch (title)
            {
                case "Unintelligent":
                    label9.Text = "You need to study more";
                    break;
               case "Intelligent":
                    label9.Text = "Congratulations! Your IQ score is sufficient";
                    break;
                case "Genius":
                    label9.Text = "Your IQ level is very high";
                    break;

            }
            
        }

        private void certificate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Form.ActiveForm;
            button1.Hide();
            using (var screen = new Bitmap(form.Width, form.Height))
            {
                form.DrawToBitmap(screen, new Rectangle(0, 0, screen.Width, screen.Height));
                screen.Save(@"C:\Users\NINIK0\Desktop\certificate.png");

            }

            this.Close();
        }
    }
}
