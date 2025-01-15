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
    public partial class 상품현황 : MetroForm
    {
        DataTable mytable;
        DataTable mytable2;
        DataTable mytable3;
        public 상품현황()
        {
            InitializeComponent();
        }

        private void 상품현황_Load(object sender, EventArgs e)
        {
            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];


            foreach (DataRow dataRow in mytable.Rows)
            {
                int 판매된수 = Convert.ToInt32(주문TableAdapter1.판매된상품개수(dataRow["상품번호"].ToString()));
                int 환불된수 = Convert.ToInt32(주문TableAdapter1.반품된상품개수(dataRow["상품번호"].ToString()));

                상품TableAdapter1.반품과판매수갱신(판매된수, 환불된수, dataRow["상품번호"].ToString());
            }


            판매수량VIEWTableAdapter1.Fill(this.dataSet11.판매수량VIEW);
            환불수량VIEWTableAdapter1.Fill(this.dataSet11.환불수량VIEW);

            listView1.Items.Clear();

            mytable2 = dataSet11.Tables["판매수량VIEW"];
            mytable3 = dataSet11.Tables["환불수량VIEW"];

            foreach (DataRow dataRow1 in mytable2.Rows)
            {

                ListViewItem lvi1 = new ListViewItem(dataRow1["상품이름"].ToString());
                lvi1.SubItems.Add(dataRow1["상품번호"].ToString());
                lvi1.SubItems.Add(dataRow1["매장ID"].ToString());
                listView1.Items.Add(lvi1);

            }
            foreach (DataRow dataRow2 in mytable3.Rows)
            {

                ListViewItem lvi1 = new ListViewItem(dataRow2["상품이름"].ToString());
                lvi1.SubItems.Add(dataRow2["상품번호"].ToString());
                lvi1.SubItems.Add(dataRow2["매장ID"].ToString());
                listView1.Items.Add(lvi1);

            }


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자화면 showForm = new 관리자화면();
            showForm.ShowDialog();
        }


    }
}