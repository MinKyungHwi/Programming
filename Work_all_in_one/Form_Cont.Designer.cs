namespace SimpleWork79
{
    partial class Form_Cont
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
            this.but_Cancle = new System.Windows.Forms.Button();
            this.tb_wsitu = new System.Windows.Forms.TextBox();
            this.tb_wcon = new System.Windows.Forms.TextBox();
            this.tb_wname = new System.Windows.Forms.TextBox();
            this.but_fileRe = new System.Windows.Forms.Button();
            this.but_fileIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Update = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.파일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상태 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.but_filego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_Cancle
            // 
            this.but_Cancle.Font = new System.Drawing.Font("휴먼매직체", 13F);
            this.but_Cancle.Location = new System.Drawing.Point(392, 429);
            this.but_Cancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Cancle.Name = "but_Cancle";
            this.but_Cancle.Size = new System.Drawing.Size(83, 35);
            this.but_Cancle.TabIndex = 24;
            this.but_Cancle.Text = "취소";
            this.but_Cancle.UseVisualStyleBackColor = true;
            this.but_Cancle.Click += new System.EventHandler(this.but_Cancle_Click);
            // 
            // tb_wsitu
            // 
            this.tb_wsitu.Location = new System.Drawing.Point(47, 254);
            this.tb_wsitu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_wsitu.Multiline = true;
            this.tb_wsitu.Name = "tb_wsitu";
            this.tb_wsitu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_wsitu.Size = new System.Drawing.Size(331, 94);
            this.tb_wsitu.TabIndex = 23;
            // 
            // tb_wcon
            // 
            this.tb_wcon.Location = new System.Drawing.Point(46, 120);
            this.tb_wcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_wcon.Multiline = true;
            this.tb_wcon.Name = "tb_wcon";
            this.tb_wcon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_wcon.Size = new System.Drawing.Size(331, 94);
            this.tb_wcon.TabIndex = 22;
            // 
            // tb_wname
            // 
            this.tb_wname.Location = new System.Drawing.Point(101, 49);
            this.tb_wname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_wname.Name = "tb_wname";
            this.tb_wname.Size = new System.Drawing.Size(276, 25);
            this.tb_wname.TabIndex = 21;
            // 
            // but_fileRe
            // 
            this.but_fileRe.Font = new System.Drawing.Font("휴먼매직체", 10F);
            this.but_fileRe.Location = new System.Drawing.Point(704, 351);
            this.but_fileRe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_fileRe.Name = "but_fileRe";
            this.but_fileRe.Size = new System.Drawing.Size(75, 25);
            this.but_fileRe.TabIndex = 20;
            this.but_fileRe.Text = "파일제거";
            this.but_fileRe.UseVisualStyleBackColor = true;
            this.but_fileRe.Click += new System.EventHandler(this.but_fileRe_Click);
            // 
            // but_fileIn
            // 
            this.but_fileIn.Font = new System.Drawing.Font("휴먼매직체", 10F);
            this.but_fileIn.Location = new System.Drawing.Point(615, 351);
            this.but_fileIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_fileIn.Name = "but_fileIn";
            this.but_fileIn.Size = new System.Drawing.Size(75, 25);
            this.but_fileIn.TabIndex = 19;
            this.but_fileIn.Text = "파일추가";
            this.but_fileIn.UseVisualStyleBackColor = true;
            this.but_fileIn.Click += new System.EventHandler(this.but_fileIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "작업파일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "진행상황";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "업무내용";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "업무명";
            // 
            // but_Update
            // 
            this.but_Update.Font = new System.Drawing.Font("휴먼매직체", 13F);
            this.but_Update.Location = new System.Drawing.Point(294, 429);
            this.but_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Update.Name = "but_Update";
            this.but_Update.Size = new System.Drawing.Size(83, 35);
            this.but_Update.TabIndex = 25;
            this.but_Update.Text = "수정";
            this.but_Update.UseVisualStyleBackColor = true;
            this.but_Update.Click += new System.EventHandler(this.but_Update_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.파일,
            this.상태});
            this.listView1.Location = new System.Drawing.Point(403, 74);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.Size = new System.Drawing.Size(375, 274);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 파일
            // 
            this.파일.Tag = "";
            this.파일.Text = "파일";
            this.파일.Width = 285;
            // 
            // 상태
            // 
            this.상태.Text = "상태";
            this.상태.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.상태.Width = 40;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // but_filego
            // 
            this.but_filego.Font = new System.Drawing.Font("휴먼매직체", 10F);
            this.but_filego.Location = new System.Drawing.Point(402, 353);
            this.but_filego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_filego.Name = "but_filego";
            this.but_filego.Size = new System.Drawing.Size(75, 25);
            this.but_filego.TabIndex = 27;
            this.but_filego.Text = "파일실행";
            this.but_filego.UseVisualStyleBackColor = true;
            this.but_filego.Click += new System.EventHandler(this.but_filego_Click);
            // 
            // Form_Cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.but_filego);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.but_Update);
            this.Controls.Add(this.but_Cancle);
            this.Controls.Add(this.tb_wsitu);
            this.Controls.Add(this.tb_wcon);
            this.Controls.Add(this.tb_wname);
            this.Controls.Add(this.but_fileRe);
            this.Controls.Add(this.but_fileIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Cont";
            this.Text = "업무 내용";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Cancle;
        private System.Windows.Forms.TextBox tb_wsitu;
        private System.Windows.Forms.TextBox tb_wcon;
        private System.Windows.Forms.TextBox tb_wname;
        private System.Windows.Forms.Button but_fileRe;
        private System.Windows.Forms.Button but_fileIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Update;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 파일;
        private System.Windows.Forms.ColumnHeader 상태;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button but_filego;
    }
}