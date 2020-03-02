using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static int GlobalInt { get; set; }
            public static Form1 firstForm = new Form1();
            public static Form2 secondForm = new Form2();
            public static Form3 thirdForm = new Form3();
            public static int i;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userPass;

            StreamReader srPass = new StreamReader("D:\\Vc#\\userPass.txt");
            userPass = srPass.ReadLine();            
            srPass.Close();

            if (textBox1.Text == userPass)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    StreamWriter swPass = new StreamWriter("D:\\Vc#\\userPass.txt");
                    swPass.WriteLine(textBox2.Text);
                    swPass.Close();
                    label5.ForeColor = Color.Green;
                    label5.Text = "Successfully changed";
                    timer1.Enabled = true;
                    Globals.i = 5;
                    timer1.Start();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    Globals.i = 5;
                    label5.Text = "Passwords are not same!";
                    timer2.Enabled = true;
                    timer2.Start();
                    textBox2.Clear();
                    textBox3.Clear();
                }

            }
            else
            {
                label5.ForeColor = Color.Red;
                Globals.i = 5;
                label5.Text = "Incorrect Password!";
                timer3.Enabled = true;
                timer3.Start();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.thirdForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            Globals.i -= 1;

            if (Globals.i <= 0)
            {
                label5.Text = "";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;

            timer1.Interval = 1000;

            Globals.i -= 1;

            if (Globals.i <= 0)
            {
                label5.Text = "";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 1000;

            timer1.Interval = 1000;

            Globals.i -= 1;

            if (Globals.i <= 0)
            {
                label5.Text = "";
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
