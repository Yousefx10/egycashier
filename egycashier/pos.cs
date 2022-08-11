using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
namespace egycashier
{
    public partial class pos : Form
    {
        private static pos _instance;

        public pos()
        {
            InitializeComponent();
            List_Life();
            _instance = this;

        }
        int NormalTotal = 0;
        int VATSystem = 0;
        int VATtotal = 0;

        static public string DELIVERYperson="";
        static public bool DELperson = false;




        public void changeDEL()
        {

            if(DELperson)
            {

                string[] MyTokens = DELIVERYperson.Split(',');
                label2.Text = MyTokens[0];
                label3.Text = MyTokens[1];
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
                //to call a method from OPENED form
                if (Application.OpenForms["Delivery"] != null)
                {
                    (Application.OpenForms["Delivery"] as Delivery).canCelit();
                }
            }
        }











        private void List_Life()

        {

            string filePATH = @"C:\EgyCashier\guest\";
            string[] text1 = File.ReadAllLines(filePATH + "list.txt");
            int iddd = Convert.ToInt32(text1[0]);
            for (int i = 0; i < iddd; i++)
            {
                string[] temp1 = File.ReadAllLines(filePATH + "fol" + i + "\\configuration.txt");

                Button MenuBTN = new Button();
                MenuBTN.Height = 40;
                MenuBTN.Width = 145;
                MenuBTN.BackColor = SystemColors.Info;
                MenuBTN.FlatStyle = FlatStyle.Flat;
                MenuBTN.Font= new Font("Arial", 14);

                MenuBTN.Text = temp1[1];
                MenuBTN.Name = "menuBtn" + i;

                MenuBTN.Tag = "fol"+ i;

                MenuBTN.Click += MenuBTN_Click;

                flowLayoutPanel4.Controls.Add(MenuBTN);

            }
            string[] text2 = File.ReadAllLines(filePATH + "configuration.txt");

            VATSystem = Convert.ToInt32(text2[2]);
         VATtotal = Convert.ToInt32(text2[3]);

            if (VATSystem == 1 || VATSystem == 2)
                LBL_VAT.Text = "With Total " + text2[3] + "% Vat :";
            else
                LBL_VAT.Text = "FREE VAT !";




        }
        string MAINMENU;
        private void MenuBTN_Click(object sender, EventArgs e)
        {
            
            Button bbb = sender as Button;
            string THEFOLDERid = bbb.Tag.ToString();
            ForeachControlsInForm(bbb.Name);


            MAINMENU = bbb.Tag.ToString().Replace("fol", "");
            if (MAINMENU.Length < 2)
                MAINMENU = "0" + MAINMENU;
             

            string filePATH = @"C:\EgyCashier\guest\" + THEFOLDERid + "\\";



            flowLayoutPanel1.Controls.Clear();
            string[] text1 = File.ReadAllLines(filePATH + "configuration.txt");
            int iddd = Convert.ToInt32(text1[0]);
            if(iddd == 0)
            {

                Label L_no_space = new Label();
                L_no_space.Font = new Font("Arial", 30);
                L_no_space.Text = "This List Is Empty";
                L_no_space.AutoSize = true;
                flowLayoutPanel1.Controls.Add(L_no_space);
            }
            else
            for (int i = 0; i < iddd; i++)
            {
                string[] temp1 = File.ReadAllLines(filePATH + "item" + i + ".txt");

                Button itemBTN = new Button();
                itemBTN.Height = 90;
                itemBTN.Width = 90;
                itemBTN.BackColor = Color.White;
                itemBTN.FlatStyle = FlatStyle.Flat;
                itemBTN.Font = new Font("Arial", 12);



                itemBTN.Text = temp1[0];
                itemBTN.Name =MAINMENU+"btnName" + i;
                    //    itemBTN.Name = "G"+THEFOLDERid.Replace("fol","")+"btnName" + i;







//itemBTN.Tag = temp1[1]; original code.
itemBTN.Tag = new { itmTAG = temp1[1], itmMENU = bbb.Text };

                    itemBTN.Click += ItemBTN_Click;


                flowLayoutPanel1.Controls.Add(itemBTN);
            }
           




        }
        object MOREtags(object obj, string propName)
        {
            return obj.GetType().GetProperty(propName).GetValue(obj, null);
        }

