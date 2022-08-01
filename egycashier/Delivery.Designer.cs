namespace egycashier
{
    partial class Delivery
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.view_richtext = new System.Windows.Forms.RichTextBox();
            this.btn_edit_client = new System.Windows.Forms.Button();
            this.view_lbl_phone = new System.Windows.Forms.Label();
            this.view_lbl_name = new System.Windows.Forms.Label();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 514);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.view_richtext);
            this.panel1.Controls.Add(this.btn_edit_client);
            this.panel1.Controls.Add(this.view_lbl_phone);
            this.panel1.Controls.Add(this.view_lbl_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 222);
            this.panel1.TabIndex = 1;
            // 
            // view_richtext
            // 
            this.view_richtext.BackColor = System.Drawing.SystemColors.Control;
            this.view_richtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view_richtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_richtext.Location = new System.Drawing.Point(6, 93);
            this.view_richtext.Name = "view_richtext";
            this.view_richtext.ReadOnly = true;
            this.view_richtext.Size = new System.Drawing.Size(314, 91);
            this.view_richtext.TabIndex = 13;
            this.view_richtext.Text = "---";
            // 
            // btn_edit_client
            // 
            this.btn_edit_client.Location = new System.Drawing.Point(2, 190);
            this.btn_edit_client.Name = "btn_edit_client";
            this.btn_edit_client.Size = new System.Drawing.Size(318, 29);
            this.btn_edit_client.TabIndex = 11;
            this.btn_edit_client.Text = "Edit This User Details";
            this.btn_edit_client.UseVisualStyleBackColor = true;
            this.btn_edit_client.Visible = false;
            this.btn_edit_client.Click += new System.EventHandler(this.btn_edit_client_Click);
            // 
            // view_lbl_phone
            // 
            this.view_lbl_phone.AutoSize = true;
            this.view_lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_lbl_phone.Location = new System.Drawing.Point(76, 45);
            this.view_lbl_phone.Margin = new System.Windows.Forms.Padding(1);
            this.view_lbl_phone.Name = "view_lbl_phone";
            this.view_lbl_phone.Padding = new System.Windows.Forms.Padding(2);
            this.view_lbl_phone.Size = new System.Drawing.Size(148, 29);
            this.view_lbl_phone.TabIndex = 9;
            this.view_lbl_phone.Text = "Mobile Number";
            // 
            // view_lbl_name
            // 
            this.view_lbl_name.AutoSize = true;
            this.view_lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_lbl_name.Location = new System.Drawing.Point(1, 1);
            this.view_lbl_name.Margin = new System.Windows.Forms.Padding(1);
            this.view_lbl_name.Name = "view_lbl_name";
            this.view_lbl_name.Padding = new System.Windows.Forms.Padding(2);
            this.view_lbl_name.Size = new System.Drawing.Size(104, 29);
            this.view_lbl_name.TabIndex = 8;
            this.view_lbl_name.Text = "Full Name";
            // 
            // btn_add_client
            // 
            this.btn_add_client.Location = new System.Drawing.Point(2, 524);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(318, 32);
            this.btn_add_client.TabIndex = 2;
            this.btn_add_client.Text = "Add New Client";
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(326, 784);
            this.ControlBox = false;
            this.Controls.Add(this.btn_add_client);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Delivery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label view_lbl_name;
        private System.Windows.Forms.Label view_lbl_phone;
        private System.Windows.Forms.Button btn_edit_client;
        private System.Windows.Forms.RichTextBox view_richtext;
        private System.Windows.Forms.Button btn_add_client;
    }
}