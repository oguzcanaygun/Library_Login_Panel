using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "B", "C", "D", "E", "F", "G" };
            string[] sembol2 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol4 = { "+", "-", "/", "*", "#" };

            Random r = new Random();

            int s1, s2, s3, s4, s5;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);
            s4 = r.Next(0, sembol4.Length);
            s5 = r.Next(0, 10);

            textBox3.Text = sembol1[s1] + sembol2[s2] + s3 + sembol4[s4] + s5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            if (textBox3.Text == textBox4.Text)
            {
                
                label5.Text = "Verified you will be automatically directed to library";
                label5.Visible = true;
                pictureBox3.Visible = true;
                
            }
            if (textBox3.Text != textBox4.Text)
            {
               
                label5.Text = "Acces Denied";
                label5.Visible = true;
                pictureBox4.Visible = true;
                
            }
        }
    }
}
