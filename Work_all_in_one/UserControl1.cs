using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using SimpleWork79;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public Form_Index frm1;
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Form_Index _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        public string Addnumber
        {
            set { textBox1.Text = value; }
        }

        public string SetLabelText
        {
            set { }
        }

        public string SetButtonName
        {
            set { }
        }

        private void but_WorkMenu_Click(object sender, EventArgs e)
        {
            Form_Cont formgo = new Form_Cont(frm1,textBox1.Text);
            formgo.ShowDialog();
        }

        private void but_WorkStart_Click(object sender, EventArgs e)
        {
            int WorkCount = 0; // 작업파일 실행횟수
            SQLiteConnection conn = null;
            conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
            conn.Open();

            String sql = "select * from WorkAdd79 where wname = '" + textBox1.Text + "'";


                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                        System.Diagnostics.Process.Start("" + rdr["wadd"]);
                        WorkCount += 1;
                    }
                }
                catch { MessageBox.Show("실행되지 않는 프로그램이 있습니다, 업무내용에서 확인하고 수정하세요."); }
                rdr.Close();

            if(WorkCount == 0){ MessageBox.Show(" 이 업무에 작업파일이 없습니다"); }
        }

        public void DeleteGo()
        {

                int WorkCount = 0; // 작업파일 실행횟수
                SQLiteConnection conn = null;
                conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
                conn.Open();

                try
                {
                    // 업무삭제
                    String sql = "delete from WorkAdd79 where wname = '" + textBox1.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show("업무가 삭제되었습니다.");

                }
                finally
                {
                    // 업무 컨트롤 리스트 초기화
                    frm1.flowLayoutPanel1.Controls.Clear();
                    //업무 레이블들 생성 작업 필요
                    String sql2 = "select * from Work79";
                    SQLiteCommand command = new SQLiteCommand(sql2, conn);
                    SQLiteDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        UserControl1 us = new UserControl1();
                        frm1.flowLayoutPanel1.Controls.Add(us);
                        us.textBox1.Text = "" + rdr["wname"];
                    }
                    rdr.Close();
                }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 이 업무를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int WorkCount = 0; // 작업파일 실행횟수
                SQLiteConnection conn = null;
                conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
                conn.Open();
                try
                {
                    // 업무삭제
                    String sql = "delete from Work79 where wname = '" + textBox1.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    int result = cmd.ExecuteNonQuery();
                    sql = "delete from WorkAdd79 where wname = '" + textBox1.Text + "'";
                    cmd = new SQLiteCommand(sql, conn);
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("업무가 삭제되었습니다.");

                }
                finally
                {
                    // 업무 컨트롤 리스트 초기화
                    frm1.flowLayoutPanel1.Controls.Clear();
                    //업무 레이블들 생성 작업 필요
                    String sql2 = "select * from Work79";
                    SQLiteCommand command = new SQLiteCommand(sql2, conn);
                    SQLiteDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        UserControl1 us = new UserControl1(frm1);
                        frm1.flowLayoutPanel1.Controls.Add(us);
                        us.textBox1.Text = "" + rdr["wname"];
                    }
                    rdr.Close();
                }
                Controls.Remove(panel1);
            }

        }
    }
}
