using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace egycashier
{
    public partial class settingSCREEN : Form
    {
        public settingSCREEN(int whatH)
        {
            InitializeComponent();
            //  CreateDynamicButton();

            tabControl1.SelectedIndex = whatH;
            GlobalwhatH = whatH;
            if (whatH == 1 || whatH == 2 || whatH == 3)
            {
                Width = tabControl1.Width + 50;
               
            }


            //    string filePATH = @"C:\EgyCashier\guest\";
            //     string[] text1 = File.ReadAllLines(filePATH + "configuration.txt");
            //     int iddd = Convert.ToInt32(text1[2]);
            //  if (iddd == 1 || iddd == 2)
            {
                //   checkBox7.Checked = true;
                //   panel_vat.Visible = true;
                //     if (iddd == 1)
                //        radioButton1.Checked = true;
                //     else
                //      radioButton2.Checked = true;

                //  textBox4.Text = text1[3];
            }
        }
        int GlobalwhatH = 0;

        void RefReshUsers()
        {


            flowLayoutPanel3.Controls.Clear();
            Button addBT = new Button();
            addBT.Text = "+";
            addBT.Font = new Font("Arial", 15);
            addBT.Click += AddBT_Click;
            addBT.Size = new Size(80, 70);

           flowLayoutPanel3.Controls.Add(addBT);

            string path = @"C:\EgyCashier\guest\users\";
            string[] owner = File.ReadAllLines(path + "owner.pl");

            Button btnOw = new Button();

            btnOw.ForeColor = Color.Black;
            btnOw.Size = new Size(80, 70);
            btnOw.Text = owner[0];
            btnOw.Tag = new
            {
                tg_pass = owner[1],
                tg_date = owner[2],
                tg_realname = owner[3],
                tg_screens = owner[4],
                tg_sett = owner[5],
                tg_file_name = path + "owner.pl"
            };

            btnOw.Click += BtnUser_Click;

            flowLayoutPanel3.Controls.Add(btnOw);


            DirectoryInfo d = new DirectoryInfo(path);


            foreach (var file in d.GetFiles("*.ppl"))
            {
                string[] Dafile = File.ReadAllLines(file.FullName);

                Button btnUser = new Button();

                btnUser.ForeColor = Color.Black;
                btnUser.Size = new Size(80, 70);
                btnUser.Text = Dafile[0];
                btnUser.Tag = new { tg_pass = Dafile[1],
                                    tg_date = Dafile[2],
                                    tg_realname = Dafile[3],
                                    tg_screens = Dafile[4],
                                    tg_sett = Dafile[5],
                                    tg_file_name = file.FullName
                };


                btnUser.Click += BtnUser_Click;

                flowLayoutPanel3.Controls.Add(btnUser);

            }


        }


        //this void is for taking the userValueProperty and changing it on the real checkboxes.
        void HandleCheckBoxes(string FirstOptions , string SecondOptions)
        {

            Cc1.Checked = false;
            Cc2.Checked = false;
            Cc3.Checked = false;
            Cc4.Checked = false;

            SeC1.Checked = false;
            SeC3.Checked = false;
            SeC2.Checked = false;
            SeC4.Checked = false;




            string[] FirArray = FirstOptions.Split(',');
            string[] SecArray = SecondOptions.Split(',');


            if (FirArray[0] == "1")
                Cc1.Checked = true;
            if (FirArray[1] == "1")
                Cc2.Checked = true;
            if (FirArray[2] == "1")
                Cc3.Checked = true;
            if (FirArray[3] == "1")
                Cc4.Checked = true;

            if (SecArray[0] == "1")
                SeC1.Checked = true;
            if (SecArray[1] == "1")
                SeC3.Checked = true;
            if (SecArray[2] == "1")
                SeC2.Checked = true;
            if (SecArray[3] == "1")
                SeC4.Checked = true;

            panel8.Visible = true;
        }






        object MOREtags(object obj, string propName)
        {
            return obj.GetType().GetProperty(propName).GetValue(obj, null);
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            Button BOT = sender as Button;
            if (BOT.Text == "+")
            {

                panel9.Visible = true;
                BOT.Text = "X";
            }
            else
            {
                panel9.Visible = false;
                BOT.Text = "+";

            }

        }
        string CurrentUsr , CurrentPass;
        private void BtnUser_Click(object sender, EventArgs e)
        {
            //when the "already user exist" button clicked.
            Button BOT = sender as Button;
            CurrentUsr = BOT.Text;
            CurrentPass = BOT.Tag.ToString();
        //    label_user_name.Text = CurrentUsr;
            panel1.Visible = true;

            currentFileName = MOREtags(BOT.Tag, "tg_file_name").ToString();

            view_label_username.Text = CurrentUsr;
            view_label_RealName.Text = MOREtags(BOT.Tag, "tg_realname").ToString();
            view_label_date.Text = MOREtags(BOT.Tag, "tg_date").ToString();
            HandleCheckBoxes(MOREtags(BOT.Tag, "tg_screens").ToString() , MOREtags(BOT.Tag, "tg_sett").ToString());


        }





        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        int WHOLEE = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            string filePATH = @"C:\EgyCashier\guest\";


            // string text1 = File.ReadAllText(filePATH+ "configuration.txt");
            string[] text1 = File.ReadAllLines(filePATH + "configuration.txt");
            int iddd = Convert.ToInt32(text1[0]);

            try
            {


                using (StreamWriter writer = new StreamWriter(filePATH + "item" + iddd + ".txt"))
                {
                    //   writer.WriteLine(textBox1.Text);
                    //   writer.WriteLine(textBox2.Text);
                }
                // Read a file  
                //  string readText = File.ReadAllText(filePATH);

                iddd++;
                string sn = "\n";
                File.WriteAllText(filePATH + "configuration.txt", iddd.ToString() + sn + text1[1] + sn + text1[2] + sn + text1[3]);



            }
            catch
            {
                MessageBox.Show("error !");
                DirectoryInfo di = Directory.CreateDirectory(@"c:/EgyCashier\guest");

                using (var tw = new StreamWriter(filePATH, true))
                {
                    tw.WriteLine("The next line!");
                }

            }
            //    textBox1.Text = "";
            //      textBox2.Text = "";
            //comboBox1.Items.Clear();

            //  CreateDynamicButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void settingSCREEN_Load(object sender, EventArgs e)
        {
            //they both WORKS
            //numericUpDown1.Controls[0].Visible = false;
            numericUpDown1.Controls.RemoveAt(0);

            //note : i noticed that 


            live();


        }







        private void live()
        {
            //in case Setting was on EditMenu.
            if(GlobalwhatH == 0)
            {

                flowLayoutPanel1.Controls.Clear();


                string filePATH = @"C:\EgyCashier\guest\";
                string[] text1 = File.ReadAllLines(filePATH + "list.txt");
                int iddd = Convert.ToInt32(text1[0]);
                for (int i = 0; i < iddd; i++)
                {
                    string[] temp1 = File.ReadAllLines(filePATH + "fol" + i + "\\configuration.txt");
                    Button ITMBTN = new Button();
                    ITMBTN.ForeColor = Color.Red;
                    ITMBTN.Size = new Size(75, 67);
                    ITMBTN.Text = temp1[1];
                    ITMBTN.Tag = "fol" + i;
                    ITMBTN.Click += ITMBTN_Click;


                    flowLayoutPanel1.Controls.Add(ITMBTN);




                    //   WHOLEE = i;


                }
                PictureBox ITMnew = new PictureBox();
                ITMnew.Image = Properties.Resources.add;
                ITMnew.SizeMode = PictureBoxSizeMode.Zoom;

                ITMnew.Size = new Size(75, 67);
                ITMnew.Click += ITMnew_Click;
                flowLayoutPanel1.Controls.Add(ITMnew);


            }//in case Setting Was In User Manager.
            else if (GlobalwhatH == 1)
            {
                RefReshUsers();
            }
            else if (GlobalwhatH == 2)//bill settings
            {

                //here's setting for load and reload Bill information
                string filePATH = @"C:\EgyCashier\guest\general\";
                string[] text1 = File.ReadAllLines(filePATH + "data.bill");

                textLine1.Text = text1[0];
                textLine2.Text = text1[1];
                textLine3.Text = text1[2];
                textLine4.Text = text1[3];
                textLine5.Text = text1[4];
                textLine6.Text = text1[5];

                if (text1[6]=="1")
                {
                    bill_checkbox.Checked = true;
                    bill_logo_pic.ImageLocation = filePATH + "logo.jpg";
                }
                DontChang = true;

            }
            else if(GlobalwhatH == 3)//vat settings
            {
                string filePATH = @"C:\EgyCashier\guest\configuration.txt";
                string[] text1 = File.ReadAllLines(filePATH);
                int iddd = Convert.ToInt32(text1[2]);
                if (iddd == 1 || iddd == 2)
                {
                    checkBoxVAT.Checked = true;
                    panel_VAT.Visible = true;
                    if (iddd == 1)
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;

                    vat_textbox.Text = text1[3];
                }
            }





        }


        private void ITMnew_Click(object sender, EventArgs e)
        {

            tabControl2.SelectedIndex = 2;
            flowLayoutPanel2.Controls.Clear();
        }

        private void Flow2Btns(string Foldder, string filePATH, string picN)
        {
            flowLayoutPanel2.Controls.Clear();
            string[] text1 = File.ReadAllLines(filePATH + "configuration.txt");
            int iddd = Convert.ToInt32(text1[0]);
            for (int i = 0; i < iddd; i++)
            {
                string[] temp1 = File.ReadAllLines(filePATH + "item" + i + ".txt");

                Button dynamicButton = new Button();
                dynamicButton.Height = 96;
                dynamicButton.Width = 126;

                dynamicButton.Text = temp1[0];
                dynamicButton.Name = "DynamicButton" + i;

                dynamicButton.Tag = temp1[1];

                dynamicButton.Click += DynamicButton_Click;


                flowLayoutPanel2.Controls.Add(dynamicButton);
            }
            PictureBox ITnoo = new PictureBox();
            ITnoo.Image = Properties.Resources.more;
            ITnoo.SizeMode = PictureBoxSizeMode.Zoom;

            ITnoo.Size = new Size(75, 67);
            ITnoo.Name = picN;

            ITnoo.Click += ITnoo_Click;
            flowLayoutPanel2.Controls.Add(ITnoo);
        }
        private void ITMBTN_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 3;
            Button bbb = sender as Button;
            textBox7.Text = bbb.Text;
            Selected_Tab = bbb.Tag.ToString();
            string filePATH = @"C:\EgyCashier\guest\" + bbb.Tag + "\\";

            Flow2Btns(Selected_Tab, filePATH, bbb.Text);

            label17.Text = bbb.Text;







        }
        string Selected_Tab;
        private void ITnoo_Click(object sender, EventArgs e)
        {
            PictureBox bbb = (PictureBox)sender;

            label17.Text = bbb.Name;
            //label17.Text = Selected_Tab;
            tabControl2.SelectedIndex = 1;
            ClearALLtext();
        }
        string CurrentItemName = "";
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            ClearALLtext();
            Button bbb = (Button)sender;
            CurrentItemName = bbb.Name.Remove(0, 13);

            tabControl2.SelectedIndex = 1;
            textBox6.Text = bbb.Text;
            label1.Text = bbb.Text;
            numericUpDown1.Value = Int32.Parse(bbb.Tag.ToString());
            // label17.Text = Selected_Tab;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (label1.Visible)
            {
                pictureBox1.Image = Properties.Resources.save;
                label1.Visible = false;
                textBox6.Visible = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.edit;
                label1.Text = textBox6.Text;
                label1.Visible = true;
                textBox6.Visible = false;
            }

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {


            string filePATH = @"C:\EgyCashier\guest\";

            //it was taking from the comboBox.
            // string yesHere = (comboBox2.SelectedItem as ComboboxItem).Value.ToString();
            string yesHere = Selected_Tab;
            string[] text1 = File.ReadAllLines(filePATH + yesHere + "\\configuration.txt");
            int iddd = Convert.ToInt32(text1[0]);

            try
            {


                using (StreamWriter writer = new StreamWriter(filePATH + yesHere + "\\item" + iddd + ".txt"))
                {
                    writer.WriteLine(textBox6.Text);
                    writer.WriteLine(numericUpDown1.Value);
                }


                iddd++;
                string sn = "\n";
                File.WriteAllText(filePATH + yesHere + "\\configuration.txt", iddd.ToString() + sn + text1[1]);

            }
            catch
            {
                MessageBox.Show("error !");
                DirectoryInfo di = Directory.CreateDirectory(@"c:/EgyCashier\guest");

                using (var tw = new StreamWriter(filePATH, true))
                {
                    tw.WriteLine("The next line!");
                }

            }
            //   textBox1.Text = "";
            //  textBox2.Text = "";
            // flowLayoutPanel1.Controls.Clear();

            //   CreateDynamicButton();
            //life();
            live();

            tabControl2.SelectedIndex = 0;
            ClearALLtext();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string filePATH = @"C:\EgyCashier\guest\" + Selected_Tab;
            string[] text1 = File.ReadAllLines(filePATH + "\\configuration.txt");

            File.WriteAllText(filePATH + "\\configuration.txt", text1[0] + "\n" + textBox7.Text);
            live();
            ClearALLtext();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            string filePATH = @"C:\EgyCashier\guest\";


            string[] text1 = File.ReadAllLines(filePATH + "list.txt");
            int iddd = Convert.ToInt32(text1[0]);

            Program.FormX.FolderManage(2);


            DirectoryInfo di = Directory.CreateDirectory(filePATH + "fol" + iddd);

            try
            {


                using (StreamWriter writer = new StreamWriter(filePATH + "fol" + iddd + "\\configuration.txt"))
                {
                    writer.WriteLine("0");
                    writer.WriteLine(textBox5.Text);
                }
                // Read a file  
                //  string readText = File.ReadAllText(filePATH);

                iddd++;
                File.WriteAllText(filePATH + "list.txt", iddd.ToString());



            }
            catch { }
            // flowLayoutPanel1.Controls.Clear();
            live();
            //life();

            tabControl2.SelectedIndex = 0;
            ClearALLtext();
            Program.FormX.FolderManage(0);

        }

        private void ClearALLtext()
        {

            textBox5.Text = "";
            textBox7.Text = "";
            numericUpDown1.Value = 0;
            
            label1.Text = "- Without Name -";
            pictureBox1.Image = Properties.Resources.edit;


            textBox6.Text = label1.Text;
            label1.Visible = true;
            textBox6.Visible = false;
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {

            string filePATH = @"C:\EgyCashier\guest\" + Selected_Tab + "\\";
            //   string valueCOM = (comboBox1.SelectedItem as ComboboxItem).Value.ToString();
            //   string numberOnly = Regex.Replace(valueCOM, "[^0-9.]", "");
            int vv = Convert.ToInt32(CurrentItemName);
            File.Delete(filePATH + "item" + vv + ".txt");

            updateWHOLE(Selected_Tab);

            for (int i = vv + 1; i < WHOLEE + 1; i++)
            {
                File.Move(filePATH + "item" + i + ".txt", filePATH + "item" + (i - 1) + ".txt");
            }
            string[] temp1 = File.ReadAllLines(filePATH + "configuration.txt");
            //   string oldD = temp1[1] + "\n" + temp1[2] + "\n" + temp1[3] + "\n";
            File.WriteAllText(filePATH + "configuration.txt", WHOLEE.ToString() + "\n" + temp1[1]);
            tabControl2.SelectedIndex = 0;



            Flow2Btns(Selected_Tab, filePATH, label17.Text);


        }

        private void updateWHOLE(string ListName)
        {
            string filePATH = @"C:\EgyCashier\guest\" + ListName + "\\";
            string[] text1 = File.ReadAllLines(filePATH + "configuration.txt");
            int iddd = Convert.ToInt32(text1[0]);
            WHOLEE = iddd - 1;
        }










        //this function makes Refresh/Create the items in the ComboBox[from old direction] ... no needed now !

        private void CreateDynamicButton()

        {

            /* string filePATH = @"C:\EgyCashier\guest\";
             string[] text1 = File.ReadAllLines(filePATH + "configuration.txt");
             int iddd = Convert.ToInt32(text1[0]);
             for (int i = 0; i < iddd; i++)
             {
                 string[] temp1 = File.ReadAllLines(filePATH + "item" + i + ".txt");
                 ComboboxItem item = new ComboboxItem();

                 item.Text = temp1[0];
                 item.Value = "item" + i;



                 comboBox1.Items.Add(item);

                 WHOLEE = i;


             }*/
        }




        private void radioBTN_setting_Click(object sender, EventArgs e)
        {
            if (radioBTN_setting.Checked && !ChangeSttS)
            {
                radioBTN_setting.Checked = false;
                checkBTN_Op1.Checked = false;
                checkBTN_Op2.Checked = false;
                checkBTN_Op3.Checked = false;
                checkBTN_Op4.Checked = false;

                checkBTN_Op1.Enabled = false;
                checkBTN_Op2.Enabled = false;
                checkBTN_Op3.Enabled = false;
                checkBTN_Op4.Enabled = false;
            }
            else
            {
                radioBTN_setting.Checked = true;
                ChangeSttS = false;
                checkBTN_Op1.Enabled = true;
                checkBTN_Op2.Enabled = true;
                checkBTN_Op3.Enabled = true;
                checkBTN_Op4.Enabled = true;
            }

        }
        //this bool is just to allow the RadioButton Change Check Without Any Lags...
        bool ChangeSttS = false;

        private void radioBTN_setting_CheckedChanged(object sender, EventArgs e)
        {

            ChangeSttS = radioBTN_setting.Checked;


        }

        private void btn_crt_usr_Click(object sender, EventArgs e)
        {
            //*** Create The New User : ***

            //The Path To save The Users :
            string path = @"C:\EgyCashier\guest\users\";

            //we need the date to last open date.
            string Thrdate = DateTime.Now.ToString("MM-dd-yyyy");

            //A Unique Random Number As a File Name...
            Random rnd = new Random();
            int R1 = rnd.Next(10, 99);
            int R2 = rnd.Next(100, 300);
            int R3 = rnd.Next(1, 9);

            string numName = "" + R1 + R2 + R3;

            //Create The Empty User's File. 
            //NOTE : ( .ppl ) is just for the normal user.
            //NOTE : ( .pl ) is just for the ADMIN.
            File.Create(path + numName + ".ppl").Dispose();

            //The User Rules :
            /*
             * 
             * ( 1) Username.
             * ( 2) Password.
             * ( 3) date : for saving the last login Date.
             * ( 4) The User's Real Name.
             
                [ Program Screens PERMISSIONS ]
             * ( 5) open POS.
             * ( 6) open Reports.
             * ( 7) open Money.
             * ( 8) open Supplies.
             * 
             * 
             * 
                [ SETTINGS PERMISSIONS ]
             * ( 5) option A.
             * ( 6) option B.
             * ( 7) option C.
             * ( 8) option D.
             */



            string N = "\n", Z =",";
            string PER = text_username.Text + N + txt_password.Text + N + Thrdate +N+ text_realname.Text + N;
            PER += CheckBoxToValueString(checkBTN_pos.Checked)+ Z;
            PER += CheckBoxToValueString(checkBTN_reports.Checked) + Z;
            PER += CheckBoxToValueString(checkBTN_money.Checked) + Z;
            PER += CheckBoxToValueString(checkBTN_supplies.Checked)+ N;

            //The Setting's Values.
            if(radioBTN_setting.Checked) {
                PER += CheckBoxToValueString(checkBTN_Op1.Checked) + Z;
                PER += CheckBoxToValueString(checkBTN_Op2.Checked) + Z;
                PER += CheckBoxToValueString(checkBTN_Op3.Checked) + Z;
                PER += CheckBoxToValueString(checkBTN_Op4.Checked);
            }
            else
                PER += "0,0,0,0";



            File.WriteAllText(path + numName + ".ppl", PER);
            MessageBox.Show("The User Have Been Added !", "Done !");
            panel2.Visible = true;
            panel3.Visible = false;


            RefReshUsers();

        }

        //function to make a value if checkbox is checked or not.
        public int CheckBoxToValueString(bool Valll )
        {
            if (Valll)
                return 1;
            else
                return 0;

        }

        string currentFileName;
        private void user_del_pic_Click(object sender, EventArgs e)
        {
            File.Delete(currentFileName);
            panel8.Visible = false;
            RefReshUsers();
        }

        private void bill_pic_save_Click(object sender, EventArgs e)
        {

            int picWhat = 0;
            if (bill_checkbox.Checked)
                picWhat++;


            File.WriteAllText(@"C:\EgyCashier\guest\general\data.bill", 
                //for first 4 Lines on the top
                textLine1.Text+"\n"
                +textLine2.Text+"\n"
                +textLine3.Text+"\n"
                +textLine4.Text+"\n"
                
                //for Last 2 Lines in the end
                +textLine5.Text+"\n"
                +textLine6.Text+"\n"
                
                //for bill image status
                + picWhat
                );
            bill_pic_save.Visible = false;

            Close();

        }

        private void bill_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (bill_checkbox.Checked)
                bill_btn_logo.Visible = true;
            else
                bill_btn_logo.Visible = false;
        }

        private void bill_btn_logo_Click(object sender, EventArgs e)
        {
            string imgLocation;

            OpenFileDialog DIAlog = new OpenFileDialog();
            DIAlog.Filter = "images|*.jpg;*.png;*.jepg";

            try
            {
                if (DIAlog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = DIAlog.FileName;

                    bill_logo_pic.ImageLocation = imgLocation;

                    string PPath = @"C:\EgyCashier\guest\general\";
                    //delete the old logo if exist to override.
                    if (File.Exists(PPath + "logo.jpg"))
                        File.Delete(PPath + "logo.jpg");

                    File.Copy(imgLocation, PPath + "logo.jpg");

                    textLine1_TextChanged(sender, e);

                }
            }
            catch { MessageBox.Show("Some error ! ! !"); }

        }

        //this bool prevent textbox from showing the save button
        bool DontChang = false;
        private void textLine1_TextChanged(object sender, EventArgs e)
        {
            if(DontChang)
            {
                bill_pic_save.Visible = true;
                label__save.Visible = true;
            }

        }

        private void settingSCREEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bill_pic_save.Visible)
            {
                DialogResult dialogResult = MessageBox.Show("There's New Changes,Do you Really want to exit?", "you didn't Save The Latest Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    e.Cancel = true;
            }

        }

        private void pic_saveVAT_Click(object sender, EventArgs e)
        {

            int STATS = 0;

            if (checkBoxVAT.Checked)
            {
                STATS++;
                if (radioButton2.Checked)
                    STATS++;


                string filePATH = @"C:\EgyCashier\guest\configuration.txt";
                string[] temp1 = File.ReadAllLines(filePATH);
                string old1 = temp1[0];
                string old2 = temp1[1];
                string final_old = temp1[0] + "\n" + temp1[1] + "\n";
                string HHnew = final_old + STATS + "\n" + vat_textbox.Text;
                File.WriteAllText(filePATH, HHnew);

            }
            else
            {
                string filePATH = @"C:\EgyCashier\guest\configuration.txt";
                string[] temp1 = File.ReadAllLines(filePATH);
                string old1 = temp1[0];
                string old2 = temp1[1];
                string final_old = temp1[0] + "\n" + temp1[1] + "\n" + STATS + "\n" + 0;
                string HHnew = final_old;
                File.WriteAllText(filePATH, HHnew);
            }
            Close();
        }

        private void checkBoxVAT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVAT.Checked)
                panel_VAT.Visible = true;
            else
                panel_VAT.Visible = false;
        }




        //this function makes Refresh/Create the items in the ComboBox ... no needed now !
        private void life()
        {
            /*            string filePATH = @"C:\EgyCashier\guest\";
                        string[] text1 = File.ReadAllLines(filePATH + "list.txt");
                        int iddd = Convert.ToInt32(text1[0]);
                        for (int i = 0; i < iddd; i++)
                        {
                            string[] temp1 = File.ReadAllLines(filePATH + "fol" + i + "\\configuration.txt");
                            ComboboxItem item = new ComboboxItem();

                            item.Text = temp1[1];
                            item.Value = "fol" + i;



                            comboBox2.Items.Add(item);

                        }*/
        }


    }
}
