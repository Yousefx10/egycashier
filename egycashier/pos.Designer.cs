namespace egycashier
{
    partial class pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_remove_note = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_ADDITIONAL_VAT = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LBL_AMOUNT_VAT = new System.Windows.Forms.Label();
            this.LBL_VAT = new System.Windows.Forms.LinkLabel();
            this.LBL_AMOUNT = new System.Windows.Forms.Label();
            this.LBL_SUB_TOTAL = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 816);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 11);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(206, 637);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(248, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 814);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.LBL_ADDITIONAL_VAT);
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.LBL_AMOUNT_VAT);
            this.panel2.Controls.Add(this.LBL_VAT);
            this.panel2.Controls.Add(this.LBL_AMOUNT);
            this.panel2.Controls.Add(this.LBL_SUB_TOTAL);
            this.panel2.Controls.Add(this.button16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(773, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 816);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_remove_note);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(5, 696);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 115);
            this.panel5.TabIndex = 43;
            this.panel5.Visible = false;
            // 
            // btn_remove_note
            // 
            this.btn_remove_note.Location = new System.Drawing.Point(399, 3);
            this.btn_remove_note.Name = "btn_remove_note";
            this.btn_remove_note.Size = new System.Drawing.Size(134, 26);
            this.btn_remove_note.TabIndex = 49;
            this.btn_remove_note.Text = "Remove Person";
            this.btn_remove_note.UseVisualStyleBackColor = true;
            this.btn_remove_note.Click += new System.EventHandler(this.btn_remove_note_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = ". . .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = ". . .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "This Bill Is Specific For :";
            // 
            // LBL_ADDITIONAL_VAT
            // 
            this.LBL_ADDITIONAL_VAT.AutoSize = true;
            this.LBL_ADDITIONAL_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ADDITIONAL_VAT.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LBL_ADDITIONAL_VAT.Location = new System.Drawing.Point(354, 581);
            this.LBL_ADDITIONAL_VAT.Name = "LBL_ADDITIONAL_VAT";
            this.LBL_ADDITIONAL_VAT.Size = new System.Drawing.Size(38, 32);
            this.LBL_ADDITIONAL_VAT.TabIndex = 42;
            this.LBL_ADDITIONAL_VAT.Text = "...";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(541, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(33, 814);
            this.vScrollBar1.TabIndex = 41;
            this.vScrollBar1.Visible = false;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Location = new System.Drawing.Point(269, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 495);
            this.panel3.TabIndex = 39;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(195, 0);
            this.flowLayoutPanel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 495);
            this.panel4.TabIndex = 40;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(204, 0);
            this.flowLayoutPanel2.TabIndex = 31;
            // 
            // LBL_AMOUNT_VAT
            // 
            this.LBL_AMOUNT_VAT.AutoSize = true;
            this.LBL_AMOUNT_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AMOUNT_VAT.Location = new System.Drawing.Point(201, 581);
            this.LBL_AMOUNT_VAT.Name = "LBL_AMOUNT_VAT";
            this.LBL_AMOUNT_VAT.Size = new System.Drawing.Size(120, 29);
            this.LBL_AMOUNT_VAT.TabIndex = 37;
            this.LBL_AMOUNT_VAT.Text = "Additional";
            // 
            // LBL_VAT
            // 
            this.LBL_VAT.AutoSize = true;
            this.LBL_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VAT.Location = new System.Drawing.Point(3, 584);
            this.LBL_VAT.Name = "LBL_VAT";
            this.LBL_VAT.Size = new System.Drawing.Size(38, 25);
            this.LBL_VAT.TabIndex = 36;
            this.LBL_VAT.TabStop = true;
            this.LBL_VAT.Text = "vat";
            // 
            // LBL_AMOUNT
            // 
            this.LBL_AMOUNT.AutoSize = true;
            this.LBL_AMOUNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AMOUNT.Location = new System.Drawing.Point(190, 522);
            this.LBL_AMOUNT.Name = "LBL_AMOUNT";
            this.LBL_AMOUNT.Size = new System.Drawing.Size(91, 42);
            this.LBL_AMOUNT.TabIndex = 34;
            this.LBL_AMOUNT.Text = "0.00";
            // 
            // LBL_SUB_TOTAL
            // 
            this.LBL_SUB_TOTAL.AutoSize = true;
            this.LBL_SUB_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SUB_TOTAL.Location = new System.Drawing.Point(3, 522);
            this.LBL_SUB_TOTAL.Name = "LBL_SUB_TOTAL";
            this.LBL_SUB_TOTAL.Size = new System.Drawing.Size(174, 38);
            this.LBL_SUB_TOTAL.TabIndex = 33;
            this.LBL_SUB_TOTAL.Text = "Sup Total :";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button16.Location = new System.Drawing.Point(91, 616);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(338, 54);
            this.button16.TabIndex = 30;
            this.button16.Text = "Complete Order";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1349, 816);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pos_FormClosing);
            this.Load += new System.EventHandler(this.pos_Load);
            this.Move += new System.EventHandler(this.pos_Move);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label LBL_SUB_TOTAL;
        private System.Windows.Forms.Label LBL_AMOUNT;
        private System.Windows.Forms.LinkLabel LBL_VAT;
        private System.Windows.Forms.Label LBL_AMOUNT_VAT;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label LBL_ADDITIONAL_VAT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_remove_note;
    }
}