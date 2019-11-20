using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using WindowsFormsApp1;
using System.Windows.Forms;

namespace SimpleWork79
{
    public partial class Form_Cont : Form
    {
        Form_Index frm1;
        String workname;
        public Form_Cont()
        {
            InitializeComponent();
        }

        public Form_Cont(Form_Index _form, String wname)
        {
            InitializeComponent();
            frm1 = _form;
            workname = wname;

            SQLiteConnection conn = null;
            conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
            conn.Open();

            //업무 레이블들 생성 작업 필요
            String sql = "select * from Work79 where wname = '" + wname +"'";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                tb_wname.Text = "" + rdr["wname"];
                tb_wcon.Text = "" + rdr["wcon"];
                tb_wsitu.Text = "" + rdr["wsitu"];
            }
            rdr.Close();

            sql = "select * from WorkAdd79 where wname = '" + wname + "'";
            command = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr2 = command.ExecuteReader();
            while (rdr2.Read())
            {
                ListViewItem lvi = new ListViewItem(""+rdr2["wadd"]);
                // 프로세스 실행 가능 검사 코드
                System.IO.FileInfo fi = new System.IO.FileInfo("" + rdr2["wadd"]);
                if (fi.Exists)
                {
                    //파일존재
                    lvi.SubItems.Add("정상");
                    listView1.Items.Add(lvi);
                }
                else
                {
                    //파일없음
                    lvi.SubItems.Add("불가");
                    listView1.Items.Add(lvi);
                }
            }
            rdr2.Close();
        }

        private void but_Update_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = null;
            conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
            conn.Open();

            try
            {
                //Work79 수정
                String sql = "update Work79 set wname = '" + tb_wname.Text + "', wcon = '" + tb_wcon.Text + "', wsitu = '" + tb_wsitu.Text + "' where wname = '" + workname + "'";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                int result = command.ExecuteNonQuery();

                // WorkAdd79 수정
                sql = "delete from WorkAdd79 where wname = '" + workname + "'";
                command = new SQLiteCommand(sql, conn);
                result = command.ExecuteNonQuery();

                if (tb_wname.Text == "") tb_wname.Text = null;   //업무명 없을시 null값으로

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    sql = "insert into WorkAdd79 (wname, wadd) values ('" + tb_wname.Text + "','" + listView1.Items[i].SubItems[0].Text + "')";
                    command = new SQLiteCommand(sql, conn);
                    result = command.ExecuteNonQuery();
                }

                frm1.flowLayoutPanel1.Controls.Clear();
                sql = "select * from Work79";
                command = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    UserControl1 us = new UserControl1(frm1);
                    frm1.flowLayoutPanel1.Controls.Add(us);
                    us.textBox1.Text = "" + rdr["wname"];
                }
                rdr.Close();
            }
            finally { MessageBox.Show("업무가 정상적으로 수정되었습니다."); this.Close();}
        }

        private void but_fileIn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string fullPathName = openFileDialog1.FileName;
            ListViewItem Result = listView1.FindItemWithText(fullPathName);
            if (Result == null)
            {
                ListViewItem lvi = new ListViewItem(fullPathName);
                // 프로세스 실행 가능 검사 코드
                System.IO.FileInfo fi = new System.IO.FileInfo(fullPathName);
                if (fi.Exists)
                {
                    //파일존재
                    lvi.SubItems.Add("정상");
                    listView1.Items.Add(lvi);
                }
                else
                {
                    //파일없음
                    lvi.SubItems.Add("불가");
                    listView1.Items.Add(lvi);
                }
            }
            else { MessageBox.Show("이미 등록된 작업파일입니다."); }
        }

        private void but_fileRe_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.FocusedItem);
        }

        private void but_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_filego_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text);
        }
    }
}