        void ChangeScroll(bool whatStts)
        {
            if (whatStts)
            {
                //idk why especially this numbers, but i tested it alot and i noticed this changes !
                if (flowLayoutPanel3.Height < 50)
                {
                    flowLayoutPanel3.Height = 65;
                    flowLayoutPanel2.Height = 65;
                }

                else
                {
                    flowLayoutPanel3.Height += 62;
                    flowLayoutPanel2.Height += 62;
                }
            }

            else
            {
                if (flowLayoutPanel3.Height == 65)
                {
                    flowLayoutPanel3.Height = 0;
                    flowLayoutPanel2.Height = 0;
                }

                else
                {
                    flowLayoutPanel3.Height -= 62;
                    flowLayoutPanel2.Height -= 62;
                }
            }

            //for display and hiding the VscrollBar...
            if (flowLayoutPanel3.Height > 375)
                vScrollBar1.Visible = true;
            else
                vScrollBar1.Visible = false;

            vScrollBar1.Maximum = panel3.VerticalScroll.Maximum;

            //the secret is here, because the default AutoScroll Change this alot.
            vScrollBar1.LargeChange = panel3.VerticalScroll.LargeChange;
            vScrollBar1.SmallChange = panel3.VerticalScroll.SmallChange;


            vScrollBar1.Value = panel3.VerticalScroll.Value;
        }
        private void ItemBTN_Click(object sender, EventArgs e)
        {


            Button btn = sender as Button;




            Random rnd = new Random();
            int R1 = rnd.Next(10, 99);
            int R2 = rnd.Next(10, 20);
            int R3 = rnd.Next(10, 40);
            string R4 = "" + R1 + R2 + R3;


            string mynamedLABEL ="";
 
            mynamedLABEL =   btn.Name;
          //  MessageBox.Show(mynamedLABEL);

                foreach (Control contr in flowLayoutPanel2.Controls)
                {
                    if (contr.Name.Contains(mynamedLABEL))
                    {
                    Label InstanceOfplus = new Label();
                   InstanceOfplus.Name = contr.Name.Replace("L1", "X2");
                    InstanceOfplus.Tag = MOREtags(btn.Tag, "itmTAG") ;
                   // MessageBox.Show(InstanceOfplus.Name);


                    Lbl_plus_Click(InstanceOfplus, e);




                    //break;
                    return;
                    }
            }

            /*

            zz_labelNAME_zz.Tag = new { Yname = MOREtags(zz_labelNAME_zz.Tag, "Yname").ToString(), Yprice = MOREtags(zz_labelNAME_zz.Tag, "Yprice").ToString(), Ycount = NnumN };
   
            MessageBox.Show(MOREtags(zz_labelNAME_zz.Tag, "Ycount").ToString() + "peice ... > " + MOREtags(zz_labelNAME_zz.Tag, "Yprice").ToString()+"$ ... and item"+ MOREtags(zz_labelNAME_zz.Tag, "Yname"));

            */

            Label label_item_name = new Label();
            label_item_name.ForeColor = Color.White;
            label_item_name.Text = btn.Text;
            label_item_name.Width = 120;
            label_item_name.Name = "L1" + btn.Name + R4;
            label_item_name.Font = new Font("Arial", 18);

 
            label_item_name.Tag = new { YmenuName = MOREtags(btn.Tag, "itmMENU") , Yname = btn.Name.Replace("btnName",""), Yprice = MOREtags(btn.Tag, "itmTAG") , Ycount =1 , Yitem = btn.Text };



            Label label_delete = new Label();
            label_delete.ForeColor = Color.Red;
            label_delete.Text = "Delete";
            label_delete.Width = 55;
            label_delete.Name = "L2" + btn.Name + R4;


            Label label_price = new Label();
            label_price.ForeColor = Color.Teal;
            label_price.Text = MOREtags(btn.Tag, "itmTAG") +" EGP";
            label_price.Width = 60;
            label_price.Height = 28;
            label_price.Name = "L3" + btn.Name + R4;
            label_price.Font = new Font("Arial", 18);

            PictureBox picc = new PictureBox();
            picc.Width = 130;
            picc.Height = 5;
            picc.BorderStyle = BorderStyle.Fixed3D;
            picc.Name = "L4" + btn.Name + R4;

            PictureBox picc2 = new PictureBox();
            picc2.Width = 130;
            picc2.Height =5;
            picc2.BorderStyle = BorderStyle.Fixed3D;
            picc2.Name = "L5" + btn.Name + R4;



            Label lbl_minus = new Label();
            lbl_minus.ForeColor = SystemColors.GradientInactiveCaption;
            lbl_minus.Text = "X";
            lbl_minus.Width = 40;
            lbl_minus.Name = "X1" + btn.Name + R4;
            lbl_minus.Font = new Font("Arial", 15);
            lbl_minus.AutoSize = true;
            lbl_minus.BorderStyle = BorderStyle.FixedSingle;
            //price in tag decrease the price when clicking on it
            lbl_minus.Tag = MOREtags(btn.Tag, "itmTAG");


            Label lbl_count = new Label();
            lbl_count.ForeColor = SystemColors.Highlight;
            lbl_count.Text = "1";
            lbl_count.Width = 40;
            lbl_count.Name = "X2" + btn.Name + R4;
            lbl_count.AutoSize = true;
            lbl_count.Font = new Font("Arial", 11);
           // MessageBox.Show(lbl_count.Name);


            Label lbl_plus = new Label();
            lbl_plus.ForeColor = SystemColors.GradientInactiveCaption;
            lbl_plus.Text = "+";
            lbl_plus.Width = 40;
            lbl_plus.Name = "X3" + btn.Name + R4;
            lbl_plus.Font = new Font("Arial", 17);
            lbl_plus.AutoSize = true;
            lbl_plus.BorderStyle = BorderStyle.FixedSingle;
            //price in tag increasing the price when clicking on it
            lbl_plus.Tag= MOREtags(btn.Tag, "itmTAG");




            flowLayoutPanel2.Controls.Add(label_item_name);

            flowLayoutPanel2.Controls.Add(label_price);





            flowLayoutPanel3.Controls.Add(lbl_minus);
            flowLayoutPanel3.Controls.Add(lbl_count);
            flowLayoutPanel3.Controls.Add(lbl_plus);

            flowLayoutPanel3.Controls.Add(label_delete);

            flowLayoutPanel2.Controls.Add(picc);
            flowLayoutPanel3.Controls.Add(picc2);

            label_delete.Click += label_delete_Click;
            flowLayoutPanel3.HorizontalScroll.Visible = false;



            lbl_minus.Click += Lbl_minus_Click;
            lbl_plus.Click += Lbl_plus_Click;


            NormalTotal += Convert.ToInt32(MOREtags(btn.Tag, "itmTAG"));


             double theVat = 0;

             theVat = (double)VATtotal / 100;
             theVat *= NormalTotal;

             LBL_AMOUNT_VAT.Text = theVat + "EGP";

             if (VATSystem == 0 || VATSystem == 1)
                LBL_AMOUNT.Text = NormalTotal + " EGP";
             else if (VATSystem == 2)
             {
                LBL_AMOUNT.Text = (NormalTotal + theVat) + " EGP";
                 LBL_ADDITIONAL_VAT.Text = "+" + NormalTotal;
             }









            ChangeScroll(true);

        }

