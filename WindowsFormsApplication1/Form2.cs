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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();                        
        }
        
        public static class Globals
        {
            public static int GlobalInt { get; set; }
            public static Form1 firstForm = new Form1();
            public static Form3 thirdForm = new Form3();
            public static Form4 passForm = new Form4();
            public static int i;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamWriter swNCSeries1 = new StreamWriter("D:\\Vc#\\NC\\NCSeries1.txt");
            swNCSeries1.WriteLine(NCSeries1.Text);
            swNCSeries1.Close();

            StreamWriter swNCSeries2 = new StreamWriter("D:\\Vc#\\NC\\NCSeries2.txt");
            swNCSeries2.WriteLine(NCSeries2.Text);
            swNCSeries2.Close();

            StreamWriter swNCSeries3 = new StreamWriter("D:\\Vc#\\NC\\NCSeries3.txt");
            swNCSeries3.WriteLine(NCSeries3.Text);
            swNCSeries3.Close();

            StreamWriter swNCSeries4 = new StreamWriter("D:\\Vc#\\NC\\NCSeries4.txt");
            swNCSeries4.WriteLine(NCSeries4.Text);
            swNCSeries4.Close();

            StreamWriter swNCSeries5 = new StreamWriter("D:\\Vc#\\NC\\NCSeries5.txt");
            swNCSeries5.WriteLine(NCSeries5.Text);
            swNCSeries5.Close();

            StreamWriter swNCSeries6 = new StreamWriter("D:\\Vc#\\NC\\NCSeries6.txt");
            swNCSeries6.WriteLine(NCSeries6.Text);
            swNCSeries6.Close();

            StreamWriter swNCSeries7 = new StreamWriter("D:\\Vc#\\NC\\NCSeries7.txt");
            swNCSeries7.WriteLine(NCSeries7.Text);
            swNCSeries7.Close();

            StreamWriter swNCSeries8 = new StreamWriter("D:\\Vc#\\NC\\NCSeries8.txt");
            swNCSeries8.WriteLine(NCSeries8.Text);
            swNCSeries8.Close();

            StreamWriter swNCSeries9 = new StreamWriter("D:\\Vc#\\NC\\NCSeries9.txt");
            swNCSeries9.WriteLine(NCSeries9.Text);
            swNCSeries9.Close();

            /*   COSeries   */ 

            StreamWriter swCOSeries1 = new StreamWriter("D:\\Vc#\\COS\\COSeries1.txt");
            swCOSeries1.WriteLine(COSeries1.Text);
            swCOSeries1.Close();

            StreamWriter swCOSeries2 = new StreamWriter("D:\\Vc#\\COS\\COSeries2.txt");
            swCOSeries2.WriteLine(COSeries2.Text);
            swCOSeries2.Close();

            StreamWriter swCOSeries3 = new StreamWriter("D:\\Vc#\\COS\\COSeries3.txt");
            swCOSeries3.WriteLine(COSeries3.Text);
            swCOSeries3.Close();

            StreamWriter swCOSeries4 = new StreamWriter("D:\\Vc#\\COS\\COSeries4.txt");
            swCOSeries4.WriteLine(COSeries4.Text);
            swCOSeries4.Close();

            StreamWriter swCOSeries5 = new StreamWriter("D:\\Vc#\\COS\\COSeries5.txt");
            swCOSeries5.WriteLine(COSeries5.Text);
            swCOSeries5.Close();

            StreamWriter swCOSeries6 = new StreamWriter("D:\\Vc#\\COS\\COSeries6.txt");
            swCOSeries6.WriteLine(COSeries6.Text);
            swCOSeries6.Close();

            StreamWriter swCOSeries7 = new StreamWriter("D:\\Vc#\\COS\\COSeries7.txt");
            swCOSeries7.WriteLine(COSeries7.Text);
            swCOSeries7.Close();

            StreamWriter swCOSeries8 = new StreamWriter("D:\\Vc#\\COS\\COSeries8.txt");
            swCOSeries8.WriteLine(COSeries8.Text);
            swCOSeries8.Close();

            StreamWriter swCOSeries9 = new StreamWriter("D:\\Vc#\\COS\\COSeries9.txt");
            swCOSeries9.WriteLine(COSeries9.Text);
            swCOSeries9.Close();

            /*    COMovies        */

            StreamWriter swCOMovies1 = new StreamWriter("D:\\Vc#\\COM\\COMovies1.txt");
            swCOMovies1.WriteLine(COMovies1.Text);
            swCOMovies1.Close();

            StreamWriter swCOMovies2 = new StreamWriter("D:\\Vc#\\COM\\COMovies2.txt");
            swCOMovies2.WriteLine(COMovies2.Text);
            swCOMovies2.Close();

            StreamWriter swCOMovies3 = new StreamWriter("D:\\Vc#\\COM\\COMovies3.txt");
            swCOMovies3.WriteLine(COMovies3.Text);
            swCOMovies3.Close();

            StreamWriter swCOMovies4 = new StreamWriter("D:\\Vc#\\COM\\COMovies4.txt");
            swCOMovies4.WriteLine(COMovies4.Text);
            swCOMovies4.Close();

            StreamWriter swCOMovies5 = new StreamWriter("D:\\Vc#\\COM\\COMovies5.txt");
            swCOMovies5.WriteLine(COMovies5.Text);
            swCOMovies5.Close();

            StreamWriter swCOMovies6 = new StreamWriter("D:\\Vc#\\COM\\COMovies6.txt");
            swCOMovies6.WriteLine(COMovies6.Text);
            swCOMovies6.Close();

            StreamWriter swCOMovies7 = new StreamWriter("D:\\Vc#\\COM\\COMovies7.txt");
            swCOMovies7.WriteLine(COMovies7.Text);
            swCOMovies7.Close();

            StreamWriter swCOMovies8 = new StreamWriter("D:\\Vc#\\COM\\COMovies8.txt");
            swCOMovies8.WriteLine(COMovies8.Text);
            swCOMovies8.Close();

            StreamWriter swCOMovies9 = new StreamWriter("D:\\Vc#\\COM\\COMovies9.txt");
            swCOMovies9.WriteLine(COMovies9.Text);
            swCOMovies9.Close();

            /*   COGames   */

            StreamWriter swCOGames1 = new StreamWriter("D:\\Vc#\\COG\\COGames1.txt");
            swCOGames1.WriteLine(COGames1.Text);
            swCOGames1.Close();

            StreamWriter swCOGames2 = new StreamWriter("D:\\Vc#\\COG\\COGames2.txt");
            swCOGames2.WriteLine(COGames2.Text);
            swCOGames2.Close();

            StreamWriter swCOGames3 = new StreamWriter("D:\\Vc#\\COG\\COGames3.txt");
            swCOGames3.WriteLine(COGames3.Text);
            swCOGames3.Close();

            StreamWriter swCOGames4 = new StreamWriter("D:\\Vc#\\COG\\COGames4.txt");
            swCOGames4.WriteLine(COGames4.Text);
            swCOGames4.Close();

            StreamWriter swCOGames5 = new StreamWriter("D:\\Vc#\\COG\\COGames5.txt");
            swCOGames5.WriteLine(COGames5.Text);
            swCOGames5.Close();

            StreamWriter swCOGames6 = new StreamWriter("D:\\Vc#\\COG\\COGames6.txt");
            swCOGames6.WriteLine(COGames6.Text);
            swCOGames6.Close();

            StreamWriter swCOGames7 = new StreamWriter("D:\\Vc#\\COG\\COGames7.txt");
            swCOGames7.WriteLine(COGames7.Text);
            swCOGames7.Close();

            StreamWriter swCOGames8 = new StreamWriter("D:\\Vc#\\COG\\COGames8.txt");
            swCOGames8.WriteLine(COGames8.Text);
            swCOGames8.Close();

            StreamWriter swCOGames9 = new StreamWriter("D:\\Vc#\\COG\\COGames9.txt");
            swCOGames9.WriteLine(COGames9.Text);
            swCOGames9.Close();

            /*    TDM   */

            StreamWriter swTDMonth1 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth1.txt");
            swTDMonth1.WriteLine(TDMonth1.Text);
            swTDMonth1.Close();

            StreamWriter swTDMonth2 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth2.txt");
            swTDMonth2.WriteLine(TDMonth2.Text);
            swTDMonth2.Close();

            StreamWriter swTDMonth3 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth3.txt");
            swTDMonth3.WriteLine(TDMonth3.Text);
            swTDMonth3.Close();

            StreamWriter swTDMonth4 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth4.txt");
            swTDMonth4.WriteLine(TDMonth4.Text);
            swTDMonth4.Close();

            StreamWriter swTDMonth5 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth5.txt");
            swTDMonth5.WriteLine(TDMonth5.Text);
            swTDMonth5.Close();

            StreamWriter swTDMonth6 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth6.txt");
            swTDMonth6.WriteLine(TDMonth6.Text);
            swTDMonth6.Close();

            StreamWriter swTDMonth7 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth7.txt");
            swTDMonth7.WriteLine(TDMonth7.Text);
            swTDMonth7.Close();

            StreamWriter swTDMonth8 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth8.txt");
            swTDMonth8.WriteLine(TDMonth8.Text);
            swTDMonth8.Close();

            StreamWriter swTDMonth9 = new StreamWriter("D:\\Vc#\\TDM\\TDMonth9.txt");
            swTDMonth9.WriteLine(TDMonth9.Text);
            swTDMonth9.Close();

            /* TDY  */

            StreamWriter swTDYear1 = new StreamWriter("D:\\Vc#\\TDY\\TDYear1.txt");
            swTDYear1.WriteLine(TDYear1.Text);
            swTDYear1.Close();

            StreamWriter swTDYear2 = new StreamWriter("D:\\Vc#\\TDY\\TDYear2.txt");
            swTDYear2.WriteLine(TDYear2.Text);
            swTDYear2.Close();

            StreamWriter swTDYear3 = new StreamWriter("D:\\Vc#\\TDY\\TDYear3.txt");
            swTDYear3.WriteLine(TDYear3.Text);
            swTDYear3.Close();

            StreamWriter swTDYear4 = new StreamWriter("D:\\Vc#\\TDY\\TDYear4.txt");
            swTDYear4.WriteLine(TDYear4.Text);
            swTDYear4.Close();

            StreamWriter swTDYear5 = new StreamWriter("D:\\Vc#\\TDY\\TDYear5.txt");
            swTDYear5.WriteLine(TDYear5.Text);
            swTDYear5.Close();

            StreamWriter swTDYear6 = new StreamWriter("D:\\Vc#\\TDY\\TDYear6.txt");
            swTDYear6.WriteLine(TDYear6.Text);
            swTDYear6.Close();

            StreamWriter swTDYear7 = new StreamWriter("D:\\Vc#\\TDY\\TDYear7.txt");
            swTDYear7.WriteLine(TDYear7.Text);
            swTDYear7.Close();

            StreamWriter swTDYear8 = new StreamWriter("D:\\Vc#\\TDY\\TDYear8.txt");
            swTDYear8.WriteLine(TDYear8.Text);
            swTDYear8.Close();

            StreamWriter swTDYear9 = new StreamWriter("D:\\Vc#\\TDY\\TDYear9.txt");
            swTDYear9.WriteLine(TDYear9.Text);
            swTDYear9.Close();

            Globals.i = 5;
            label8.ForeColor = Color.GreenYellow;
            label8.Text = "Successfully saved!";
            timer1.Enabled = true;
            timer1.Start();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label9.Select();

            string line;

            StreamReader srNCSeries1 = new StreamReader("D:\\Vc#\\NC\\NCSeries1.txt");
            line = srNCSeries1.ReadLine();
            NCSeries1.Text = line;
            srNCSeries1.Close();

            StreamReader srNCSeries2 = new StreamReader("D:\\Vc#\\NC\\NCSeries2.txt");
            line = srNCSeries2.ReadLine();
            NCSeries2.Text = line;
            srNCSeries2.Close();

            StreamReader srNCSeries3 = new StreamReader("D:\\Vc#\\NC\\NCSeries3.txt");
            line = srNCSeries3.ReadLine();
            NCSeries3.Text = line;
            srNCSeries3.Close();

            StreamReader srNCSeries4 = new StreamReader("D:\\Vc#\\NC\\NCSeries4.txt");
            line = srNCSeries4.ReadLine();
            NCSeries4.Text = line;
            srNCSeries4.Close();

            StreamReader srNCSeries5 = new StreamReader("D:\\Vc#\\NC\\NCSeries5.txt");
            line = srNCSeries5.ReadLine();
            NCSeries5.Text = line;
            srNCSeries5.Close();

            StreamReader srNCSeries6 = new StreamReader("D:\\Vc#\\NC\\NCSeries6.txt");
            line = srNCSeries6.ReadLine();
            NCSeries6.Text = line;
            srNCSeries6.Close();

            StreamReader srNCSeries7 = new StreamReader("D:\\Vc#\\NC\\NCSeries7.txt");
            line = srNCSeries7.ReadLine();
            NCSeries7.Text = line;
            srNCSeries7.Close();

            StreamReader srNCSeries8 = new StreamReader("D:\\Vc#\\NC\\NCSeries8.txt");
            line = srNCSeries8.ReadLine();
            NCSeries8.Text = line;
            srNCSeries8.Close();

            StreamReader srNCSeries9 = new StreamReader("D:\\Vc#\\NC\\NCSeries9.txt");
            line = srNCSeries9.ReadLine();
            NCSeries9.Text = line;
            srNCSeries9.Close();
            
            /* COSeries  */

            StreamReader srCOSeries1 = new StreamReader("D:\\Vc#\\COS\\CoSeries1.txt");
            line = srCOSeries1.ReadLine();
            COSeries1.Text = line;
            srCOSeries1.Close();

            StreamReader srCOSeries2 = new StreamReader("D:\\Vc#\\COS\\CoSeries2.txt");
            line = srCOSeries2.ReadLine();
            COSeries2.Text = line;
            srCOSeries2.Close();

            StreamReader srCOSeries3 = new StreamReader("D:\\Vc#\\COS\\CoSeries3.txt");
            line = srCOSeries3.ReadLine();
            COSeries3.Text = line;
            srCOSeries3.Close();

            StreamReader srCOSeries4 = new StreamReader("D:\\Vc#\\COS\\CoSeries4.txt");
            line = srCOSeries4.ReadLine();
            COSeries4.Text = line;
            srCOSeries4.Close();

            StreamReader srCOSeries5 = new StreamReader("D:\\Vc#\\COS\\CoSeries5.txt");
            line = srCOSeries5.ReadLine();
            COSeries5.Text = line;
            srCOSeries5.Close();

            StreamReader srCOSeries6 = new StreamReader("D:\\Vc#\\COS\\CoSeries6.txt");
            line = srCOSeries6.ReadLine();
            COSeries6.Text = line;
            srCOSeries6.Close();

            StreamReader srCOSeries7 = new StreamReader("D:\\Vc#\\COS\\CoSeries7.txt");
            line = srCOSeries7.ReadLine();
            COSeries7.Text = line;
            srCOSeries7.Close();

            StreamReader srCOSeries8 = new StreamReader("D:\\Vc#\\COS\\CoSeries8.txt");
            line = srCOSeries8.ReadLine();
            COSeries8.Text = line;
            srCOSeries8.Close();

            StreamReader srCOSeries9 = new StreamReader("D:\\Vc#\\COS\\CoSeries9.txt");
            line = srCOSeries9.ReadLine();
            COSeries9.Text = line;
            srCOSeries9.Close();

            /* CO Movies */

            StreamReader srCOMovies1 = new StreamReader("D:\\Vc#\\COM\\CoMovies1.txt");
            line = srCOMovies1.ReadLine();
            COMovies1.Text = line;
            srCOMovies1.Close();

            StreamReader srCOMovies2 = new StreamReader("D:\\Vc#\\COM\\CoMovies2.txt");
            line = srCOMovies2.ReadLine();
            COMovies2.Text = line;
            srCOMovies2.Close();

            StreamReader srCOMovies3 = new StreamReader("D:\\Vc#\\COM\\CoMovies3.txt");
            line = srCOMovies3.ReadLine();
            COMovies3.Text = line;
            srCOMovies3.Close();

            StreamReader srCOMovies4 = new StreamReader("D:\\Vc#\\COM\\CoMovies4.txt");
            line = srCOMovies4.ReadLine();
            COMovies4.Text = line;
            srCOMovies4.Close();

            StreamReader srCOMovies5 = new StreamReader("D:\\Vc#\\COM\\CoMovies5.txt");
            line = srCOMovies5.ReadLine();
            COMovies5.Text = line;
            srCOMovies5.Close();

            StreamReader srCOMovies6 = new StreamReader("D:\\Vc#\\COM\\CoMovies6.txt");
            line = srCOMovies6.ReadLine();
            COMovies6.Text = line;
            srCOMovies6.Close();

            StreamReader srCOMovies7 = new StreamReader("D:\\Vc#\\COM\\CoMovies7.txt");
            line = srCOMovies7.ReadLine();
            COMovies7.Text = line;
            srCOMovies7.Close();

            StreamReader srCOMovies8 = new StreamReader("D:\\Vc#\\COM\\CoMovies8.txt");
            line = srCOMovies8.ReadLine();
            COMovies8.Text = line;
            srCOMovies8.Close();

            StreamReader srCOMovies9 = new StreamReader("D:\\Vc#\\COM\\CoMovies9.txt");
            line = srCOMovies9.ReadLine();
            COMovies9.Text = line;
            srCOMovies9.Close();

            /*    COGames   */

            StreamReader srCOGames1 = new StreamReader("D:\\Vc#\\COG\\CoGames1.txt");
            line = srCOGames1.ReadLine();
            COGames1.Text = line;
            srCOGames1.Close();

            StreamReader srCOGames2 = new StreamReader("D:\\Vc#\\COG\\CoGames2.txt");
            line = srCOGames2.ReadLine();
            COGames2.Text = line;
            srCOGames2.Close();

            StreamReader srCOGames3 = new StreamReader("D:\\Vc#\\COG\\CoGames3.txt");
            line = srCOGames3.ReadLine();
            COGames3.Text = line;
            srCOGames3.Close();

            StreamReader srCOGames4 = new StreamReader("D:\\Vc#\\COG\\CoGames4.txt");
            line = srCOGames4.ReadLine();
            COGames4.Text = line;
            srCOGames4.Close();

            StreamReader srCOGames5 = new StreamReader("D:\\Vc#\\COG\\CoGames5.txt");
            line = srCOGames5.ReadLine();
            COGames5.Text = line;
            srCOGames5.Close();

            StreamReader srCOGames6 = new StreamReader("D:\\Vc#\\COG\\CoGames6.txt");
            line = srCOGames6.ReadLine();
            COGames6.Text = line;
            srCOGames6.Close();

            StreamReader srCOGames7 = new StreamReader("D:\\Vc#\\COG\\CoGames7.txt");
            line = srCOGames7.ReadLine();
            COGames7.Text = line;
            srCOGames7.Close();

            StreamReader srCOGames8 = new StreamReader("D:\\Vc#\\COG\\CoGames8.txt");
            line = srCOGames8.ReadLine();
            COGames8.Text = line;
            srCOGames8.Close();

            StreamReader srCOGames9 = new StreamReader("D:\\Vc#\\COG\\CoGames9.txt");
            line = srCOGames9.ReadLine();
            COGames9.Text = line;
            srCOGames9.Close(); 

            /* TDM  */

            StreamReader srTDMonth1 = new StreamReader("D:\\Vc#\\TDM\\TdMonth1.txt");
            line = srTDMonth1.ReadLine();
            TDMonth1.Text = line;
            srTDMonth1.Close();

            StreamReader srTDMonth2 = new StreamReader("D:\\Vc#\\TDM\\TdMonth2.txt");
            line = srTDMonth2.ReadLine();
            TDMonth2.Text = line;
            srTDMonth2.Close();

            StreamReader srTDMonth3 = new StreamReader("D:\\Vc#\\TDM\\TdMonth3.txt");
            line = srTDMonth3.ReadLine();
            TDMonth3.Text = line;
            srTDMonth3.Close();

            StreamReader srTDMonth4 = new StreamReader("D:\\Vc#\\TDM\\TdMonth4.txt");
            line = srTDMonth4.ReadLine();
            TDMonth4.Text = line;
            srTDMonth4.Close();

            StreamReader srTDMonth5 = new StreamReader("D:\\Vc#\\TDM\\TdMonth5.txt");
            line = srTDMonth5.ReadLine();
            TDMonth5.Text = line;
            srTDMonth5.Close();

            StreamReader srTDMonth6 = new StreamReader("D:\\Vc#\\TDM\\TdMonth6.txt");
            line = srTDMonth6.ReadLine();
            TDMonth6.Text = line;
            srTDMonth6.Close();

            StreamReader srTDMonth7 = new StreamReader("D:\\Vc#\\TDM\\TdMonth7.txt");
            line = srTDMonth7.ReadLine();
            TDMonth7.Text = line;
            srTDMonth7.Close();

            StreamReader srTDMonth8 = new StreamReader("D:\\Vc#\\TDM\\TdMonth8.txt");
            line = srTDMonth8.ReadLine();
            TDMonth8.Text = line;
            srTDMonth8.Close();

            StreamReader srTDMonth9 = new StreamReader("D:\\Vc#\\TDM\\TdMonth9.txt");
            line = srTDMonth9.ReadLine();
            TDMonth9.Text = line;
            srTDMonth9.Close();

            /*   TDY   */

            StreamReader srTDYear1 = new StreamReader("D:\\Vc#\\TDY\\TdYear1.txt");
            line = srTDYear1.ReadLine();
            TDYear1.Text= line;
            srTDYear1.Close();

            StreamReader srTDYear2 = new StreamReader("D:\\Vc#\\TDY\\TdYear2.txt");
            line = srTDYear2.ReadLine();
            TDYear2.Text = line;
            srTDYear2.Close();

            StreamReader srTDYear3 = new StreamReader("D:\\Vc#\\TDY\\TdYear3.txt");
            line = srTDYear3.ReadLine();
            TDYear3.Text = line;
            srTDYear3.Close();

            StreamReader srTDYear4 = new StreamReader("D:\\Vc#\\TDY\\TdYear4.txt");
            line = srTDYear4.ReadLine();
            TDYear4.Text = line;
            srTDYear4.Close();

            StreamReader srTDYear5 = new StreamReader("D:\\Vc#\\TDY\\TdYear5.txt");
            line = srTDYear5.ReadLine();
            TDYear5.Text = line;
            srTDYear5.Close();

            StreamReader srTDYear6 = new StreamReader("D:\\Vc#\\TDY\\TdYear6.txt");
            line = srTDYear6.ReadLine();
            TDYear6.Text = line;
            srTDYear6.Close();

            StreamReader srTDYear7 = new StreamReader("D:\\Vc#\\TDY\\TdYear7.txt");
            line = srTDYear7.ReadLine();
            TDYear7.Text = line;
            srTDYear7.Close();

            StreamReader srTDYear8 = new StreamReader("D:\\Vc#\\TDY\\TdYear8.txt");
            line = srTDYear8.ReadLine();
            TDYear8.Text = line;
            srTDYear8.Close();

            StreamReader srTDYear9 = new StreamReader("D:\\Vc#\\TDY\\TdYear9.txt");
            line = srTDYear9.ReadLine();
            TDYear9.Text = line;
            srTDYear9.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NCSeries1.Clear();           
            NCSeries2.Clear();
            NCSeries3.Clear();
            NCSeries4.Clear();
            NCSeries5.Clear();
            NCSeries6.Clear();
            NCSeries7.Clear();
            NCSeries8.Clear();
            NCSeries9.Clear();

            COSeries1.Clear();
            COSeries2.Clear();
            COSeries3.Clear();
            COSeries4.Clear();
            COSeries5.Clear();
            COSeries6.Clear();
            COSeries7.Clear();
            COSeries8.Clear();
            COSeries9.Clear();

            COMovies1.Clear();
            COMovies2.Clear();
            COMovies3.Clear();
            COMovies4.Clear();
            COMovies5.Clear();
            COMovies6.Clear();
            COMovies7.Clear();
            COMovies8.Clear();
            COMovies9.Clear();

            COGames1.Clear();
            COGames2.Clear();
            COGames3.Clear();
            COGames4.Clear();
            COGames5.Clear();
            COGames6.Clear();
            COGames7.Clear();
            COGames8.Clear();
            COGames9.Clear();

            TDMonth1.Clear();
            TDMonth2.Clear();
            TDMonth3.Clear();
            TDMonth4.Clear();
            TDMonth5.Clear();
            TDMonth6.Clear();
            TDMonth7.Clear();
            TDMonth8.Clear();
            TDMonth9.Clear();

            TDYear1.Clear();
            TDYear2.Clear();
            TDYear3.Clear();
            TDYear4.Clear();
            TDYear5.Clear();
            TDYear6.Clear();
            TDYear7.Clear();
            TDYear8.Clear();
            TDYear9.Clear();

            Globals.i = 5;
            label8.ForeColor = Color.LightCoral;
            timer2.Start();
            label8.Text = "All data cleared";

            
        }

        private void button3_Click(object sender, EventArgs e)
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
                label8.Text = "";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;

            Globals.i -= 1;

            if (Globals.i <= 0)
            {
                label8.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            NCSeries1.Text = NCSeries2.Text;
            NCSeries2.Text = NCSeries3.Text;
            NCSeries3.Text = NCSeries4.Text;
            NCSeries4.Text = NCSeries5.Text;
            NCSeries5.Text = NCSeries6.Text;
            NCSeries6.Text = NCSeries7.Text;
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();




        }

        private void button5_Click(object sender, EventArgs e)
        {
            NCSeries2.Text = NCSeries3.Text;
            NCSeries3.Text = NCSeries4.Text;
            NCSeries4.Text = NCSeries5.Text;
            NCSeries5.Text = NCSeries6.Text;
            NCSeries6.Text = NCSeries7.Text;
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NCSeries3.Text = NCSeries4.Text;
            NCSeries4.Text = NCSeries5.Text;
            NCSeries5.Text = NCSeries6.Text;
            NCSeries6.Text = NCSeries7.Text;
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NCSeries4.Text = NCSeries5.Text;
            NCSeries5.Text = NCSeries6.Text;
            NCSeries6.Text = NCSeries7.Text;
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NCSeries5.Text = NCSeries6.Text;
            NCSeries6.Text = NCSeries7.Text;
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NCSeries6.Text = NCSeries7.Text;
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NCSeries7.Text = NCSeries8.Text;
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NCSeries8.Text = NCSeries9.Text;
            NCSeries9.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NCSeries9.Clear();
        }

        

        private void button21_Click(object sender, EventArgs e)
        {
            COSeries1.Text = COSeries2.Text;
            COSeries2.Text = COSeries3.Text;
            COSeries3.Text = COSeries4.Text;
            COSeries4.Text = COSeries5.Text;
            COSeries5.Text = COSeries6.Text;
            COSeries6.Text = COSeries7.Text;
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            COSeries2.Text = COSeries3.Text;
            COSeries3.Text = COSeries4.Text;
            COSeries4.Text = COSeries5.Text;
            COSeries5.Text = COSeries6.Text;
            COSeries6.Text = COSeries7.Text;
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {            
            COSeries3.Text = COSeries4.Text;
            COSeries4.Text = COSeries5.Text;
            COSeries5.Text = COSeries6.Text;
            COSeries6.Text = COSeries7.Text;
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            COSeries4.Text = COSeries5.Text;
            COSeries5.Text = COSeries6.Text;
            COSeries6.Text = COSeries7.Text;
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            COSeries5.Text = COSeries6.Text;
            COSeries6.Text = COSeries7.Text;
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            COSeries6.Text = COSeries7.Text;
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            COSeries7.Text = COSeries8.Text;
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            COSeries8.Text = COSeries9.Text;
            COSeries9.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            COSeries9.Clear();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            COMovies1.Text = COMovies2.Text;
            COMovies2.Text = COMovies3.Text;
            COMovies3.Text = COMovies4.Text;
            COMovies4.Text = COMovies5.Text;
            COMovies5.Text = COMovies6.Text;
            COMovies6.Text = COMovies7.Text;
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            COMovies2.Text = COMovies3.Text;
            COMovies3.Text = COMovies4.Text;
            COMovies4.Text = COMovies5.Text;
            COMovies5.Text = COMovies6.Text;
            COMovies6.Text = COMovies7.Text;
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            COMovies3.Text = COMovies4.Text;
            COMovies4.Text = COMovies5.Text;
            COMovies5.Text = COMovies6.Text;
            COMovies6.Text = COMovies7.Text;
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            COMovies4.Text = COMovies5.Text;
            COMovies5.Text = COMovies6.Text;
            COMovies6.Text = COMovies7.Text;
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            COMovies5.Text = COMovies6.Text;
            COMovies6.Text = COMovies7.Text;
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            COMovies6.Text = COMovies7.Text;
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            COMovies7.Text = COMovies8.Text;
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            COMovies8.Text = COMovies9.Text;
            COMovies9.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            COMovies9.Clear();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            COGames1.Text = COGames2.Text;
            COGames2.Text = COGames3.Text;
            COGames3.Text = COGames4.Text;
            COGames4.Text = COGames5.Text;
            COGames5.Text = COGames6.Text;
            COGames6.Text = COGames7.Text;
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            COGames2.Text = COGames3.Text;
            COGames3.Text = COGames4.Text;
            COGames4.Text = COGames5.Text;
            COGames5.Text = COGames6.Text;
            COGames6.Text = COGames7.Text;
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            COGames3.Text = COGames4.Text;
            COGames4.Text = COGames5.Text;
            COGames5.Text = COGames6.Text;
            COGames6.Text = COGames7.Text;
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            COGames4.Text = COGames5.Text;
            COGames5.Text = COGames6.Text;
            COGames6.Text = COGames7.Text;
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            COGames5.Text = COGames6.Text;
            COGames6.Text = COGames7.Text;
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            COGames6.Text = COGames7.Text;
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            COGames7.Text = COGames8.Text;
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            COGames8.Text = COGames9.Text;
            COGames9.Clear();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            COGames9.Clear();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            TDMonth1.Text = TDMonth2.Text;
            TDMonth2.Text = TDMonth3.Text;
            TDMonth3.Text = TDMonth4.Text;
            TDMonth4.Text = TDMonth5.Text;
            TDMonth5.Text = TDMonth6.Text;
            TDMonth6.Text = TDMonth7.Text;
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            TDMonth2.Text = TDMonth3.Text;
            TDMonth3.Text = TDMonth4.Text;
            TDMonth4.Text = TDMonth5.Text;
            TDMonth5.Text = TDMonth6.Text;
            TDMonth6.Text = TDMonth7.Text;
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            TDMonth3.Text = TDMonth4.Text;
            TDMonth4.Text = TDMonth5.Text;
            TDMonth5.Text = TDMonth6.Text;
            TDMonth6.Text = TDMonth7.Text;
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            TDMonth4.Text = TDMonth5.Text;
            TDMonth5.Text = TDMonth6.Text;
            TDMonth6.Text = TDMonth7.Text;
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            TDMonth5.Text = TDMonth6.Text;
            TDMonth6.Text = TDMonth7.Text;
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            TDMonth6.Text = TDMonth7.Text;
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();

        }

        private void button42_Click(object sender, EventArgs e)
        {
            TDMonth7.Text = TDMonth8.Text;
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();


        }

        private void button41_Click(object sender, EventArgs e)
        {
            TDMonth8.Text = TDMonth9.Text;
            TDMonth9.Clear();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            TDMonth9.Clear();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            TDYear1.Text = TDYear2.Text;
            TDYear2.Text = TDYear3.Text;
            TDYear3.Text = TDYear4.Text;
            TDYear4.Text = TDYear5.Text;
            TDYear5.Text = TDYear6.Text;
            TDYear6.Text = TDYear7.Text;
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            TDYear2.Text = TDYear3.Text;
            TDYear3.Text = TDYear4.Text;
            TDYear4.Text = TDYear5.Text;
            TDYear5.Text = TDYear6.Text;
            TDYear6.Text = TDYear7.Text;
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            TDYear3.Text = TDYear4.Text;
            TDYear4.Text = TDYear5.Text;
            TDYear5.Text = TDYear6.Text;
            TDYear6.Text = TDYear7.Text;
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            TDYear4.Text = TDYear5.Text;
            TDYear5.Text = TDYear6.Text;
            TDYear6.Text = TDYear7.Text;
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            TDYear5.Text = TDYear6.Text;
            TDYear6.Text = TDYear7.Text;
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();


        }

        private void button52_Click(object sender, EventArgs e)
        {
            TDYear6.Text = TDYear7.Text;
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            TDYear7.Text = TDYear8.Text;
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            TDYear8.Text = TDYear9.Text;
            TDYear9.Clear();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            TDYear9.Clear();
        }               
    }
}
