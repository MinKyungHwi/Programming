using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using WindowsFormsApp1;

namespace SimpleWork79
{
    public partial class Form_Index : Form
    {
        public Form_Index()
        {
            InitializeComponent();



            System.IO.FileInfo fi = new System.IO.FileInfo("c:/SimpleWork79.sqlite");
            if (fi.Exists)  //파일존재
            {
                flowLayoutPanel1.Controls.Clear();
                SQLiteConnection conn = null;
                conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
                conn.Open();
                //업무 레이블들 생성 작업 필요
                String sql = "select * from Work79";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    UserControl1 us = new UserControl1(this);
                    flowLayoutPanel1.Controls.Add(us);
                    us.textBox1.Text = "" + rdr["wname"];
                }
                rdr.Close();
            }
            else  //파일없음
            {
                SQLiteConnection.CreateFile("c:/SimpleWork79.sqlite");
                SQLiteConnection conn = null;
                conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
                conn.Open();
                MessageBox.Show("첫 실행을 환영합니다, 업무 세이브파일을 C드라이브에 생성했습니다");

                string sql = "create table Work79 (wname varchar not null, wcon varchar, wsitu varchar, primary key(wname))";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                int result = command.ExecuteNonQuery();

                sql = "create table WorkAdd79 (wname varchar, wadd varchar, primary key(wname, wadd),foreign key(wname) references Work79 on delete cascade)";
                command = new SQLiteCommand(sql, conn);
                result = command.ExecuteNonQuery();

                Form_HINT formgo = new Form_HINT();
                formgo.ShowDialog();
            }
        }

        private void button_newwork_Click(object sender, EventArgs e)
        {
            Form_Content formgo = new Form_Content(this);
            formgo.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_HINT formgo = new Form_HINT();
            formgo.ShowDialog();
        }
    }
}