        private void Lbl_plus_Click(object sender, EventArgs e)
        {

            Label LL_delete = sender as Label;

            string THER = LL_delete.Name;
            

            THER = THER.Substring(THER.Length - 6);

           
            string testtt = "";
            testtt = "X2" + LL_delete.Name.Remove(0, 2);

            //MessageBox.Show(testtt);
            char A1 = testtt[2];
            char A2 = testtt[3];

       //   if (A1 == MAINMENU[0] && A2 == MAINMENU[1])
         //   testtt.Replace(MAINMENU + MAINMENU, MAINMENU);


            testtt = testtt.Remove(testtt.Length - 6);
            Label zz_label_count = (Label)flowLayoutPanel3.Controls[testtt + THER];

            int NnumN = int.Parse(zz_label_count.Text)+1;
            zz_label_count.Text = NnumN.ToString();



            NormalTotal += Convert.ToInt32(LL_delete.Tag);

            double theVat = 0;

            theVat = (double)VATtotal / 100;
            theVat *= NormalTotal;

            LBL_AMOUNT_VAT.Text = theVat + "EGP";

            if (VATSystem == 0 || VATSystem == 1)
                LBL_AMOUNT.Text = NormalTotal + " EGP";
            else if (VATSystem == 2)
            {
                LBL_AMOUNT.Text = (NormalTotal + theVat) + " EGP";
                LBL_ADDITIONAL_VAT.Text = "+" + NormalTotal;
            }





            string mynamedLABEL;

            mynamedLABEL = LL_delete.Name.Substring(LL_delete.Name.Length - 7);





            Label zz_labelNAME_zz = (Label)flowLayoutPanel2.Controls["L1"+ A1+A2+"btnName" + mynamedLABEL];

            zz_labelNAME_zz.Tag = new { YmenuName = MOREtags(zz_labelNAME_zz.Tag, "YmenuName").ToString(), Yname = MOREtags(zz_labelNAME_zz.Tag, "Yname").ToString(), Yprice = MOREtags(zz_labelNAME_zz.Tag, "Yprice").ToString(), Ycount = NnumN , Yitem = MOREtags(zz_labelNAME_zz.Tag, "Yitem").ToString() };
   
          //  MessageBox.Show(MOREtags(zz_labelNAME_zz.Tag, "Ycount").ToString() + "peice ... > " + MOREtags(zz_labelNAME_zz.Tag, "Yprice").ToString()+"$ ... and item"+ MOREtags(zz_labelNAME_zz.Tag, "Yname"));

        }

