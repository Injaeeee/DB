using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace 기말프로젝트
{
    public partial class 회원공지 : MetroForm
    {
        DataTable mytable;
        public 회원공지()
        {
            InitializeComponent();
        }

        private void 회원공지_Load(object sender, EventArgs e)
        {

            
            공지사항TableAdapter1.Fill(dataSet11.공지사항);
            mytable = dataSet11.Tables["공지사항"];


            foreach (DataRow dataRow in mytable.Rows)
            {

                ListViewItem lvi1 = new ListViewItem(dataRow["공지날짜"].ToString());
                lvi1.SubItems.Add(dataRow["제목"].ToString());
                lvi1.SubItems.Add(dataRow["공지타입"].ToString());
                lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                listView1.Items.Add(lvi1);

            }
            
        }

        private void 매장변경(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            comboBox2.Text = string.Empty;
            공지사항TableAdapter1.Fill(dataSet11.공지사항);
            mytable = dataSet11.Tables["공지사항"];


            foreach (DataRow dataRow in mytable.Rows)
            {
                if (dataRow["매장ID"].ToString() == comboBox1.SelectedItem.ToString() && mytable != null)
                {
                    ListViewItem lvi1 = new ListViewItem(dataRow["공지날짜"].ToString());
                    lvi1.SubItems.Add(dataRow["제목"].ToString());
                    lvi1.SubItems.Add(dataRow["공지타입"].ToString());
                    lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                    listView1.Items.Add(lvi1);
                }

            }
        }

        private void 공지타입변경(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            공지사항TableAdapter1.Fill(dataSet11.공지사항);
            mytable = dataSet11.Tables["공지사항"];


            foreach (DataRow dataRow in mytable.Rows)
            {
            
                    if (dataRow["매장ID"].ToString() == comboBox1.SelectedItem.ToString() && dataRow["공지타입"].ToString() == comboBox2.SelectedItem.ToString() && mytable != null)
                    {
                        ListViewItem lvi1 = new ListViewItem(dataRow["공지날짜"].ToString());
                        lvi1.SubItems.Add(dataRow["제목"].ToString());
                        lvi1.SubItems.Add(dataRow["공지타입"].ToString());
                        lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                        listView1.Items.Add(lvi1);
                    }
       
            }
        }

        private void 공지선택(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int SelectRow = listView1.SelectedItems[0].Index;
                string 제목 = listView1.Items[SelectRow].SubItems[1].Text;
                string 매장 = listView1.Items[SelectRow].SubItems[3].Text;
                string 공지타입 = listView1.Items[SelectRow].SubItems[2].Text;
                string 공지날짜 = listView1.Items[SelectRow].SubItems[0].Text;

                공지사항TableAdapter1.Fill(dataSet11.공지사항);
                mytable = dataSet11.Tables["공지사항"];
                DataRow[] foundRows = mytable.Select("제목 ='" + 제목 + "' AND 공지타입 ='" + 공지타입 + "' AND 매장ID ='" + 매장 + "' AND 공지날짜 ='" + 공지날짜 + "'");


                foreach (DataRow mydata in foundRows)
                {
                    textBox1.Text = mydata["내용"].ToString();
                }
            }
        }

        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            회원화면 showForm = new 회원화면();
            showForm.ShowDialog();
        }
    }
}
