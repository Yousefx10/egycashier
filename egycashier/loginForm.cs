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

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == CurrentPass)
            {
                Program.FormM.CurrentUSR(CurrentPass);


            }
            else
                MessageBox.Show("Wrong Password");
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
                btnUser.Tag = Dafile[1];


                btnUser.Click += BtnUser_Click;

                flowLayoutPanel1.Controls.Add(btnUser);

            }



        }
        /*
        private void AddBT_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;


        }
        */


        private void BtnUser_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("i have been clicked");
            Button BOT = sender as Button;
            CurrentUsr = BOT.Text;
            CurrentPass = BOT.Tag.ToString();
            label_User_name.Text = CurrentUsr;
            panel1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string path = @"C:\EgyCashier\guest\users\";
            string Thrdate = DateTime.Now.ToString("MM-dd-yyyy");
            Random rnd = new Random();
            int R1 = rnd.Next(10, 99);
            int R2 = rnd.Next(100, 300);
            int R3 = rnd.Next(1, 9);

            string numName = "" + R1 + R2 + R3;

            File.Create(path + numName + ".ppl").Dispose();

            string PER = "\n1\n1\n0\n0\n0";

            File.WriteAllText(path + numName + ".ppl", textBoxName.Text + "\n" + textBoxPassword.Text + PER);
            MessageBox.Show("The User Have Been Added !", "Done !");
            panel2.Visible = true;
            panel3.Visible = false;
            FriSH();
        }
    }
}