        private void Lbl_minus_Click(object sender, EventArgs e)
        {
            Label LL_delete = sender as Label;

            string THER = LL_delete.Name;
            THER = THER.Substring(THER.Length - 6);

            string testtt = "";

            testtt = "X2" + LL_delete.Name.Remove(0, 2);

            char A1 = testtt[2];
            char A2 = testtt[3];
            //MessageBox.Show(testtt);
      //      if (A1 == MAINMENU[0] && A2 == MAINMENU[1]) MessageBox.Show("wrong");
              //  testtt.Replace(MAINMENU+ MAINMENU, MAINMENU);



        testtt = testtt.Remove(testtt.Length - 6);

            Label zz_label_count = (Label)flowLayoutPanel3.Controls[testtt + THER];
             int NnumN = int.Parse(zz_label_count.Text) - 1;
            if (NnumN > 0)
            {
                zz_label_count.Text = NnumN.ToString();



                NormalTotal -= Convert.ToInt32(LL_delete.Tag);

                double theVat = 0;

                theVat = (double)VATtotal / 100;
                theVat *= NormalTotal;

                LBL_AMOUNT_VAT.Text = theVat + "EGP";

                if (VATSystem == 0 || VATSystem == 1)
                    LBL_AMOUNT.Text = NormalTotal + " EGP";
                else if (VATSystem == 2)
                {
                    LBL_AMOUNT.Text = (NormalTotal + theVat) + " EGP";
                    LBL_ADDITIONAL_VAT.Text = "+" + NormalTotal;
                }
            }









            string mynamedLABEL;

            mynamedLABEL = LL_delete.Name.Substring(LL_delete.Name.Length - 7);

            string Forlabel = "L1" + A1 + A2 + "btnName" + mynamedLABEL;
 
           // MessageBox.Show(Forlabel);
            Label zz_labelNAME_zz = (Label)flowLayoutPanel2.Controls[Forlabel];

            zz_labelNAME_zz.Tag = new {YmenuName= MOREtags(zz_labelNAME_zz.Tag, "YmenuName"), Yname = MOREtags(zz_labelNAME_zz.Tag, "Yname").ToString(), Yprice = MOREtags(zz_labelNAME_zz.Tag, "Yprice").ToString(), Ycount = NnumN , Yitem = MOREtags(zz_labelNAME_zz.Tag, "Yitem").ToString() };

        }






