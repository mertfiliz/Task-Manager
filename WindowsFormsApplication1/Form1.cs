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
    public partial class Form1 : Form
    {
        public static class Globals
        {
            public static int GlobalInt { get; set; }
            public static Form2 secondForm = new Form2();
            public static Form3 thirdForm = new Form3();
            public static string userPass;
            public static int i;
            public static int errCount = 0;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {            
            StreamReader srPass = new StreamReader("D:\\Vc#\\userPass.txt");
            Globals.userPass = srPass.ReadLine();                 
            srPass.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
           if (textBox1.Text == Globals.userPass)
           {
                label2.ForeColor = Color.GreenYellow;
                label2.Text = "Access Granted";
                textBox1.Clear();
                textBox1.ReadOnly = true;
                Globals.i = 3;
                timer1.Enabled = true;
                timer1.Start();               
           }

           else
           {               
               label2.ForeColor = Color.Red;
               label2.Text = "Access Denied";
               Globals.errCount++;
               if (Globals.errCount >= 3)
               {
                   label2.Text = "System Blocked";
                   textBox1.Clear();
                   Globals.i = 3;
                   textBox1.ReadOnly = true;
                   timer2.Enabled = true;
                   timer2.Start();
               }
               textBox1.Clear();
           }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            timer1.Interval = 1000;
            Globals.i -= 1;

            if (Globals.i <= 0)
            {
                this.Hide();
                Globals.thirdForm.Show();
                timer1.Stop();                
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;

            Globals.i -= 1;

            if (Globals.i <= 0)
            {
                Application.Exit();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }

       
    }

}