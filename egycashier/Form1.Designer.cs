namespace egycashier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.time_setup = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Setup The Configuration Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quick Check on.....";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.linkLabel3.Location = new System.Drawing.Point(299, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(155, 31);
            this.linkLabel3.TabIndex = 4;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Test Printer";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // pic_2
            // 
            this.pic_2.Image = global::egycashier.Properties.Resources.close1;
            this.pic_2.Location = new System.Drawing.Point(17, 105);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(40, 40);
            this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_2.TabIndex = 6;
            this.pic_2.TabStop = false;
            // 
            // pic_1
            // 
            this.pic_1.Image = global::egycashier.Properties.Resources.accept;
            this.pic_1.Location = new System.Drawing.Point(17, 59);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(40, 40);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_1.TabIndex = 5;
            this.pic_1.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_1.Location = new System.Drawing.Point(63, 67);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(27, 25);
            this.lbl_1.TabIndex = 7;
            this.lbl_1.Text = "...";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_2.Location = new System.Drawing.Point(63, 113);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(27, 25);
            this.lbl_2.TabIndex = 8;
            this.lbl_2.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Location = new System.Drawing.Point(17, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 53);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.LinkColor = System.Drawing.Color.Fuchsia;
            this.linkLabel1.Location = new System.Drawing.Point(460, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 31);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // time_setup
            // 
            this.time_setup.Interval = 2500;
            this.time_setup.Tick += new System.EventHandler(this.time_setup_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 157);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Write The Admin Password You Want :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(88, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "it should be strong and secret";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Admin\'s Password :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 216);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer time_setup;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

