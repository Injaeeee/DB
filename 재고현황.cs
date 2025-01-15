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
    public partial class 재고현황 : MetroForm
    {
        DataTable mytable;
        DataTable mytable2;

        public 재고현황()
        {
            InitializeComponent();
        }

        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자화면 showForm = new 관리자화면();
            showForm.ShowDialog();
        }

        private void 재고현황_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            상품타입listBox.Items.Clear();

            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable = dataSet11.Tables["상품타입"];


            foreach (DataRow mydataRow in mytable.Rows)
            {
                상품타입listBox.Items.Add(mydataRow["상품타입"]);
            }
        }

        private void 매장(object sender, EventArgs e)
        {


            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];

        


            재고현황listView.Items.Clear();
            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];

   
                foreach (DataRow dataRow in mytable.Rows)
                {
                    if (dataRow["매장ID"].ToString() == comboBox1.SelectedItem.ToString() && mytable != null)
                    {
                        ListViewItem lvi1 = new ListViewItem(dataRow["상품번호"].ToString());
                        lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                        lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                        lvi1.SubItems.Add(dataRow["상품개수"].ToString());
                        lvi1.SubItems.Add(주문TableAdapter1.반품된상품개수(dataRow["상품번호"].ToString()).ToString());
                        재고현황listView.Items.Add(lvi1);
                    }
                }


                this.재고현황listView.Items[0].Focused = true;
                this.재고현황listView.Items[0].Selected = true;
            
   
        }

        private void 상품타입(object sender, EventArgs e)
        {

    재고현황listView.Items.Clear();
                상품TableAdapter1.Fill(dataSet11.상품);
                mytable = dataSet11.Tables["상품"];

                foreach (DataRow dataRow in mytable.Rows)
                {

                    if (dataRow["매장ID"].ToString() == comboBox1.SelectedItem.ToString() && dataRow["상품타입"].ToString() == 상품타입listBox.SelectedItem.ToString() && mytable != null)
                    {
                        ListViewItem lvi1 = new ListViewItem(dataRow["상품번호"].ToString());
                        lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                        lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                        lvi1.SubItems.Add(dataRow["상품개수"].ToString());
                        lvi1.SubItems.Add(주문TableAdapter1.반품된상품개수(dataRow["상품번호"].ToString()).ToString());
                        재고현황listView.Items.Add(lvi1);

                    }

                }

        }

        private void 상품선택(object sender, EventArgs e)
        {
            if (재고현황listView.SelectedItems.Count > 0)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                int SelectRow = 재고현황listView.SelectedItems[0].Index;
                int 판매된수 = Convert.ToInt32(재고현황listView.Items[SelectRow].SubItems[3].Text);
                int 환불된수 = Convert.ToInt32(재고현황listView.Items[SelectRow].SubItems[4].Text);
                chart1.Series[0].Points.AddXY(" ",판매된수);
                chart1.Series[1].Points.AddXY(" ",환불된수);

            }
        }
    }
}
