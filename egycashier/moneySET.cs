using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egycashier
{
    public partial class moneySET : Form
    {
        public moneySET(int Datype)
        {
            InitializeComponent();
            //Enter The Amount Of Money To Take:
            if(Datype == 1)
            label1.Text += "Take Out:";
            else
            label1.Text += "Give Back:";

        }

        private void moneySET_Load(object sender, EventArgs e)
        {

        }
        int TheAmount=0;
        string strAmount="";
        private void button11_Click(object sender, EventArgs e)
        {
            if(strAmount!="")
            TheAmount = Int32.Parse(strAmount);

            money.Amount_toProc= TheAmount;
            Close();
        }

        void Edit_num(int mme)
        {
            strAmount += mme;
            label_view.Text = strAmount + ".00 EGP";
            TheAmount = Int32.Parse(strAmount);
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            Edit_num(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Edit_num(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Edit_num(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Edit_num(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Edit_num(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Edit_num(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Edit_num(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Edit_num(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Edit_num(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Edit_num(0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (strAmount.Length > 0)
            {
                strAmount = strAmount.Remove(strAmount.Length - 1);
                if (strAmount.Length > 0)
                    label_view.Text = strAmount + ".00 EGP";
                else
                    label_view.Text = "0.00 EGP";
            }
            else
                label_view.Text = "0.00 EGP";

        }
    }
}
