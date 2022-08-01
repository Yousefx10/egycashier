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
    





    public partial class Delivery : Form
    {

        private static Delivery _instance;

        public Delivery()
        {
            InitializeComponent();
            _instance = this;

        }

        public static void moveFORMnow()
        {
            Form fc = Application.OpenForms["Delivery"];
            if (fc != null)
            {
                _instance.Top = pos.omg()[0];
                _instance.Left = pos.omg()[1] + pos.omg()[2];
            }
        }

        object MOREtags(object obj, string propName)
        {
            return obj.GetType().GetProperty(propName).GetValue(obj, null);
        }
        Random rnd = new Random();
        public void ReffRe()
        {
            flowLayoutPanel1.Controls.Clear();
            string path = @"C:\EgyCashier\guest\clients\";

            DirectoryInfo d = new DirectoryInfo(path);


            foreach (var file in d.GetFiles("*.ppl"))
            {
                string[] Dafile = File.ReadAllLines(file.FullName);

                Label contactLbl = new Label();
                contactLbl.Margin = new Padding(3, 3, 3, 3);
                //left , top , right , bottom
                contactLbl.Padding = new Padding(5, 5, 30, 5);
                contactLbl.AutoSize = true;


                

                int rn1 = rnd.Next(10);
                int rn2 = rnd.Next(0, 99);
                int rn3 = rnd.Next(50, 400);
                contactLbl.Name = "A" + rn1 + rn2 + rn3;
               // MessageBox.Show(contactLbl.Name);
                contactLbl.Text = Dafile[0];
                contactLbl.Tag = new { tag_phone = Dafile[1], tag_address = Dafile[2],tag_note = Dafile[3] };


                //string filename = MOREtags(contactLbl.Tag, "FileName").ToString();

                foreach (string Da in Dafile)
                {
                }
                contactLbl.Click += ContactLbl_Click;
                flowLayoutPanel1.Controls.Add(contactLbl);
                flowLayoutPanel1.SetFlowBreak(contactLbl, true);
            }




        }
  

        private void ContactLbl_Click(object sender, EventArgs e)
        {
            btn_edit_client.Visible = true;
            Label LBL = sender as Label;
            view_lbl_name.Text = LBL.Text;
            view_lbl_phone.Text = MOREtags(LBL.Tag, "tag_phone").ToString();
            view_richtext.Clear();
            view_richtext.AppendText(MOREtags(LBL.Tag, "tag_address").ToString(), Color.Green);
            view_richtext.AppendText("\n ------- \n", Color.LightGray);
            view_richtext.AppendText(MOREtags(LBL.Tag, "tag_note").ToString(), Color.Peru);
             ForeachControlsInForm(LBL.Name);


        }
 

        public void ForeachControlsInForm(string contName)
        {

            foreach (Control contr in flowLayoutPanel1.Controls)
            {
                contr.BackColor = SystemColors.Control;
                contr.ForeColor = Color.Black;

                if (contr.Name == contName)
                {
                    contr.BackColor = SystemColors.MenuHighlight;
                    contr.ForeColor = Color.White;
                }
            }

        }
        private void Delivery_Load(object sender, EventArgs e)
        {
            moveFORMnow(); ReffRe();
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            clientsManager clm = new clientsManager("1");
            clm.ShowDialog();
            ReffRe();
        }

        private void btn_edit_client_Click(object sender, EventArgs e)
        {
            clientsManager clm = new clientsManager( view_lbl_phone.Text );
            clm.ShowDialog();
            ReffRe();
        }
    }









    public static class RichTextBoxExtensions
    {

        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}

