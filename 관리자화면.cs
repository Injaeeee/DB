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
    public partial class 관리자화면 : MetroForm
    {
        public 관리자화면()
        {
            InitializeComponent();
        }

        private void 고객관리button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            고객관리 showForm = new 고객관리();
            showForm.ShowDialog();

        }

        private void 재고현황button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            재고현황 showForm = new 재고현황();
            showForm.ShowDialog();
        }

        private void 공지button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            공지사항 showForm = new 공지사항();
            showForm.ShowDialog();
        }

        private void 로그아웃button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 showForm1 = new 로그인();
            showForm1.ShowDialog();
        }

        private void 관리자화면_Load(object sender, EventArgs e)
        {

        }

        private void 상품관리button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            상품관리 showForm1 = new 상품관리();
            showForm1.ShowDialog();
        }

        private void 상품현황button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            판매현황 showForm1 = new 판매현황();
            showForm1.ShowDialog();
        }

        private void 상품현황button_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            상품현황 showForm1 = new 상품현황();
            showForm1.ShowDialog();
        }
    }
}
