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
using ZXing;
namespace egycashier
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }
        string correctBAR;
        int PPRsize=0;
        private void btn_go_Click(object sender, EventArgs e)
        {
            
            if(textBox1.TextLength==15 && (textBox1.Text[0]=='0' || textBox1.Text[0] == '1'))
            {
                correctBAR = textBox1.Text;
                label1.Text = correctBAR;

                textBox1.Clear();










                printPreviewControl2.Document = printDocument1;
                printPreviewControl2.Show();








                label1.Visible = true;
            }

            textBox1.Focus();
        }








        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {



            string filePATH = @"C:\EgyCashier\guest\operations\";
            string[] text1 = File.ReadAllLines(@"C:\EgyCashier\guest\general\" + "data.bill");


            




            e.Graphics.DrawString(text1[0], new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, 0));

            e.Graphics.DrawString(text1[1], new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString(text1[2], new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 100));
            e.Graphics.DrawString(text1[3], new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 150));
            //   e.Graphics.DrawString("information #4", new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 200));
            int IMGLOCATION = 200;
            if (text1[6] == "1")
            {
                Image img1 = Image.FromFile(filePATH + "logo.jpg");
                // Point loc = new Point(350, 200);
                //The img, location (290,200) for example , the size , width and height
                e.Graphics.DrawImage(img1, 270, 200, 250, 100);
                IMGLOCATION += 100;
            }




            e.Graphics.DrawString("______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, IMGLOCATION));

            e.Graphics.DrawString("QTY", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, IMGLOCATION + 40));
            e.Graphics.DrawString("Description", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, IMGLOCATION + 40));
            e.Graphics.DrawString("Amount", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, IMGLOCATION + 40));
            e.Graphics.DrawString("______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, IMGLOCATION + 50));

            int TALL = IMGLOCATION + 50;



            DirectoryInfo d = new DirectoryInfo(filePATH);
            foreach (var file in d.GetFiles("*"+ correctBAR.Substring(0, 2) + "-" + correctBAR.Substring(2, 2) + "*.op"))
            {

                //MessageBox.Show(file.Name);
                foreach (var line in File.ReadLines( file.FullName ).
    SkipWhile(line => !line.Contains(correctBAR)).Skip(1).TakeWhile(line => !line.Contains("Head")))
                {
                    if(line!="")
                    {
                        string[] MyTokens = line.Split(',');

                        e.Graphics.DrawString(MyTokens[2],
                            new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(60, TALL + 50));
                        e.Graphics.DrawString(MyTokens[0],
                            new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, TALL + 50));
                        e.Graphics.DrawString(MyTokens[1],
                            new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, TALL + 50));
                        //
                        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------",
                            new Font("Arial", 15, FontStyle.Italic), Brushes.DarkGray, new Point(1, TALL + 65));

                        TALL += 50;
                        PPRsize++;
                    }
                   else return; //for stop continue searching 


                }



            }


            e.Graphics.DrawString("------------------------------------------------------------------------",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 40));
            /*

            if (VATSystem == 1) { } else { }

            e.Graphics.DrawString("The SubTotal Is : " + NormalTotal + " EGP",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 70));

            e.Graphics.DrawString("Vat Amount :( " + LBL_AMOUNT_VAT.Text + " )",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 110));

            e.Graphics.DrawString("Vat Rate Is :( " + VATtotal + " % )",
                 new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 150));

            e.Graphics.DrawString("------------------------------------------------------------------------",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 190));



            e.Graphics.DrawString("______________________",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 220));

            e.Graphics.DrawString("The Total Amount Price : " + LBL_AMOUNT.Text,
                new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 250));


            e.Graphics.DrawString("______________________",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 270));




            if (DELperson)
            {
                string[] ShowItemsA = DELIVERYperson.Split(',');

                e.Graphics.DrawString("This Bill Is For : " + ShowItemsA[0],
                    new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, TALL + 310));

                e.Graphics.DrawString("Customer's Address : \n" + ShowItemsA[2] + " - [phone number]" + ShowItemsA[3],
                    new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, TALL + 335));

            }
            */

            e.Graphics.DrawString(text1[4], new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 355));
            e.Graphics.DrawString(text1[5], new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 390));


            pic_BARCODE.Image = NewBarcode.Write(correctBAR);

            Image Bar_img = pic_BARCODE.Image;
            // Point loc = new Point(350, 200);
            //The img, location (290,200) for example , the size , width and height
            //   e.Graphics.DrawImage(Bar_img, 150, TALL + 480, Bar_img.Width, Bar_img.Height);
            e.Graphics.DrawImage(Bar_img, 280, TALL + 430, Bar_img.Width, Bar_img.Height);


            //MessageBox.Show(PPRsize + " LINE : printpage");


        }

        BarcodeWriter NewBarcode = new BarcodeWriter()
        {
            Format = BarcodeFormat.CODE_128,
            Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 90
            }
        };

        PictureBox pic_BARCODE = new PictureBox();

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            printPreviewControl1.Visible = true;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 900, 600 + (PPRsize * 60));
            printPreviewControl1.Document = printDocument1;
            printPreviewControl1.Show();

           // MessageBox.Show(PPRsize + " LINE : printpage");
        }
    }
}