        //For Styling Menu With Colors....
        public void ForeachControlsInForm(string contName)
        {
            
            foreach (Control contr in flowLayoutPanel4.Controls)
            {
                contr.BackColor = SystemColors.Info;
                contr.ForeColor = Color.Black;

                if (contr.Name == contName)
                {
                      contr.BackColor = SystemColors.MenuHighlight;
                       contr.ForeColor = Color.White;
                }
            }
            
        }




        private void label_delete_Click(object sender, EventArgs e)
        {

            Label LL_delete = sender as Label;

            string THER = LL_delete.Name;
            THER = THER.Substring(THER.Length - 6);

            string testtt = "";


            testtt = "L1" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            Label zz_label_name = (Label)flowLayoutPanel2.Controls[testtt + THER];

            testtt = "L3" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            Label zz_label_price = (Label)flowLayoutPanel2.Controls[testtt + THER];


            testtt = "L4" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            PictureBox zz_picture_border = (PictureBox)flowLayoutPanel2.Controls[testtt + THER];

            testtt = "L5" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            PictureBox zz_picture_border2 = (PictureBox)flowLayoutPanel3.Controls[testtt + THER];


            testtt = "X1" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            Label zz_label_minus = (Label)flowLayoutPanel3.Controls[testtt + THER];

            testtt = "X2" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            Label zz_label_count = (Label)flowLayoutPanel3.Controls[testtt + THER];

            testtt = "X3" + LL_delete.Name.Remove(0, 2);
            testtt = testtt.Remove(testtt.Length - 6);
            Label zz_label_plus = (Label)flowLayoutPanel3.Controls[testtt + THER];



            flowLayoutPanel2.Controls.Remove(zz_label_name);
            flowLayoutPanel2.Controls.Remove(zz_label_price);

            flowLayoutPanel2.Controls.Remove(zz_picture_border);
            flowLayoutPanel3.Controls.Remove(zz_picture_border2);


            flowLayoutPanel3.Controls.Remove(LL_delete);

            flowLayoutPanel3.Controls.Remove(zz_label_minus);
            flowLayoutPanel3.Controls.Remove(zz_label_count);
            flowLayoutPanel3.Controls.Remove(zz_label_plus);



            

            int tempNUM = Convert.ToInt32(zz_label_price.Text.Remove(zz_label_price.Text.Length - 3));
             tempNUM *= Convert.ToInt32(zz_label_count.Text);
            NormalTotal -= tempNUM;

            double theVat = 0;

            theVat = (double)VATtotal / 100;
            theVat *= NormalTotal;

            LBL_AMOUNT_VAT.Text = theVat + "EGP";

            if (VATSystem == 0 || VATSystem == 1)
                LBL_AMOUNT.Text = NormalTotal + " EGP";
            else if (VATSystem == 2)
            {
                LBL_AMOUNT.Text = (NormalTotal + theVat) + " EGP";
                LBL_ADDITIONAL_VAT.Text = "+" + NormalTotal;

            }
            ChangeScroll(false);

        }




        private void pos_Load(object sender, EventArgs e)
        {
            panel3.MouseWheel += Panel3_MouseWheel;
            panel4.MouseWheel += Panel4_MouseWheel;


            //i read that this should stop the lag , when scrolling , but nah.
            //DoubleBuffered = true;


        }

        private void Panel4_MouseWheel(object sender, MouseEventArgs e)
        {
            panel3.VerticalScroll.Value = panel4.VerticalScroll.Value;
            vScrollBar1.Value = panel4.VerticalScroll.Value;
        }

