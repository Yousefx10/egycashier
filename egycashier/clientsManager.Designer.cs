namespace egycashier
{
    partial class clientsManager
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_delete = new System.Windows.Forms.Panel();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_edits = new System.Windows.Forms.Panel();
            this.btn_save_note = new System.Windows.Forms.Label();
            this.btn_save_address = new System.Windows.Forms.Label();
            this.btn_save_phone = new System.Windows.Forms.Label();
            this.btn_save_name = new System.Windows.Forms.Label();
            this.lbl_info_notes = new System.Windows.Forms.Label();
            this.textBox_notes = new System.Windows.Forms.TextBox();
            this.lbl_info_address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.lbl_info_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.lbl_info_name = new System.Windows.Forms.Label();
            this.LBL_notes = new System.Windows.Forms.Label();
            this.LBL_address = new System.Windows.Forms.Label();
            this.LBL_phone = new System.Windows.Forms.Label();
            this.LBL_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            this.panel_edits.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::egycashier.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_delete);
            this.panel1.Controls.Add(this.panel_edits);
            this.panel1.Controls.Add(this.lbl_info_notes);
            this.panel1.Controls.Add(this.textBox_notes);
            this.panel1.Controls.Add(this.lbl_info_address);
            this.panel1.Controls.Add(this.textBox_address);
            this.panel1.Controls.Add(this.lbl_info_phone);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.lbl_info_name);
            this.panel1.Controls.Add(this.LBL_notes);
            this.panel1.Controls.Add(this.LBL_address);
            this.panel1.Controls.Add(this.LBL_phone);
            this.panel1.Controls.Add(this.LBL_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 398);
            this.panel1.TabIndex = 1;
            // 
            // panel_delete
            // 
            this.panel_delete.Controls.Add(this.pic_delete);
            this.panel_delete.Controls.Add(this.label1);
            this.panel_delete.Location = new System.Drawing.Point(12, 293);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(131, 85);
            this.panel_delete.TabIndex = 26;
            // 
            // pic_delete
            // 
            this.pic_delete.Image = global::egycashier.Properties.Resources.garbage;
            this.pic_delete.Location = new System.Drawing.Point(42, 3);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new System.Drawing.Size(42, 50);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_delete.TabIndex = 23;
            this.pic_delete.TabStop = false;
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delete This User";
            this.label1.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // panel_edits
            // 
            this.panel_edits.Controls.Add(this.btn_save_note);
            this.panel_edits.Controls.Add(this.btn_save_address);
            this.panel_edits.Controls.Add(this.btn_save_phone);
            this.panel_edits.Controls.Add(this.btn_save_name);
            this.panel_edits.Location = new System.Drawing.Point(542, 12);
            this.panel_edits.Name = "panel_edits";
            this.panel_edits.Size = new System.Drawing.Size(56, 305);
            this.panel_edits.TabIndex = 25;
            // 
            // btn_save_note
            // 
            this.btn_save_note.AutoSize = true;
            this.btn_save_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_note.ForeColor = System.Drawing.Color.Red;
            this.btn_save_note.Location = new System.Drawing.Point(10, 251);
            this.btn_save_note.Name = "btn_save_note";
            this.btn_save_note.Size = new System.Drawing.Size(43, 25);
            this.btn_save_note.TabIndex = 12;
            this.btn_save_note.Text = "edit";
            this.btn_save_note.Click += new System.EventHandler(this.btn_save_note_Click);
            // 
            // btn_save_address
            // 
            this.btn_save_address.AutoSize = true;
            this.btn_save_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_address.ForeColor = System.Drawing.Color.Red;
            this.btn_save_address.Location = new System.Drawing.Point(10, 181);
            this.btn_save_address.Name = "btn_save_address";
            this.btn_save_address.Size = new System.Drawing.Size(43, 25);
            this.btn_save_address.TabIndex = 11;
            this.btn_save_address.Text = "edit";
            this.btn_save_address.Click += new System.EventHandler(this.btn_save_address_Click);
            // 
            // btn_save_phone
            // 
            this.btn_save_phone.AutoSize = true;
            this.btn_save_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_phone.ForeColor = System.Drawing.Color.Red;
            this.btn_save_phone.Location = new System.Drawing.Point(10, 107);
            this.btn_save_phone.Name = "btn_save_phone";
            this.btn_save_phone.Size = new System.Drawing.Size(43, 25);
            this.btn_save_phone.TabIndex = 10;
            this.btn_save_phone.Text = "edit";
            this.btn_save_phone.Click += new System.EventHandler(this.btn_save_phone_Click);
            // 
            // btn_save_name
            // 
            this.btn_save_name.AutoSize = true;
            this.btn_save_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_name.ForeColor = System.Drawing.Color.Red;
            this.btn_save_name.Location = new System.Drawing.Point(10, 20);
            this.btn_save_name.Name = "btn_save_name";
            this.btn_save_name.Size = new System.Drawing.Size(43, 25);
            this.btn_save_name.TabIndex = 9;
            this.btn_save_name.Text = "edit";
            this.btn_save_name.Click += new System.EventHandler(this.btn_save_name_Click);
            // 
            // lbl_info_notes
            // 
            this.lbl_info_notes.AutoSize = true;
            this.lbl_info_notes.Location = new System.Drawing.Point(212, 240);
            this.lbl_info_notes.Name = "lbl_info_notes";
            this.lbl_info_notes.Size = new System.Drawing.Size(152, 16);
            this.lbl_info_notes.TabIndex = 22;
            this.lbl_info_notes.Text = "Notes About This Client :";
            // 
            // textBox_notes
            // 
            this.textBox_notes.Location = new System.Drawing.Point(212, 259);
            this.textBox_notes.Name = "textBox_notes";
            this.textBox_notes.Size = new System.Drawing.Size(254, 22);
            this.textBox_notes.TabIndex = 21;
            // 
            // lbl_info_address
            // 
            this.lbl_info_address.AutoSize = true;
            this.lbl_info_address.Location = new System.Drawing.Point(212, 169);
            this.lbl_info_address.Name = "lbl_info_address";
            this.lbl_info_address.Size = new System.Drawing.Size(180, 16);
            this.lbl_info_address.TabIndex = 20;
            this.lbl_info_address.Text = "The Client Home Address is :";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(212, 189);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(254, 22);
            this.textBox_address.TabIndex = 19;
            // 
            // lbl_info_phone
            // 
            this.lbl_info_phone.AutoSize = true;
            this.lbl_info_phone.Location = new System.Drawing.Point(212, 95);
            this.lbl_info_phone.Name = "lbl_info_phone";
            this.lbl_info_phone.Size = new System.Drawing.Size(179, 16);
            this.lbl_info_phone.TabIndex = 18;
            this.lbl_info_phone.Text = "The Client Phone Number is :";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(212, 115);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(171, 22);
            this.textBox_phone.TabIndex = 17;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(212, 32);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(254, 22);
            this.textBox_name.TabIndex = 16;
            // 
            // lbl_info_name
            // 
            this.lbl_info_name.AutoSize = true;
            this.lbl_info_name.Location = new System.Drawing.Point(212, 12);
            this.lbl_info_name.Name = "lbl_info_name";
            this.lbl_info_name.Size = new System.Drawing.Size(150, 16);
            this.lbl_info_name.TabIndex = 15;
            this.lbl_info_name.Text = "The Client Full Name is :";
            // 
            // LBL_notes
            // 
            this.LBL_notes.AutoSize = true;
            this.LBL_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_notes.Location = new System.Drawing.Point(207, 256);
            this.LBL_notes.Name = "LBL_notes";
            this.LBL_notes.Size = new System.Drawing.Size(22, 25);
            this.LBL_notes.TabIndex = 7;
            this.LBL_notes.Text = "..";
            // 
            // LBL_address
            // 
            this.LBL_address.AutoSize = true;
            this.LBL_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_address.Location = new System.Drawing.Point(210, 185);
            this.LBL_address.Name = "LBL_address";
            this.LBL_address.Size = new System.Drawing.Size(22, 25);
            this.LBL_address.TabIndex = 3;
            this.LBL_address.Text = "..";
            // 
            // LBL_phone
            // 
            this.LBL_phone.AutoSize = true;
            this.LBL_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_phone.Location = new System.Drawing.Point(210, 111);
            this.LBL_phone.Name = "LBL_phone";
            this.LBL_phone.Size = new System.Drawing.Size(22, 25);
            this.LBL_phone.TabIndex = 2;
            this.LBL_phone.Text = "..";
            // 
            // LBL_name
            // 
            this.LBL_name.AutoSize = true;
            this.LBL_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_name.Location = new System.Drawing.Point(207, 28);
            this.LBL_name.Name = "LBL_name";
            this.LBL_name.Size = new System.Drawing.Size(22, 25);
            this.LBL_name.TabIndex = 1;
            this.LBL_name.Text = "..";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(198, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 32);
            this.label9.TabIndex = 15;
            this.label9.Text = "Add New Client";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(361, 467);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(252, 40);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save New Client";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(12, 467);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(147, 40);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "- Cancel -";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // clientsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(625, 516);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clientsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientsManager";
            this.Load += new System.EventHandler(this.clientsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_delete.ResumeLayout(false);
            this.panel_delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            this.panel_edits.ResumeLayout(false);
            this.panel_edits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_name;
        private System.Windows.Forms.Label LBL_phone;
        private System.Windows.Forms.Label LBL_address;
        private System.Windows.Forms.Label LBL_notes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label lbl_info_name;
        private System.Windows.Forms.Label lbl_info_notes;
        private System.Windows.Forms.TextBox textBox_notes;
        private System.Windows.Forms.Label lbl_info_address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label lbl_info_phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.Panel panel_edits;
        private System.Windows.Forms.Label btn_save_note;
        private System.Windows.Forms.Label btn_save_address;
        private System.Windows.Forms.Label btn_save_phone;
        private System.Windows.Forms.Label btn_save_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_delete;
    }
}