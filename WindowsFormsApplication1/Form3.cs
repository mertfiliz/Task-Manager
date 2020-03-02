using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static int GlobalInt { get; set; }
            public static Form1 firstForm = new Form1();
            public static Form2 secondForm = new Form2();
            public static Form4 passForm = new Form4();
            
            
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.secondForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.passForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

       

        
    }
}
