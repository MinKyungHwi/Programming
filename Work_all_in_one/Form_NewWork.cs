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
    public partial class Form_Content : Form
    {
        Form_Index frm1;

        public Form_Content()
        {
            InitializeComponent();
        }

        public Form_Content(Form_Index _form)
        {
            InitializeComponent();
            frm1 = _form;
        }


        private void but_fileIn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            string fullPathName = openFileDialog1.FileName;
            int Result = listBox_Work.FindString(fullPathName);
            if (Result == -1) { listBox_Work.Items.Add(fullPathName); }
            else { MessageBox.Show("이미 등록된 작업파일입니다."); }
        }

        private void but_fileRe_Click(object sender, EventArgs e)
        {
            listBox_Work.Items.Remove(listBox_Work.SelectedItem);
        }

        private void but_Insert_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = null;
            conn = new SQLiteConnection("Data Source=c:/SimpleWork79.sqlite;Version=3;");
            conn.Open();

            if (tb_wname.Text == "") tb_wname.Text = null;   //업무명 없을시 null값으로

            try
            {
                String sql = "";
                // 업무명 null값 검출
                if (tb_wname.Text == "") { sql = "insert into Work79 (wname, wcon, wsitu) values (" + tb_wname.Text + ",'" + tb_wcon.Text + "','" + tb_wsitu.Text + "')"; }
                else { sql = "insert into Work79 (wname, wcon, wsitu) values ('" + tb_wname.Text + "','" + tb_wcon.Text + "','" + tb_wsitu.Text + "')";}

                SQLiteCommand command = new SQLiteCommand(sql, conn);
                int result = command.ExecuteNonQuery();

                for (int i = 0; i < listBox_Work.Items.Count; i++)
                {
                    sql = "insert into WorkAdd79 (wname, wadd) values ('" + tb_wname.Text + "','" + listBox_Work.Items[i].ToString() + "')";
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
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("이미 존재하는 업무명이거나 업무명을 입력하지 않았습니다");
            }
            
        }
    }
}
