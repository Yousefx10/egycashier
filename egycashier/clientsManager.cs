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
    public partial class clientsManager : Form
    {
        string WHAT2;
        public clientsManager(string WHAT)
        {
            InitializeComponent();
            WHAT2 = WHAT;
            if (WHAT == "1") 
            {
                panel_edits.Visible = false;
                panel_delete.Visible = false;
            }
            else
            {

                string path = @"C:\EgyCashier\guest\clients\"+ WHAT+".ppl";
                string[] Dafile = File.ReadAllLines(path);

                textBox_name.Visible = false;
                textBox_phone.Visible = false;
                textBox_address.Visible = false;
                textBox_notes.Visible = false;

                textBox_name.Text = Dafile[0];
                textBox_phone.Text = WHAT.ToString();
                textBox_address.Text = Dafile[2];
                textBox_notes.Text = Dafile[3];

                LBL_name.Text = Dafile[0];
                LBL_phone.Text = WHAT.ToString();
                LBL_address.Text = Dafile[2];
                LBL_notes.Text = Dafile[3];



            }
        }

        private void clientsManager_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_name_Click(object sender, EventArgs e)
        {
            if (btn_save_name.Text == "save")
            {
                LBL_name.Text = textBox_name.Text;
                textBox_name.Visible = false;
                LBL_name.Visible = true;
                btn_save_name.Text = "Edit";
                lbl_info_name.Text = "The Client Full Name is :";
            }
            else
            {
                textBox_name.Visible = true;
                LBL_name.Visible = false;
                btn_save_name.Text = "save";
                lbl_info_name.Text = "Write The Client Full Name :";
            }
        }

        private void btn_save_phone_Click(object sender, EventArgs e)
        {
            if (btn_save_phone.Text == "save")
            {
                LBL_phone.Text = textBox_phone.Text;
                textBox_phone.Visible = false;
                LBL_phone.Visible = true;
                btn_save_phone.Text = "Edit";
                lbl_info_phone.Text = "The Client Phone Number is :";
            }
            else
            {
                textBox_phone.Visible = true;
                LBL_phone.Visible = false;
                btn_save_phone.Text = "save";
                lbl_info_phone.Text = "Write The Client Phone Number :";
            }
        }

        private void btn_save_address_Click(object sender, EventArgs e)
        {
            if (btn_save_address.Text == "save")
            {
                LBL_address.Text = textBox_address.Text;
                textBox_address.Visible = false;
                LBL_address.Visible = true;
                btn_save_address.Text = "Edit";
                lbl_info_address.Text = "The Client Home Address is :";
            }
            else
            {
                textBox_address.Visible = true;
                LBL_address.Visible = false;
                btn_save_address.Text = "save";
                lbl_info_address.Text = "Write The Client Address :";
            }
        }

        private void btn_save_note_Click(object sender, EventArgs e)
        {
            if (btn_save_note.Text == "save")
            {
                LBL_notes.Text = textBox_notes.Text;
                textBox_notes.Visible = false;
                LBL_notes.Visible = true;
                btn_save_note.Text = "Edit";
                lbl_info_notes.Text = "Notes About This Client :";
            }
            else
            {
                textBox_notes.Visible = true;
                LBL_notes.Visible = false;
                btn_save_note.Text = "save";
                lbl_info_notes.Text = "Write Any Notes To Be Added :";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "" && textBox_phone.Text != "" & textBox_address.Text != "")
            {
                string path = @"C:\EgyCashier\guest\clients\";
                string lnln = "\n";
                string FULLdata = textBox_name.Text + lnln + textBox_phone.Text + lnln + textBox_address.Text + lnln + textBox_notes.Text;

                if (LBL_phone.Text != WHAT2)
                    File.Delete(path + WHAT2 + ".ppl");

                File.WriteAllText(path + textBox_phone.Text + ".ppl", FULLdata);


                MessageBox.Show("The New Client Saved Succefully !");
                Close();
            }
            else
                MessageBox.Show("Please Fill The Empty Fields");


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_delete_Click(object sender, EventArgs e)
        {

            string path = @"C:\EgyCashier\guest\clients\";

            File.Delete(path + WHAT2 + ".ppl");

            MessageBox.Show("This Client Have Been Deleted Succefully !");
            Close();
        }
    }
}
