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
    public partial class 마이페이지 : MetroForm
    {
        DataTable mytable;
        DataTable mytable2;
        public static string loginid;
        public 마이페이지()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            회원화면 showForm = new 회원화면();
            showForm.ShowDialog();
  


        }




        private void button3_Click(object sender, EventArgs e)
        {
            
            회원TableAdapter1.Fill(dataSet11.회원);
            mytable = dataSet11.Tables["회원"];
            DataRow myDataRow = mytable.Rows.Find(loginid);

            try
            {
                if (MessageBox.Show("회원탈퇴를 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (myDataRow != null)
                    {

                        주문TableAdapter1.회원탈퇴주문(loginid);
                        후기TableAdapter1.회원탈퇴후기(loginid);
                        장바구니TableAdapter1.회원탈퇴장바구니(loginid);
                        myDataRow.Delete();
                        회원TableAdapter1.Update(dataSet11.회원);
                        MessageBox.Show("회원탈퇴 되었습니다");

                        this.Visible = false;
                        로그인 showForm2 = new 로그인();
                        showForm2.ShowDialog();     // show를 showDialog로 바꿔줌


                    }
                    //확인시 내용
                    MessageBox.Show("회원탈퇴 되었습니다");
                }
              
            }catch(Oracle.ManagedDataAccess.Client.OracleException)
            {
                MessageBox.Show("현재 처리되지 않은 주문이나 장바구니에 담겨있는 상품이 있습니다.");
            }



        }

        private void 마이페이지_Load(object sender, EventArgs e)
        {

            회원TableAdapter1.Fill(dataSet11.회원);
            mytable2 = dataSet11.Tables["회원"];


            DataRow dataRow2 = mytable2.Rows.Find(loginid);
            회원label.Text = "안녕하세요 " + dataRow2["회원이름"].ToString() + "님! :)";
            구매label.Text = "회원님의 총 구매액은 " + dataRow2["총구매액"].ToString() + "원입니다";

            주문상태VIEWTableAdapter1.Fill(dataSet11.주문상태VIEW);
            mytable = dataSet11.Tables["주문상태VIEW"];


            foreach (DataRow dataRow in mytable.Rows )
            {
                if (dataRow["회원ID"].ToString() == loginid)
                {
                    ListViewItem lvi1 = new ListViewItem(dataRow["주문번호"].ToString());
                    lvi1.SubItems.Add(dataRow["상품번호"].ToString());
                    lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                    lvi1.SubItems.Add(dataRow["주문날짜"].ToString());
                    lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                    lvi1.SubItems.Add(dataRow["상품가격"].ToString());
                    lvi1.SubItems.Add(dataRow["주문상태"].ToString());
                    listView1.Items.Add(lvi1);
                }

            }

            try { 
                this.listView1.Items[0].Focused = true;
                this.listView1.Items[0].Selected = true;
                }
            catch(System.Exception ex)
            {

            }


  


        }


        private void 로그아웃button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 showForm1 = new 로그인();
            showForm1.ShowDialog();
        }

        private void 환불요청button_Click(object sender, EventArgs e)
        {

            try
            {
                int SelectRow = listView1.SelectedItems[0].Index;

                string 주문번호 = listView1.Items[SelectRow].SubItems[0].Text;

                string 상품이름 = listView1.Items[SelectRow].SubItems[2].Text;

                this.주문TableAdapter1.Fill(this.dataSet11.주문);
                mytable = dataSet11.Tables["주문"];

                DataRow dataRow = mytable.Rows.Find(주문번호);


                if (dataRow["주문상태"].ToString() == "주문완료")
                {

                    주문TableAdapter1.환불요청변경(dataRow["주문번호"].ToString());
                    MessageBox.Show(상품이름 + "상품을 환불요청 하였습니다");

                    listView1.Items[SelectRow].SubItems[6].Text = "환불요청";


                }
                else if (dataRow["주문상태"].ToString() == "주문요청")
                {
                    주문TableAdapter1.주문삭제(listView1.Items[SelectRow].SubItems[0].Text);
                    MessageBox.Show("요청하신 주문을 주문취소하였습니다");

                    //구매자 구매액 빼기

                    int 가격 = Convert.ToInt32(listView1.Items[SelectRow].SubItems[5].Text); ;
                    회원TableAdapter1.회원환불액(가격, loginid).ToString();

                    //상품재고 + 해야함 
                    String val = listView1.Items[SelectRow].SubItems[1].Text;
                    상품TableAdapter1.환불후상품개수(val);

                    listView1.Items[SelectRow].Remove();
                    listView1.Update();


                    DataRow dataRow2 = mytable2.Rows.Find(loginid);
                    int 변환된가격 = Convert.ToInt32(dataRow2["총구매액"].ToString()) - 가격;
                    구매label.Text = "회원님의 총 구매액은 " + 변환된가격.ToString() + "원입니다";

                }
                else if (dataRow["주문상태"].ToString() == "환불요청")
                {
                    MessageBox.Show("이미 환불요청상태 입니다");
                }
                else if (dataRow["주문상태"].ToString() == "환불완료")
                {
                    MessageBox.Show("이미 환불완료상태 입니다");
                }

            }
            catch (System.Exception ex)
            {

            }

      

        }

        private void button4_Click(object sender, EventArgs e)
        {
            회원TableAdapter1.Fill(dataSet11.회원);
            mytable = dataSet11.Tables["회원"];
            DataRow myDataRow = mytable.Rows.Find(loginid);
            MessageBox.Show("회원님의 고객등급은 "+ myDataRow["회원타입"].ToString()+ " 입니다");
        }
    }
}
