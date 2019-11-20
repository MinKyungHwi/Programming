namespace SimpleWork79
{
    partial class Form_Content
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Work = new System.Windows.Forms.ListBox();
            this.but_fileIn = new System.Windows.Forms.Button();
            this.but_fileRe = new System.Windows.Forms.Button();
            this.tb_wname = new System.Windows.Forms.TextBox();
            this.tb_wcon = new System.Windows.Forms.TextBox();
            this.tb_wsitu = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.but_Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "업무명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "업무내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "진행상황";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "작업파일";
            // 
            // listBox_Work
            // 
            this.listBox_Work.FormattingEnabled = true;
            this.listBox_Work.HorizontalExtent = 100;
            this.listBox_Work.HorizontalScrollbar = true;
            this.listBox_Work.ItemHeight = 15;
            this.listBox_Work.Location = new System.Drawing.Point(403, 74);
            this.listBox_Work.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Work.Name = "listBox_Work";
            this.listBox_Work.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox_Work.Size = new System.Drawing.Size(375, 274);
            this.listBox_Work.TabIndex = 7;
            // 
            // but_fileIn
            // 
            this.but_fileIn.Font = new System.Drawing.Font("휴먼매직체", 10F);
            this.but_fileIn.Location = new System.Drawing.Point(615, 351);
            this.but_fileIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_fileIn.Name = "but_fileIn";
            this.but_fileIn.Size = new System.Drawing.Size(75, 26);
            this.but_fileIn.TabIndex = 8;
            this.but_fileIn.Text = "파일추가";
            this.but_fileIn.UseVisualStyleBackColor = true;
            this.but_fileIn.Click += new System.EventHandler(this.but_fileIn_Click);
            // 
            // but_fileRe
            // 
            this.but_fileRe.Font = new System.Drawing.Font("휴먼매직체", 10F);
            this.but_fileRe.Location = new System.Drawing.Point(704, 351);
            this.but_fileRe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_fileRe.Name = "but_fileRe";
            this.but_fileRe.Size = new System.Drawing.Size(75, 26);
            this.but_fileRe.TabIndex = 9;
            this.but_fileRe.Text = "파일제거";
            this.but_fileRe.UseVisualStyleBackColor = true;
            this.but_fileRe.Click += new System.EventHandler(this.but_fileRe_Click);
            // 
            // tb_wname
            // 
            this.tb_wname.Location = new System.Drawing.Point(101, 49);
            this.tb_wname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_wname.Name = "tb_wname";
            this.tb_wname.Size = new System.Drawing.Size(276, 25);
            this.tb_wname.TabIndex = 11;
            // 
            // tb_wcon
            // 
            this.tb_wcon.Location = new System.Drawing.Point(46, 120);
            this.tb_wcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_wcon.Multiline = true;
            this.tb_wcon.Name = "tb_wcon";
            this.tb_wcon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_wcon.Size = new System.Drawing.Size(331, 94);
            this.tb_wcon.TabIndex = 12;
            // 
            // tb_wsitu
            // 
            this.tb_wsitu.Location = new System.Drawing.Point(46, 254);
            this.tb_wsitu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_wsitu.Multiline = true;
            this.tb_wsitu.Name = "tb_wsitu";
            this.tb_wsitu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_wsitu.Size = new System.Drawing.Size(331, 94);
            this.tb_wsitu.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // but_Insert
            // 
            this.but_Insert.Font = new System.Drawing.Font("휴먼매직체", 13F);
            this.but_Insert.Location = new System.Drawing.Point(341, 392);
            this.but_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Insert.Name = "but_Insert";
            this.but_Insert.Size = new System.Drawing.Size(102, 44);
            this.but_Insert.TabIndex = 14;
            this.but_Insert.Text = "등록";
            this.but_Insert.UseVisualStyleBackColor = true;
            this.but_Insert.Click += new System.EventHandler(this.but_Insert_Click);
            // 
            // Form_Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_Insert);
            this.Controls.Add(this.tb_wsitu);
            this.Controls.Add(this.tb_wcon);
            this.Controls.Add(this.tb_wname);
            this.Controls.Add(this.but_fileRe);
            this.Controls.Add(this.but_fileIn);
            this.Controls.Add(this.listBox_Work);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Content";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "새 업무";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Work;
        private System.Windows.Forms.Button but_fileIn;
        private System.Windows.Forms.Button but_fileRe;
        private System.Windows.Forms.TextBox tb_wname;
        private System.Windows.Forms.TextBox tb_wcon;
        private System.Windows.Forms.TextBox tb_wsitu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button but_Insert;
    }
}