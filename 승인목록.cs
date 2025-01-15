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
    public partial class 승인목록 : MetroForm
    {
        public 승인목록()
        {
            InitializeComponent();
        }
        public static string 판매자매장;

        private void 승인목록_Load(object sender, EventArgs e)
        {
            this.주문상태VIEWTableAdapter1.Fill(this.dataSet11.주문상태VIEW);
            주문상태VIEWBindingSource.Filter = "매장ID= '" + 판매자매장 + "' AND (주문상태= '환불완료' OR 주문상태= '주문완료')";
            label1.Text = 판매자매장 + "담당자님이 승인하신 상품목록";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            판매자화면 showForm = new 판매자화면();
            showForm.ShowDialog();
        }
    }
}
