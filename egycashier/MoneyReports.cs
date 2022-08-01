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
    public partial class MoneyReports : Form
    {
        private static MoneyReports _instance;

        public MoneyReports(int whatT)
        {
            InitializeComponent();
            _instance = this;
            loK(whatT);
        }




        string ok_temp;
        void loK(int Ab)
        {




            string path = @"C:\EgyCashier\guest\money\";

            DirectoryInfo d = new DirectoryInfo(path);
            /*   int SUM_OUT_in = 0;
               int SUM_OUT_out = 0;*/


            Label lbl5 = new Label();
            lbl5.Font = new Font("Arial", 11, FontStyle.Bold);

            lbl5.Text = "-------------" + "\n" + "All Credit Transactions :";
            lbl5.ForeColor = Color.BlueViolet;
            lbl5.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl5);

            foreach (var file in d.GetFiles("*.mx"))
            {
                Label lbl = new Label();
                lbl.Font = new Font("Arial", 15,FontStyle.Bold);
                lbl.Text = "On :" + file;
                lbl.Text = lbl.Text.Substring(0, lbl.Text.Length - 3);
                lbl.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl);

                string[] Dafile = File.ReadAllLines(file.FullName);
                foreach (string Da in Dafile)
                {
                    int inDEX = Da.IndexOf(",");
                    if (inDEX >= 0)
                        ok_temp = Da.Substring(0, inDEX);

                    Label lbl2 = new Label();
                    lbl2.Text = ok_temp + " EGP Was Taken By : ";

                    inDEX = Da.IndexOf(",");
                    if (inDEX >= 0)
                        ok_temp = Da.Substring(inDEX + 1);

                    lbl2.Text += ok_temp + "\n   ";
                    lbl2.AutoSize = true;
                     flowLayoutPanel1.Controls.Add(lbl2);


                }

                Label lbl3 = new Label();

                lbl3.Text = "---------------------------------";
                lbl3.ForeColor = Color.Teal;
                lbl3.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl3);

            }
            Label lbl4 = new Label();
            lbl4.Font = new Font("Arial", 11, FontStyle.Bold);

            lbl4.Text = "\n\n-------------"+"\n"+ "All Transactions That Returned :";
            lbl4.ForeColor = Color.BlueViolet;
            lbl4.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lbl4);



            foreach (var file in d.GetFiles("*.mxg"))
            {
                Label lbl = new Label();
                lbl.Font = new Font("Arial", 15, FontStyle.Bold);
                lbl.Text = "On :" + file;
                lbl.Text = lbl.Text.Substring(0, lbl.Text.Length - 4);
                lbl.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl);

                string[] Dafile = File.ReadAllLines(file.FullName);
                foreach (string Da in Dafile)
                {
                    int inDEX = Da.IndexOf(",");
                    if (inDEX >= 0)
                        ok_temp = Da.Substring(0, inDEX);

                    Label lbl2 = new Label();
                    lbl2.Text = ok_temp + " EGP Was RETURNED By : ";

                    inDEX = Da.IndexOf(",");
                    if (inDEX >= 0)
                        ok_temp = Da.Substring(inDEX + 1) + "\n   ";

                    lbl2.Text += ok_temp;
                    lbl2.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(lbl2);


                }

                Label lbl3 = new Label();

                lbl3.Text = "---------------------------------";
                lbl3.ForeColor = Color.Teal;
                lbl3.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl3);

            }











        }






        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }



        public static void moveFORMnow()
        {
            Form fc = Application.OpenForms["MoneyReports"];
            if (fc != null)
            {
                _instance.Top = money.omg()[0];
                _instance.Left = money.omg()[1] + money.omg()[2];
            }
        }
        private void MoneyReports_Load(object sender, EventArgs e)
        {
            moveFORMnow();



        }
    }
}