        private void Panel3_MouseWheel(object sender, MouseEventArgs e)
        {
            panel4.VerticalScroll.Value = panel3.VerticalScroll.Value;
            vScrollBar1.Value = panel3.VerticalScroll.Value;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSource.RawKind = 1;

            string path = @"C:\EgyCashier\guest\operations\";

            string date = DateTime.Now.ToString("MM-dd-yyyy");
            DirectoryInfo d = new DirectoryInfo(path);
            string readText = "";

            
            if(!File.Exists(path + date + ".op"))
            File.Create(path + date + ".op").Dispose();

            readText= File.ReadAllText(path + date + ".op");
            if (readText != "")
                readText += "\n";

            int Daloop = 0;
            string FullProcc="";
            string timeNOW = DateTime.Now.ToString("h:mm:ss tt");
            int PAPrSize = 0;
            foreach (Control contr in flowLayoutPanel2.Controls)
            {
                if (contr is Label )
                {
                    if(Daloop == 0)
                    {
                        PAPrSize++;
                        //string N = "\n";

                        FullProcc +=
                           // MOREtags(contr.Tag, "Yname").ToString() +"---"+N+ //THIS FOR ITEM ID ON MENU ID, no need more.

                           MOREtags(contr.Tag, "Yitem") + "," +
                           MOREtags(contr.Tag, "Yprice") + "," +
                           MOREtags(contr.Tag, "Ycount") + "," +

                           MOREtags(contr.Tag, "YmenuName");

                        ;


                    Daloop++;
                        FullProcc += "\n";
                    }
                    else
                    Daloop--;
                }




            }
            int personSTATS = 0;
            if (DELperson)
            {
                personSTATS++;
                FullProcc = "Head," + PAPrSize + "," + timeNOW + "," + VATSystem + "," + VATtotal + "," + personSTATS + "\n" + FullProcc + DELIVERYperson+"\n";
            }
            else
            FullProcc = "Head," + PAPrSize + "," + timeNOW + "," + VATSystem + "," + VATtotal + "," + personSTATS + "\n" + FullProcc;

            File.WriteAllText(path + date + ".op", readText+FullProcc);







            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 850, 870 + (PAPrSize * 40));

            //The Random Number Will Use For Barcode.
            // MessageBox.Show(RandomString(4));

            BarcodeWriter NewBarcode = new BarcodeWriter() { 
                Format = BarcodeFormat.UPC_A, 
                Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 90
            } };

            pic_BARCODE.Image = NewBarcode.Write(RandomString(4)+ RandomString(4)+ RandomString(3));




