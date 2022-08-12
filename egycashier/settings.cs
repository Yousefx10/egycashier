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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowSettingForm(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowSettingForm(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ShowSettingForm(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ShowSettingForm(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ShowSettingForm(4);
        }






        private void ShowSettingForm(int openNum)
        {
            settingSCREEN SCSC = new settingSCREEN(openNum);
            SCSC.Show();
            Close();
        }
    }
}
