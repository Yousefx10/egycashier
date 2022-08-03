using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace egycashier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        bool mov;
        int movX;
        int movY;

        private void pic_close_Click(object sender, EventArgs e)
        {

            //Application.Exit();
            //Close();
            try
            {
                Application.Exit();
            }
            catch {
                Environment.Exit(0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.ShowDialog();


            //this command will run after the dialog closes.
            //the CurntUserProp is important because it contains the lock Options data.
            CurrentUSR(mainUSR, CurntUserProp,CURRENTbool);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pos poos = new pos();
            poos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delivery Dv = new Delivery();
            pos poos = new pos();
            poos.Show();
            Dv.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
                 SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            money mon = new money();
            mon.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //settingSCREEN st = new settingSCREEN(0);
            //st.Show();
            settings Se = new settings();
            Se.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                Environment.Exit(0);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i have been clicked.");
            Program.FormX.FolderManage(2);

        }
        public static string mainUSR = "";
        public static string CurntUserProp = "";
        public static bool CURRENTbool = false;
        public void CurrentUSR(string UsER , string Propper,bool hoho)
        {
            CURRENTbool = hoho;
            if (CURRENTbool)
            {
                mainUSR = UsER;
                CurntUserProp = Propper;
                linkLabel1.Text = "Welcome " + mainUSR + " ";

                //doing the important stuff about the users.







                btnPOS.Visible = false;
                btnDELIVERY.Visible = false;

                btn_reports.Visible = false;
                Lbl_reports.Visible = false;

                btn_money.Visible = false;
                Lbl_money.Visible = false;

                btn_supplies.Visible = false;
                Lbl_supplies.Visible = false;

                btn_Settings.Visible = false;
                Lbl_settings.Visible = false;




                string[] MyTokens = CurntUserProp.Split(',');

/*
                //just for testing , displaying them all.
                string toDisplay = string.Join(Environment.NewLine, MyTokens);
                MessageBox.Show(toDisplay);

*/

                //pos
                if (MyTokens[0] == "1")
                {
                    btnPOS.Visible = true;
                    btnDELIVERY.Visible = true;
                }

                //reports
                if (MyTokens[1] == "1")
                {
                    btn_reports.Visible = true;
                    Lbl_reports.Visible = true;
                }

                //money
                if (MyTokens[2] == "1")
                {
                    btn_money.Visible = true;
                    Lbl_money.Visible = true;
                }

                //supplies
                if (MyTokens[3] == "1")
                {
                    btn_supplies.Visible = true;
                    Lbl_supplies.Visible = true;
                }


                //open settings
                int setNUM = Int32.Parse(MyTokens[4] + MyTokens[5] + MyTokens[6] + MyTokens[7]);

                if (setNUM > 0)
                {
                    btn_Settings.Visible = true;
                    Lbl_settings.Visible = true;
                }

                button3.Visible = false;
                linkLabel2.Visible = true;
                label_please.Visible = false;
            }


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUSR("Guest","0,0,0,0,0,0,0,0",true);
            button3.Visible = true;
            label_please.Visible = true;
        }
    }
}
