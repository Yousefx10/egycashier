using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egycashier
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            string filePATH = @"C:\EgyCashier\guest\operations\";

            //string[] text1 = File.ReadAllLines(filePATH + "data.bill");

            DirectoryInfo d = new DirectoryInfo(filePATH);

            foreach (var file in d.GetFiles("*.op"))
            {

                    LinkLabel LinLabelDay = new LinkLabel();
                    LinLabelDay.Text = file.FullName.Remove(file.FullName.Length - 3);
                LinLabelDay.AutoSize = true;
                LinLabelDay.Click += LinLabelDay_Click;

                flowLayoutPanel1.Controls.Add(LinLabelDay);


            }


        }

        private void LinLabelDay_Click(object sender, EventArgs e)
        {

            LinkLabel bbb = sender as LinkLabel;

            CurrentFile = bbb.Text+".op";
            //  printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 780 + (10 * 40));

            string[] Dafileaa = File.ReadAllLines(CurrentFile);

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 250 + (Dafileaa.Length * 45));


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;

        }

        string CurrentFile;






        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //the folder path
         //   string path = @"C:\EgyCashier\guest\general\";
           // MessageBox.Show(CurrentFile);

            //read everything in that file to string[]


            //test int for current line
            int currentLINE = 0;




            // MessageBox.Show(Dafile.Length.ToString());
            int LineLocation = 0;
            e.Graphics.DrawString("Report For " + CurrentFile, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, 20));

            string[] Dafile = File.ReadAllLines(CurrentFile);

           // printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 600 + (LineLocation * 40));

            for (int i = 0; i < Dafile.Length; i++)
            {
                string[] MyTokens = Dafile[i].Split(',');
                if (MyTokens[0] == "Head")
                {
                    currentLINE++;
                    LineLocation += 100;
                    //int to write how many lines in header.
                    int III;
                    Int32.TryParse(MyTokens[1], out III);
                    e.Graphics.DrawString("On " + MyTokens[2] + "We Sale :", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(150, LineLocation + 60));
                    e.Graphics.DrawString("Vat Is:" + MyTokens[3] + "-" + MyTokens[4], new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(200, LineLocation + 120));
                    LineLocation += 60;
                    for (int ii = 0; ii < III; ii++)
                    {
                        
                        string[] ShowItems = Dafile[i+1].Split(',');

                      

                        
                        e.Graphics.DrawString("item name :" + ShowItems[0] + " -item price: " + ShowItems[1] + "Q & Menu :" + ShowItems[2] + ShowItems[3], new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, LineLocation + 100));
                        LineLocation += 25;


                    }
                }
               // else { }

            }
            

            //    DirectoryInfo d = new DirectoryInfo(path);









        }


    }
}
