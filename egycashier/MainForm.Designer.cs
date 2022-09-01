namespace egycashier
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnDELIVERY = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Lbl_settings = new System.Windows.Forms.Label();
            this.Lbl_reports = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_help = new System.Windows.Forms.Label();
            this.Lbl_money = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_supplies = new System.Windows.Forms.Label();
            this.label_please = new System.Windows.Forms.Label();
            this.Lbl_bills = new System.Windows.Forms.Label();
            this.btn_bills = new System.Windows.Forms.PictureBox();
            this.btn_supplies = new System.Windows.Forms.PictureBox();
            this.btn_money = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_reports = new System.Windows.Forms.PictureBox();
            this.btn_Settings = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_supplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pic_minimize);
            this.panel1.Controls.Add(this.pic_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pic_minimize
            // 
            this.pic_minimize.Image = global::egycashier.Properties.Resources.minus;
            this.pic_minimize.Location = new System.Drawing.Point(745, 2);
            this.pic_minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(32, 28);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimize.TabIndex = 2;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // pic_close
            // 
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(781, 2);
            this.pic_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(32, 28);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 1;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(268, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back - Egypt Cashier";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnPOS
            // 
            this.btnPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.Location = new System.Drawing.Point(233, 277);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(174, 99);
            this.btnPOS.TabIndex = 4;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Visible = false;
            this.btnPOS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDELIVERY
            // 
            this.btnDELIVERY.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELIVERY.Location = new System.Drawing.Point(412, 277);
            this.btnDELIVERY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDELIVERY.Name = "btnDELIVERY";
            this.btnDELIVERY.Size = new System.Drawing.Size(174, 99);
            this.btnDELIVERY.TabIndex = 5;
            this.btnDELIVERY.Text = "Delivery";
            this.btnDELIVERY.UseVisualStyleBackColor = true;
            this.btnDELIVERY.Visible = false;
            this.btnDELIVERY.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(9, 150);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Welcome Guest ";
            // 
            // Lbl_settings
            // 
            this.Lbl_settings.AutoSize = true;
            this.Lbl_settings.Location = new System.Drawing.Point(7, 572);
            this.Lbl_settings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_settings.Name = "Lbl_settings";
            this.Lbl_settings.Size = new System.Drawing.Size(45, 13);
            this.Lbl_settings.TabIndex = 8;
            this.Lbl_settings.Text = "Settings";
            this.Lbl_settings.Visible = false;
            this.Lbl_settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // Lbl_reports
            // 
            this.Lbl_reports.AutoSize = true;
            this.Lbl_reports.Location = new System.Drawing.Point(766, 572);
            this.Lbl_reports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_reports.Name = "Lbl_reports";
            this.Lbl_reports.Size = new System.Drawing.Size(44, 13);
            this.Lbl_reports.TabIndex = 10;
            this.Lbl_reports.Text = "Reports";
            this.Lbl_reports.Visible = false;
            this.Lbl_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F);
            this.label4.Location = new System.Drawing.Point(222, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 67);
            this.label4.TabIndex = 11;
            this.label4.Text = "Egypt Cashier";
            // 
            // Lbl_help
            // 
            this.Lbl_help.AutoSize = true;
            this.Lbl_help.Location = new System.Drawing.Point(72, 572);
            this.Lbl_help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_help.Name = "Lbl_help";
            this.Lbl_help.Size = new System.Drawing.Size(29, 13);
            this.Lbl_help.TabIndex = 13;
            this.Lbl_help.Text = "Help";
            // 
            // Lbl_money
            // 
            this.Lbl_money.AutoSize = true;
            this.Lbl_money.Location = new System.Drawing.Point(658, 572);
            this.Lbl_money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_money.Name = "Lbl_money";
            this.Lbl_money.Size = new System.Drawing.Size(39, 13);
            this.Lbl_money.TabIndex = 15;
            this.Lbl_money.Text = "Money";
            this.Lbl_money.Visible = false;
            this.Lbl_money.Click += new System.EventHandler(this.btn_money_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 25);
            this.button3.TabIndex = 16;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(104, 150);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 15);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Logout";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 565);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Version : v1.0.0.1";
            // 
            // Lbl_supplies
            // 
            this.Lbl_supplies.AutoSize = true;
            this.Lbl_supplies.Location = new System.Drawing.Point(585, 572);
            this.Lbl_supplies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_supplies.Name = "Lbl_supplies";
            this.Lbl_supplies.Size = new System.Drawing.Size(50, 13);
            this.Lbl_supplies.TabIndex = 20;
            this.Lbl_supplies.Text = "Suppliers";
            this.Lbl_supplies.Visible = false;
            this.Lbl_supplies.Click += new System.EventHandler(this.btn_supplies_Click);
            // 
            // label_please
            // 
            this.label_please.AutoSize = true;
            this.label_please.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_please.Location = new System.Drawing.Point(260, 266);
            this.label_please.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_please.Name = "label_please";
            this.label_please.Size = new System.Drawing.Size(294, 20);
            this.label_please.TabIndex = 21;
            this.label_please.Text = "Please Login To Start Using The System";
            // 
            // Lbl_bills
            // 
            this.Lbl_bills.AutoSize = true;
            this.Lbl_bills.Location = new System.Drawing.Point(716, 572);
            this.Lbl_bills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_bills.Name = "Lbl_bills";
            this.Lbl_bills.Size = new System.Drawing.Size(25, 13);
            this.Lbl_bills.TabIndex = 23;
            this.Lbl_bills.Text = "Bills";
            this.Lbl_bills.Click += new System.EventHandler(this.btn_bills_Click);
            // 
            // btn_bills
            // 
            this.btn_bills.Image = global::egycashier.Properties.Resources.bill;
            this.btn_bills.Location = new System.Drawing.Point(710, 524);
            this.btn_bills.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bills.Name = "btn_bills";
            this.btn_bills.Size = new System.Drawing.Size(41, 46);
            this.btn_bills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_bills.TabIndex = 22;
            this.btn_bills.TabStop = false;
            this.btn_bills.Click += new System.EventHandler(this.btn_bills_Click);
            // 
            // btn_supplies
            // 
            this.btn_supplies.Image = global::egycashier.Properties.Resources.packages;
            this.btn_supplies.Location = new System.Drawing.Point(587, 524);
            this.btn_supplies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_supplies.Name = "btn_supplies";
            this.btn_supplies.Size = new System.Drawing.Size(41, 46);
            this.btn_supplies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_supplies.TabIndex = 19;
            this.btn_supplies.TabStop = false;
            this.btn_supplies.Visible = false;
            this.btn_supplies.Click += new System.EventHandler(this.btn_supplies_Click);
            // 
            // btn_money
            // 
            this.btn_money.Image = global::egycashier.Properties.Resources.pay;
            this.btn_money.Location = new System.Drawing.Point(652, 524);
            this.btn_money.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_money.Name = "btn_money";
            this.btn_money.Size = new System.Drawing.Size(41, 46);
            this.btn_money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_money.TabIndex = 14;
            this.btn_money.TabStop = false;
            this.btn_money.Visible = false;
            this.btn_money.Click += new System.EventHandler(this.btn_money_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::egycashier.Properties.Resources.question;
            this.pictureBox4.Location = new System.Drawing.Point(65, 524);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // btn_reports
            // 
            this.btn_reports.Image = global::egycashier.Properties.Resources.report;
            this.btn_reports.Location = new System.Drawing.Point(766, 524);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(41, 46);
            this.btn_reports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_reports.TabIndex = 9;
            this.btn_reports.TabStop = false;
            this.btn_reports.Visible = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Image = global::egycashier.Properties.Resources.settings;
            this.btn_Settings.Location = new System.Drawing.Point(7, 524);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(41, 46);
            this.btn_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Settings.TabIndex = 7;
            this.btn_Settings.TabStop = false;
            this.btn_Settings.Visible = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::egycashier.Properties.Resources.usericon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(816, 594);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl_bills);
            this.Controls.Add(this.btn_bills);
            this.Controls.Add(this.label_please);
            this.Controls.Add(this.Lbl_supplies);
            this.Controls.Add(this.btn_supplies);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Lbl_money);
            this.Controls.Add(this.btn_money);
            this.Controls.Add(this.Lbl_help);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_reports);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.Lbl_settings);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDELIVERY);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_supplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnDELIVERY;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox btn_Settings;
        private System.Windows.Forms.Label Lbl_settings;
        private System.Windows.Forms.Label Lbl_reports;
        private System.Windows.Forms.PictureBox btn_reports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_help;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Lbl_money;
        private System.Windows.Forms.PictureBox btn_money;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_supplies;
        private System.Windows.Forms.PictureBox btn_supplies;
        private System.Windows.Forms.Label label_please;
        private System.Windows.Forms.Label Lbl_bills;
        private System.Windows.Forms.PictureBox btn_bills;
    }
}