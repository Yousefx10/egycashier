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

            

        }





        void LoadData(int proC)
        {
            flowLayoutPanel1.Visible = true;
            if(proC==0)
            {

            }
            else if (proC == 1)
            {

                string filePATH = @"C:\EgyCashier\guest\operations\";

                //string[] text1 = File.ReadAllLines(filePATH + "data.bill");

                DirectoryInfo d = new DirectoryInfo(filePATH);

                foreach (var file in d.GetFiles("*.op"))
                {

                    LinkLabel LinLabelDay = new LinkLabel();
                    LinLabelDay.Text = file.Name.Remove(file.Name.Length - 3);
                    LinLabelDay.Tag = file.FullName;

                    LinLabelDay.AutoSize = true;
                    LinLabelDay.Click += LinLabelDay_Click;

                    flowLayoutPanel1.Controls.Add(LinLabelDay);


                }

            }

        }

        private void LinLabelDay_Click(object sender, EventArgs e)
        {

            LinkLabel bbb = sender as LinkLabel;

            CurrentFile = bbb.Tag.ToString();
            currentDate = bbb.Text;
            string[] Dafileaa = File.ReadAllLines(CurrentFile);

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 250 + (Dafileaa.Length * 40));


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;


            LinkLabel bbb = sender as LinkLabel;

            // CurrentFile = bbb.Tag.ToString();
            // currentDate = bbb.Text;
            // string[] Dafileaa = File.ReadAllLines(CurrentFile);
            string path = @"C:\EgyCashier\guest\operations\";

            DirectoryInfo d = new DirectoryInfo(path);
            int HOwmany = 0;
            int HOwmany2 = 0;
            foreach (var file in d.GetFiles("*.op"))
            {
                HOwmany++;
                string[] Dafileaa = File.ReadAllLines(file.FullName);
                HOwmany2 += Dafileaa.Length;

            }
            printDocument2.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 600 + ((HOwmany2*35) + HOwmany * 100));
         //   printDocument2.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 2500);
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();







        }

        string CurrentFile;
        string currentDate;






        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //the folder path
         //   string path = @"C:\EgyCashier\guest\general\";
           // MessageBox.Show(CurrentFile);

            //read everything in that file to string[]


            //test int for current line
           // int currentLINE = 0;




            // MessageBox.Show(Dafile.Length.ToString());
            int LineLocation = 0;
            e.Graphics.DrawString("Report For " + currentDate, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, 20));

            string[] Dafile = File.ReadAllLines(CurrentFile);

           // printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 600 + (LineLocation * 40));

            for (int i = 0; i < Dafile.Length; i++)
            {
                
                string[] MyTokens = Dafile[i].Split(',');
                if (MyTokens[0] == "Head")
                {
                   // currentLINE++;
                    LineLocation += 70;
                    //int to write how many lines in header.
                    int III;
                    Int32.TryParse(MyTokens[1], out III);
                    e.Graphics.DrawString("At " + MyTokens[2] + " We Sale :", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(100, LineLocation + 60));


                    string vatEH = "On Your Company";
                    if (MyTokens[3] == "1") vatEH = "On Customer";
                    e.Graphics.DrawString("Vat Is: [" + vatEH + "] - Vat Rate is : [" + MyTokens[4]+" % ]", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(150, LineLocation + 120));
                    LineLocation += 60;
                    for (int ii = 0; ii < III; ii++)
                    {
                        
                        string[] ShowItems = Dafile[ii + 1].Split(',');

                      

                        
                        e.Graphics.DrawString("item name : [" + ShowItems[0] + " ] item price: [" + ShowItems[1] + "] Quantity ["+ ShowItems[2]+ "] & MenuName :[ "  + ShowItems[3]+" ]", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(80, LineLocation + 100));
                        LineLocation += 25;


                    }
                }
               // else { }

            }
            

            //    DirectoryInfo d = new DirectoryInfo(path);









        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            string path = @"C:\EgyCashier\guest\operations\";

            DirectoryInfo d = new DirectoryInfo(path);
            int LineLocation = 0;
            foreach (var file in d.GetFiles("*.op"))
            {




                string[] Dafile = File.ReadAllLines(file.FullName);
                

                    
                    e.Graphics.DrawString("Report For " + file.Name.Remove(file.Name.Length - 3), new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, LineLocation+20));

                    for (int i = 0; i < Dafile.Length; i++)
                    {

                        string[] MyTokens = Dafile[i].Split(',');
                        if (MyTokens[0] == "Head")
                        {
                            // currentLINE++;
                            LineLocation += 70;
                            //int to write how many lines in header.
                            int III;
                            Int32.TryParse(MyTokens[1], out III);
                            e.Graphics.DrawString("At " + MyTokens[2] + " We Sale :", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(100, LineLocation + 60));


                            string vatEH = "On Your Company";
                            if (MyTokens[3] == "1") vatEH = "On Customer";
                            e.Graphics.DrawString("Vat Is: [" + vatEH + "] - Vat Rate is : [" + MyTokens[4] + " % ]", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(150, LineLocation + 120));
                            LineLocation += 60;
                            for (int ii = 0; ii < III; ii++)
                            {

                                string[] ShowItems = Dafile[ii + 1].Split(',');




                                e.Graphics.DrawString("item name : [" + ShowItems[0] + " ] item price: [" + ShowItems[1] + "] Quantity [" + ShowItems[2] + "] & MenuName :[ " + ShowItems[3] + " ]", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(80, LineLocation + 100));
                                LineLocation += 25;


                            }
                        }





                }
                  LineLocation += 50;
                  e.Graphics.DrawString("__________________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, LineLocation + 100));
                  LineLocation += 50;




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData(1);

        }
    }
}
