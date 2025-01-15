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
    public partial class 후기작성 : MetroForm
    {
        DataTable mytable;

        public static string loginid;
        public 후기작성()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void 후기작성_Load(object sender, EventArgs e)
        {


            // TODO: 이 코드는 데이터를 'dataSet11.후기VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.후기VIEWTableAdapter.Fill(this.dataSet11.후기VIEW);


            주문상태VIEWTableAdapter1.Fill(dataSet11.주문상태VIEW);
            mytable = dataSet11.Tables["주문상태VIEW"];


            foreach (DataRow dataRow in mytable.Rows)
            {
                if (dataRow["회원ID"].ToString() == loginid && dataRow["상품번호"].ToString() == dataRow["상품번호"].ToString() && mytable != null && dataRow["후기작성여부"].ToString() == "후기없음" && dataRow["주문상태"].ToString() == "주문완료")
                {
                    ListViewItem lvi1 = new ListViewItem(dataRow["주문번호"].ToString());
                    lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                    lvi1.SubItems.Add(dataRow["주문날짜"].ToString());
                    lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                    lvi1.SubItems.Add(dataRow["상품가격"].ToString());
                    listView1.Items.Add(lvi1);
                }
            }

            try
            {
                this.listView1.Items[0].Focused = true;
                this.listView1.Items[0].Selected = true;
            }
            catch (System.Exception ex)
            {

            }
          
        }

        private void 작성button_Click(object sender, EventArgs e)
        {

            int SelectRow = listView1.SelectedItems[0].Index;

            후기TableAdapter1.Fill(dataSet11.후기);
            mytable = dataSet11.Tables["후기"];
            DataRow mynewDataRow = mytable.NewRow();

            if (후기제목textBox.Text == string.Empty)
            {
                MessageBox.Show("후기 제목을 입력하세요");
                return;
            }
            else if (후기내용textBox.Text == string.Empty)
            {
                MessageBox.Show("후기 내용을 입력하세요");
                return;
            }
            else
            {

                string 주문번호 = listView1.Items[SelectRow].SubItems[0].Text;
                mynewDataRow["리뷰번호"] = 주문번호;
                mynewDataRow["리뷰제목"] = 후기제목textBox.Text;
                mynewDataRow["리뷰내용"] = 후기내용textBox.Text;
                mynewDataRow["회원ID"] = loginid;
                mynewDataRow["주문번호"] = 주문번호;
                mynewDataRow["리뷰날짜"] = DateTime.Now.ToString();

                try
                {
                    mytable.Rows.Add(mynewDataRow);
                    MessageBox.Show("후기 작성 완료");
                    후기제목textBox.Text = string.Empty;
                    후기내용textBox.Text = string.Empty;
                    주문TableAdapter1.후기작성여부(주문번호);


                    this.후기TableAdapter1.Update(this.dataSet11.후기);
                    this.후기VIEWTableAdapter.Fill(this.dataSet11.후기VIEW);



                    주문상태VIEWTableAdapter1.Fill(dataSet11.주문상태VIEW);
                    mytable = dataSet11.Tables["주문상태VIEW"];

                    listView1.Items.Clear();
                    foreach (DataRow dataRow in mytable.Rows)
                    {
                        if (dataRow["회원ID"].ToString() == loginid && dataRow["상품번호"].ToString() == dataRow["상품번호"].ToString() && mytable != null && dataRow["후기작성여부"].ToString() == "후기없음" && dataRow["주문상태"].ToString() == "주문완료")
                        {
                            ListViewItem lvi1 = new ListViewItem(dataRow["주문번호"].ToString());
                            lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                            lvi1.SubItems.Add(dataRow["주문날짜"].ToString());
                            lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                            lvi1.SubItems.Add(dataRow["상품가격"].ToString());
                            listView1.Items.Add(lvi1);
                        }
                    }

                    try
                    {
                        this.listView1.Items[0].Focused = true;
                        this.listView1.Items[0].Selected = true;
                    }
                    catch (System.Exception ex)
                    {

                    }

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("이미 후기를 작성한 상품입니다");
                    후기제목textBox.Text = string.Empty;
                    후기내용textBox.Text = string.Empty;
                }
            }


    
            }


        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            회원화면 showForm = new 회원화면();
            showForm.ShowDialog();
        }

        private void 검색button_Click(object sender, EventArgs e)
        {
            if (후기VIEWBindingSource.Filter != null)
            {
                후기VIEWBindingSource.RemoveFilter();
                검색button.Text = "검색";
            }
            else
            {
                후기VIEWBindingSource.Filter = "상품이름= '" + 검색textBox.Text + "'";
                검색button.Text = "검색해제";
            }
        }

        private void 목록(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int SelectRow = listView1.SelectedItems[0].Index;
                string 주문번호 = listView1.Items[SelectRow].SubItems[0].Text;
                string 상품이름 = listView1.Items[SelectRow].SubItems[1].Text;

                리뷰번호label.Text = 주문번호;
                상품이름label.Text = 상품이름;
            }
        }

        private void 후기목록클릭(object sender, DataGridViewCellEventArgs e)
        {
            string val = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            후기TableAdapter1.Fill(dataSet11.후기);
            mytable = dataSet11.Tables["후기"];

            DataRow foundRows = mytable.Rows.Find(val);

            if (foundRows != null)
            {
                후기내용2textBox.Text = foundRows["리뷰내용"].ToString();
                제목내용label.Text = foundRows["리뷰제목"].ToString();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
