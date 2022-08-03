using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace egycashier
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        string CurrentUsr = "";
        string CurrentPass = "";
        string CurrentPropert = "";
        string crntFileName = "";




        bool closeSAVE=false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == CurrentPass)
            {
                Program.FormM.CurrentUSR(CurrentUsr, CurrentPropert,true);

                //Update The Sign-in Date....
                string Thrdate = DateTime.Now.ToString("MM-dd-yyyy");
                lineChanger(Thrdate,crntFileName, 3);


                closeSAVE = true;
                Close();

            }
            else
                MessageBox.Show("Wrong Password");
        }


        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }






        private void loginForm_Load(object sender, EventArgs e)
        {
            FriSH();
        }
        void FriSH()
        {


            string path = @"C:\EgyCashier\guest\users\";
            string[] owner = File.ReadAllLines(path + "owner.pl");

            Button btnOw = new Button();

            btnOw.ForeColor = Color.Black;
            btnOw.Size = new Size(80, 70);
            btnOw.Text = owner[0];
            btnOw.Tag = owner[1];


            btnOw.Click += BtnUser_Click;

            flowLayoutPanel1.Controls.Add(btnOw);


            DirectoryInfo d = new DirectoryInfo(path);


            foreach (var file in d.GetFiles("*.ppl"))
            {
                string[] Dafile = File.ReadAllLines(file.FullName);

                Button btnUser = new Button();

                btnUser.ForeColor = Color.Black;
                btnUser.Size = new Size(80, 70);
                btnUser.Text = Dafile[0];
                btnUser.Tag = new
                {
                    tg_pass = Dafile[1],
                    tg_date = Dafile[2],
                    tg_realname = Dafile[3],
                    tg_screens = Dafile[4],
                    tg_sett = Dafile[5],
                    tg_file_name = file.FullName
                };



                btnUser.Click += BtnUser_Click;

                flowLayoutPanel1.Controls.Add(btnUser);

            }



        }

        object MOREtags(object obj, string propName)
        {
            return obj.GetType().GetProperty(propName).GetValue(obj, null);
        }







        private void BtnUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("i have been clicked");
            Button BOT = sender as Button;
            CurrentUsr = BOT.Text;

            CurrentPass    = MOREtags(BOT.Tag, "tg_pass").ToString();
            CurrentPropert = MOREtags(BOT.Tag, "tg_screens").ToString()+","+ MOREtags(BOT.Tag, "tg_sett").ToString();
            crntFileName = MOREtags(BOT.Tag, "tg_file_name").ToString();

            label_User_name.Text = CurrentUsr;
            label_User_date.Text = MOREtags(BOT.Tag, "tg_date").ToString();
            label3.Text= "Welcome Back " + MOREtags(BOT.Tag, "tg_realname").ToString();



            label_User_name.Text = CurrentUsr;
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!closeSAVE)
            Program.FormM.CurrentUSR("Guest", "0,0,0,0,0,0,0,0", false);

        }
    }
}
