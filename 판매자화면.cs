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
    public partial class 판매자화면 : MetroForm
    {
        public 판매자화면()
        {
            InitializeComponent();
        }

        public static string 판매자매장;
        public static string 판매자ID;
        DataTable mytable;
        DataTable mytable1;

        private void 판매자화면_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();

            회원TableAdapter1.Fill(dataSet11.회원);
            mytable1 = dataSet11.Tables["회원"];


            foreach (DataRow mydataRow in mytable1.Rows)
            {
                comboBox1.Items.Add(mydataRow["회원ID"]);
            }


            판매자label.Text = 판매자매장 + "매장 담당자님 환영합니다 :)";
            // TODO: 이 코드는 데이터를 'dataSet11.주문상태VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.주문상태VIEWTableAdapter.Fill(this.dataSet11.주문상태VIEW);
            주문상태VIEWBindingSource.Filter = "매장ID= '" + 판매자매장 + "' AND (주문상태= '주문요청' OR 주문상태= '주문완료')";
            주문상태VIEWBindingSource1.Filter = "매장ID= '" + 판매자매장 + "' AND (주문상태= '환불요청' OR 주문상태= '환불완료')";

            //판매자 수입 갱신
            판매자TableAdapter1.Fill(dataSet11.판매자);
            mytable = dataSet11.Tables["판매자"];
            DataRow foundRows = mytable.Rows.Find(판매자ID);
            if (foundRows != null)
            {
                수입label.Text = "담당자님의 수입은 " + foundRows["수입"].ToString() + "원입니다";
            }


        }

        private void 로그아웃button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 showForm1 = new 로그인();
            showForm1.ShowDialog();
        }

        private void 주문승인button_Click(object sender, EventArgs e)
        {
            this.주문TableAdapter1.Fill(this.dataSet11.주문);

 
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString()=="주문완료")
            {
                MessageBox.Show("이미 주문완료가 된 상품입니다");
            }
           else { 
                주문TableAdapter1.주문완료변경(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                주문TableAdapter1.판매자이름작성(판매자ID, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                주문TableAdapter1.판매날짜설정(DateTime.Now, dataGridView1.CurrentRow.Cells[0].Value.ToString());
                주문TableAdapter1.Update(dataSet11.주문);

                MessageBox.Show("주문된 해당상품을 판매처리하였습니다");

                //판매자수입갱신
                int 판매가격 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                판매자TableAdapter1.수입갱신(판매가격, 판매자ID);

                판매자TableAdapter1.Fill(dataSet11.판매자);
                mytable = dataSet11.Tables["판매자"];
                DataRow foundRows = mytable.Rows.Find(판매자ID);
                if (foundRows != null)
                {
                    수입label.Text = "담당자님의 수입은 " + foundRows["수입"].ToString() + "원입니다";
                }

               


                //상품량 줄이기
                상품TableAdapter1.구입후상품개수(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            }

            this.주문상태VIEWTableAdapter.Fill(this.dataSet11.주문상태VIEW);
        }

        private void 환불승인button_Click(object sender, EventArgs e)
        {
            this.주문TableAdapter1.Fill(this.dataSet11.주문);


            if (dataGridView2.CurrentRow.Cells[2].Value.ToString() == "환불완료")
            {
                MessageBox.Show("이미 환불완료가 된 상품입니다");
            }
            else
            {

                MessageBox.Show("주문된 해당 상품을 환불처리하였습니다");

                주문TableAdapter1.환불완료변경(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                주문TableAdapter1.Update(dataSet11.주문);

                //판매자 환불후 수입갱신
                int 반품가격 = Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value.ToString());
                판매자TableAdapter1.환불수입갱신(반품가격,판매자ID);

                //상품재고 + 해야함 
                String val = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                상품TableAdapter1.환불후상품개수(val);


                판매자TableAdapter1.Fill(dataSet11.판매자);
                mytable = dataSet11.Tables["판매자"];
                DataRow foundRows = mytable.Rows.Find(판매자ID);
                if (foundRows != null)
                {
                    수입label.Text = "담당자님의 수입은 " + foundRows["수입"].ToString() + "원입니다";
                }

                //구매자 구매액 빼기

                int 가격 = Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value.ToString()); ;
                회원TableAdapter1.회원환불액(가격, dataGridView2.CurrentRow.Cells[3].Value.ToString()).ToString();

               
            }

            this.주문상태VIEWTableAdapter.Fill(this.dataSet11.주문상태VIEW);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            승인목록 showForm = new 승인목록();
            showForm.ShowDialog();
        }

        private void 회원검색(object sender, EventArgs e)
        {
          

            this.주문상태VIEWTableAdapter.Fill(this.dataSet11.주문상태VIEW);
            주문상태VIEWBindingSource.Filter = "회원ID='"+ comboBox1.SelectedItem.ToString() + "' AND 매장ID= '" + 판매자매장 + "' AND (주문상태= '주문요청' OR 주문상태= '주문완료')";
            주문상태VIEWBindingSource1.Filter = "회원ID='" + comboBox1.SelectedItem.ToString() + "' AND 매장ID= '" + 판매자매장 + "' AND (주문상태= '환불요청' OR 주문상태= '환불완료')";
                
        }
    }
}
