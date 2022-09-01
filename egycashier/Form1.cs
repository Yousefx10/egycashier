using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egycashier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Height += 135;
            
            button1.Enabled = false;










        }











        public  void FolderManage(int W)
        {

            string folderPath = @"c:\EgyCashier\guest";

            if (W==1)
            {
                string adminUserName = Environment.UserName;
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.AddAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
            }
            else
            {
                string adminUserName = Environment.UserName;// getting your adminUserName
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds.RemoveAccessRule(fsa);
                Directory.SetAccessControl(folderPath, ds);
            }
        }







        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mf = new MainForm(); mf.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingSCREEN sn = new settingSCREEN(1);
            sn.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            e.Graphics.DrawString("Restaurant Name", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(250, 0));
           
            e.Graphics.DrawString("information #1", new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("information #2", new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 100));
            e.Graphics.DrawString("information #3", new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 150));
            e.Graphics.DrawString("information #4", new Font("Arial", 19, FontStyle.Regular), Brushes.Black, new Point(350, 200));

            e.Graphics.DrawString("______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 220));

            e.Graphics.DrawString("QTY", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 260));
            e.Graphics.DrawString("Description", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 260));
            e.Graphics.DrawString("Amount", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 260));
            e.Graphics.DrawString("______________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 270));

            e.Graphics.DrawString("2", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(60, 310));
            e.Graphics.DrawString("Great Good Fries Chicken", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 310));
            e.Graphics.DrawString("200.00", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 310));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 15, FontStyle.Italic), Brushes.DarkGray, new Point(1, 330));

            //test new pc
            //test again
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            money MMMM = new money();
            MMMM.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\EgyCashier\v.jpg";



            if (File.Exists(path))
            {
                pic_1.Image = Properties.Resources.accept;
                lbl_1.Text = "The System is working Correctly.";
                
                if (File.ReadAllText(path) == "v0.0.0.0.0")
                {
                    pic_2.Image = Properties.Resources.accept;
                    lbl_2.Text = "The Newset Version is installed.";
                    time_setup.Start();
                }
                else
                {
                    pic_2.Image = Properties.Resources.close1;
                    lbl_2.Text = "The Newset Version isn't Installed";
                    panel1.Visible = true;
                }

            }
            else
            {

                pic_1.Image =  Properties.Resources.close1;
                pic_2.Image =  Properties.Resources.close1;

                lbl_1.Text = "The System is not installed";
                lbl_2.Text = "The Newset Version isn't Installed";
                panel1.Visible = true;
            }

            DirectoryInfo di2 = Directory.CreateDirectory(@"c:\EgyCashier\guest");

            if ((di2.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
            {
                //Add Hidden flag    
               di2.Attributes |= FileAttributes.Hidden;


                //LOCK FOLDER block
                    FolderManage(1);
            }


           FolderManage(1);


        }

        private void time_setup_Tick(object sender, EventArgs e)
        {
            Hide();
            MainForm MF = new MainForm();
            MF.Show();
            time_setup.Dispose();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderManage(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                button2.Enabled = false;
               // string folderPath = @"c:\EgyCashier\guest";

                try
                {
                    FolderManage(0);

                    string filePATH = @"C:\EgyCashier\guest\";

                    DirectoryInfo di = Directory.CreateDirectory(filePATH);
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);

                    }
                    File.WriteAllText(filePATH + "configuration.txt", "0\n0\n0\n0\n0\n");
                    File.WriteAllText(filePATH + "list.txt", "0");

                    Directory.CreateDirectory(filePATH + "money");
                    Directory.CreateDirectory(filePATH + "clients");
                    Directory.CreateDirectory(filePATH + "operations");
                    Directory.CreateDirectory(filePATH + "users");
                    Directory.CreateDirectory(filePATH + "general");

                    File.WriteAllText(@"C:\EgyCashier\v.jpg", "v0.0.0.0.0");
                    File.WriteAllText(@"C:\EgyCashier\guest\general\data.bill", "information1\ninformation2\ninformation3\ninformation4\ninformation5\ninformation6\n0");

                    panel2.Visible = true;
                   

                    string Thrdate = DateTime.Now.ToString("MM-dd-yyyy");


                    File.WriteAllText(filePATH + @"users\owner.pl", "Owner\n"+textBox1.Text+"\n"+ Thrdate+"\nOwner Profile\n"+"1,1,1,1\n1,1,1,1");


                    button1.BackColor = Color.GreenYellow;
                }
                catch { MessageBox.Show("Error Setuping The System..." ); }

                pic_1.Image = Properties.Resources.accept;
                pic_2.Image = Properties.Resources.accept;

                lbl_1.Text = "The System is working Correctly.";
                lbl_1.Text = "The Newset Version is installed.";
              //  FolderManage(1);
                time_setup.Start();
            }
        }
    }
}
