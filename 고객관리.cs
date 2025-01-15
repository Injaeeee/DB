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
    public partial class 고객관리 : MetroForm
    {
      
        public 고객관리()
        {
            InitializeComponent();
        }

        private void 고객관리_Load(object sender, EventArgs e)
        {
            회원TableAdapter1.Fill(dataSet11.회원);

            //탈퇴한회원이 보이지 않게하는 코드
            회원BindingSource.Filter = "회원타입 = '우수회원' OR 회원타입= '불량회원' OR 회원타입 = '일반회원'";
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // - 나중에 버튼만들고 "123" 대신 dataGridView1.CurrentRow.Cells[0].Value.ToString()을 넣을것

            int 주문횟수 = (int)주문TableAdapter1.회원의주문상태(val, "주문요청") + (int)주문TableAdapter1.회원의주문상태(val, "주문완료");

            int 환불횟수 = (int)주문TableAdapter1.회원의주문상태(val, "환불요청") + (int)주문TableAdapter1.회원의주문상태(val, "환불완료");

            고객이름label.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() + "회원님의";
            구매횟수label.Text = 주문횟수.ToString();
            환불횟수label.Text = 환불횟수.ToString();


        }

        private void 정보보기(object sender, DataGridViewCellMouseEventArgs e)
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // - 나중에 버튼만들고 "123" 대신 dataGridView1.CurrentRow.Cells[0].Value.ToString()을 넣을것
            int 주문횟수 = (int)주문TableAdapter1.회원의주문상태(val, "주문요청") + (int)주문TableAdapter1.회원의주문상태(val, "주문완료");

            int 환불횟수 = (int)주문TableAdapter1.회원의주문상태(val, "환불요청") + (int)주문TableAdapter1.회원의주문상태(val, "환불완료");

            고객이름label.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() + "회원님의";
            구매횟수label.Text = 주문횟수.ToString();
            환불횟수label.Text = 환불횟수.ToString();

        }

        private void 저장button_Click(object sender, EventArgs e)
        {
            this.회원TableAdapter1.Update(this.dataSet11.회원);
            MessageBox.Show("회원정보가 저장되었습니다");
        }

        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자화면 showForm = new 관리자화면();
            showForm.ShowDialog();
        }
    }
}