            PrintMe(panel2);

        }
        PictureBox pic_BARCODE = new PictureBox();


        private static Random random = new Random();
        public static string RandomString(int length)
        {
          //const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }




        private void PrintMe(Panel pnl)
        {


            printPreviewDialog1.Document = printDocument1;
            ToolStripButton b = new ToolStripButton();
            b.Image = Properties.Resources.save;
            b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            b.Click += B_Click;
            ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.RemoveAt(0);
            ((ToolStrip)(printPreviewDialog1.Controls[1])).Items.Insert(0, b);
            printPreviewDialog1.ShowDialog();


           // printPreviewDialog1.Document = printDocument1;
         //   printPreviewDialog1.ShowDialog();



        }

        private void B_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ToString());
            }

        }








        private Bitmap memoryimg;
        void getPrintArea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);

            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

           //MessageBox.Show(printDocument1.DefaultPageSettings.Bounds.ToString());
          //  printDocument1.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 200, 200);

            string filePATH = @"C:\EgyCashier\guest\general\";
            string[] text1 = File.ReadAllLines(filePATH + "data.bill");




           


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
                 e.Graphics.DrawImage(img1,270,200,250,100 );
                IMGLOCATION += 100;
            }




            e.Graphics.DrawString("______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, IMGLOCATION));

            e.Graphics.DrawString("QTY", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, IMGLOCATION+40));
            e.Graphics.DrawString("Description", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, IMGLOCATION + 40));
            e.Graphics.DrawString("Amount", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, IMGLOCATION + 40));
            e.Graphics.DrawString("______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, IMGLOCATION + 50));
            int Daloop = 0;
            int TALL = IMGLOCATION + 50;
            foreach (Control contr in flowLayoutPanel2.Controls)
            {
                if (contr is Label)
                {
                    if (Daloop == 0)
                    {

                        //
                        e.Graphics.DrawString(MOREtags(contr.Tag, "Ycount").ToString(),
                            new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(60, TALL + 50));
                        e.Graphics.DrawString(MOREtags(contr.Tag, "Yitem").ToString(),
                            new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, TALL + 50));
                        e.Graphics.DrawString(MOREtags(contr.Tag, "Yprice").ToString(),
                            new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, TALL + 50));
                        //
                        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------",
                            new Font("Arial", 15, FontStyle.Italic), Brushes.DarkGray, new Point(1, TALL + 65));

                        TALL += 50;
                        Daloop++;
 
                    }
                    else
                        Daloop--;
                }


            }

            e.Graphics.DrawString("------------------------------------------------------------------------", 
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 40));


            if(VATSystem == 1) {}else{}

            e.Graphics.DrawString("The SubTotal Is : " + NormalTotal + " EGP",
                new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, TALL + 70));

            e.Graphics.DrawString("Vat Amount :( " + LBL_AMOUNT_VAT.Text + " ) EGP",
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




            if(DELperson)
            {
                string[] ShowItemsA = DELIVERYperson.Split(',');

                e.Graphics.DrawString("This Bill Is For : " + ShowItemsA[0],
                    new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, TALL + 310));

                e.Graphics.DrawString("Customer's Address : \n" + ShowItemsA[2]+ " - [phone number]"+ShowItemsA[3],
                    new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, TALL + 335));

            }


            e.Graphics.DrawString(text1[4], new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 400));
            e.Graphics.DrawString(text1[5], new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, TALL + 435));





            Image Bar_img = pic_BARCODE.Image;
            // Point loc = new Point(350, 200);
            //The img, location (290,200) for example , the size , width and height
         //   e.Graphics.DrawImage(Bar_img, 150, TALL + 480, Bar_img.Width, Bar_img.Height);
            e.Graphics.DrawImage(Bar_img,280,TALL+480,Bar_img.Width,Bar_img.Height);
            





            DELperson = false;
            changeDEL();

            //here to clear, why in print document ? beacuse i can't print before showing current data
            clearEND();






        }
        //this void simple is just for clear everything and start nwe sale.
       private void clearEND()
        {
            flowLayoutPanel2.Controls.Clear();

            flowLayoutPanel3.Controls.Clear();
            NormalTotal = 0;

            double theVat = 0;

            theVat = (double)VATtotal / 100;
            theVat *= NormalTotal;

            LBL_AMOUNT_VAT.Text = theVat + "EGP";

            if (VATSystem == 0 || VATSystem == 1)
                LBL_AMOUNT.Text = NormalTotal + " EGP";
            else if (VATSystem == 2)
            {
                LBL_AMOUNT.Text = (NormalTotal + theVat) + " EGP";
                LBL_ADDITIONAL_VAT.Text = "+" + NormalTotal;

            }
            ChangeScroll(false);
        }




        //this is moving the delivery form.
        public static int[] omg()
        {
            Form fc = Application.OpenForms["pos"];
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
        private void pos_Move(object sender, EventArgs e)
        {
            Delivery.moveFORMnow();
        }

        private void pos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fc = Application.OpenForms["Delivery"];
            if (fc != null)
                Application.OpenForms["Delivery"].Close();

            DELperson = false;
            changeDEL();
        }



        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel3.VerticalScroll.Value = e.NewValue;
            panel4.VerticalScroll.Value = e.NewValue;
        }

        private void btn_remove_note_Click(object sender, EventArgs e)
        {
            DELperson = false;
            changeDEL();



        }
    }
}
