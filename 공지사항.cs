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
    public partial class 공지사항 : MetroForm
    {

        DataTable mytable;
        DataTable mytable2;
        public 공지사항()
        {
            InitializeComponent();
        }

        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자화면 showForm = new 관리자화면();
            showForm.ShowDialog();
        }


        private void 작성button_Click(object sender, EventArgs e)
        {
            공지사항TableAdapter1.Fill(dataSet11.공지사항);
            mytable = dataSet11.Tables["공지사항"];
            DataRow mynewDataRow = mytable.NewRow();

            if (제목textBox.Text == string.Empty)
            {
                MessageBox.Show("공지사항 제목을 입력하세요");
                return;
            }
            else if (내용textBox.Text == string.Empty)
            {
                MessageBox.Show("공지사항 내용을 입력하세요");
                return;
            }
            else
            {
                mynewDataRow["제목"] = 제목textBox.Text;
                mynewDataRow["내용"] = 내용textBox.Text;
                mynewDataRow["공지타입"] = comboBox1.SelectedItem.ToString();
                mynewDataRow["공지날짜"] = DateTime.Now.ToString();
                mynewDataRow["매장ID"] = comboBox2.SelectedItem.ToString();
                mytable.Rows.Add(mynewDataRow);
                MessageBox.Show("공지사항 업데이트 완료");
                제목textBox.Text = string.Empty;
                내용textBox.Text = string.Empty;
                this.공지사항TableAdapter1.Update(this.dataSet11.공지사항);
            }
        }

        private void 공지사항_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            comboBox2.SelectedIndex = 0;
        }
    }
}
