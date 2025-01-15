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
    public partial class 회원화면 : MetroForm
    {
        DataTable mytable;
        public 회원화면()
        {
            InitializeComponent();
        }
        public static string loginid;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            구입선택 showForm = new 구입선택();
            showForm.ShowDialog();
        }

        private void 마이페이지button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            마이페이지 showForm = new 마이페이지();
            showForm.ShowDialog();
        }

        private void 로그아웃button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 showForm1 = new 로그인();
            showForm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Visible = false;
            후기작성 showForm1 = new 후기작성();
            showForm1.ShowDialog();
        }

        private void 회원화면_Load(object sender, EventArgs e)
        {
            회원TableAdapter1.Fill(dataSet11.회원);
            mytable = dataSet11.Tables["회원"];


            DataRow dataRow = mytable.Rows.Find(loginid);
            label.Text = "CATS마트를 찾아주신 " + dataRow["회원이름"].ToString() + "님 환영합니다 :)";
        }

        private void 공지button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            회원공지 showForm1 = new 회원공지();
            showForm1.ShowDialog();
        }
    }
}
