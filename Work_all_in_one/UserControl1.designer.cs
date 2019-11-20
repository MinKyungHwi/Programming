namespace WindowsFormsApp1
{
    partial class UserControl1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_WorkStart = new System.Windows.Forms.Button();
            this.but_WorkMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.but_WorkStart);
            this.panel1.Controls.Add(this.but_WorkMenu);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 64);
            this.panel1.TabIndex = 0;
            // 
            // but_WorkStart
            // 
            this.but_WorkStart.Location = new System.Drawing.Point(557, 19);
            this.but_WorkStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_WorkStart.Name = "but_WorkStart";
            this.but_WorkStart.Size = new System.Drawing.Size(86, 29);
            this.but_WorkStart.TabIndex = 2;
            this.but_WorkStart.Text = "작업시작";
            this.but_WorkStart.UseVisualStyleBackColor = true;
            this.but_WorkStart.Click += new System.EventHandler(this.but_WorkStart_Click);
            // 
            // but_WorkMenu
            // 
            this.but_WorkMenu.Location = new System.Drawing.Point(464, 19);
            this.but_WorkMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_WorkMenu.Name = "but_WorkMenu";
            this.but_WorkMenu.Size = new System.Drawing.Size(86, 29);
            this.but_WorkMenu.TabIndex = 1;
            this.but_WorkMenu.Text = "업무내용";
            this.but_WorkMenu.UseVisualStyleBackColor = true;
            this.but_WorkMenu.Click += new System.EventHandler(this.but_WorkMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(776, 74);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_WorkStart;
        private System.Windows.Forms.Button but_WorkMenu;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
