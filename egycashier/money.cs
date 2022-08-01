using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egycashier
{
    public partial class money : Form
    {
        private static money _instance;

        public money()
        {
            InitializeComponent(); 
            _instance = this;

        }

        string ok_temp;
        void FriSH()
        {


            string path = @"C:\EgyCashier\guest\money\";

            DirectoryInfo d = new DirectoryInfo(path);
            int SUM_OUT_in=0;
            int SUM_OUT_out=0;
            
            foreach (var file in d.GetFiles("*.mx"))
            {
                string[] Dafile = File.ReadAllLines(file.FullName);
                foreach(string Da in Dafile)
                {
                    int inDEX = Da.IndexOf(",");
                    if (inDEX >= 0)
                     ok_temp= Da.Substring(0, inDEX);
                    SUM_OUT_in += Int32.Parse(ok_temp);

                }
            }
            lbl_mny_out.Text = SUM_OUT_in + ".00 EGP";


            
            foreach (var file in d.GetFiles("*.mxg"))
            {
                string[] Dafile = File.ReadAllLines(file.FullName);
                foreach (string Da in Dafile)
                {
                    int inDEX = Da.IndexOf(",");
                    if (inDEX >= 0)
                        ok_temp = Da.Substring(0, inDEX);
                    SUM_OUT_out += Int32.Parse(ok_temp);

                }
            }
            lbl_mny_in.Text = SUM_OUT_out + ".00 EGP";



            label4.Text = "Still : "+(SUM_OUT_in - SUM_OUT_out)+" EGP Left..";





        }
        private void money_Load(object sender, EventArgs e)
        {
            FriSH();

            label6.Text= "This Statics is By:"+DateTime.Now.ToString("MM-dd-yyyy");
        }

        public static int Amount_toProc;
        private void button1_Click(object sender, EventArgs e)
        {
            moneySET sese = new moneySET(1);
            sese.ShowDialog();
            if (Amount_toProc > 0)
            {

                string path = @"C:\EgyCashier\guest\money\";

                string date = DateTime.Now.ToString("MM-dd-yyyy");


                if (File.Exists(path + date + ".mx"))
                {
                    // MessageBox.Show("it's okay");

                }
                else
                {
                    //MessageBox.Show("it's FALSEEEEEE");
                    File.Create(path + date + ".mx").Dispose();
                }


                DirectoryInfo d = new DirectoryInfo(path);
                /*
                foreach (var file in d.GetFiles("*.mx"))
                {
                    MessageBox.Show(file.FullName);
                }
                */

                string readText = File.ReadAllText(path + date + ".mx");



                if (readText != "")
                    readText += "\n";
                // MessageBox.Show(readText);



                // File.WriteAllText(path + date + ".mx", readText);


                File.WriteAllText(path + date + ".mx", readText + Amount_toProc + "," + linkLabel1.Text);
                Amount_toProc = 0;
                FriSH();
            }
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string path = @"C:\EgyCashier\guest\money\";

            string date = DateTime.UtcNow.ToString("dd-M-yyyy");


            DirectoryInfo d = new DirectoryInfo(path);
            int loc=0;
            foreach (var file in d.GetFiles("*.m"))
            {
              //  MessageBox.Show(file.FullName);
                string readText = File.ReadAllText(file.FullName);
                e.Graphics.DrawString(readText, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(250, loc));
                e.Graphics.DrawString("___________________________", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, loc+100));
                loc += 160;
            }


      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moneySET sese = new moneySET(2);
            sese.ShowDialog();
            if(Amount_toProc>0)
            {


            string path = @"C:\EgyCashier\guest\money\";

            string date = DateTime.Now.ToString("MM-dd-yyyy");



            if (File.Exists(path + date + ".mxg"))
            {
                // MessageBox.Show("it's okay");

            }
            else
            {
                //MessageBox.Show("it's FALSEEEEEE");
                File.Create(path + date + ".mxg").Dispose();
            }


            DirectoryInfo d = new DirectoryInfo(path);
            /*
            foreach (var file in d.GetFiles("*.mxg"))
            {
                MessageBox.Show(file.FullName);
            }
            */

            string readText = File.ReadAllText(path + date + ".mxg");



            if (readText != "")
                readText += "\n";




            File.WriteAllText(path + date + ".mxg", readText + Amount_toProc + "," + linkLabel1.Text);

            Amount_toProc = 0;
            FriSH();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel_history.Visible) panel_history.Visible = false;
            else                       panel_history.Visible=true;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("coming soon , Currently use [All Time]");
/*
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
*/
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("coming soon , Currently use [All Time]");

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("coming soon , Currently use [All Time]");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoneyReports monR = new MoneyReports(1);
            monR.Show();
        }

        public static int[] omg()
        {
            Form fc = Application.OpenForms["money"];
            int[] wyj = new int[3];

            if (fc != null)
            {

                wyj[0] = 0;
                wyj[0] = _instance.Top;
                wyj[1] = _instance.Left;
                wyj[2] = _instance.Width;

            }
            return wyj;


        }

        private void money_Move(object sender, EventArgs e)
        {
            MoneyReports.moveFORMnow();
        }

        private void money_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fc = Application.OpenForms["MoneyReports"];
            if (fc != null)
                Application.OpenForms["MoneyReports"].Close();
        }
    }
}
