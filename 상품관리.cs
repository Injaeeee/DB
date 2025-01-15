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
    public partial class 상품관리 : MetroForm
    {
        DataTable mytable;
        DataTable mytable2;
        public 상품관리()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void 입고button_Click(object sender, EventArgs e)
        {
            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];

            try
            {
                if (상품번호textBox.Text == string.Empty)
                {
                    MessageBox.Show("입고할 상품의 번호를 입력하세요");
                }
                else if (상품이름textBox.Text == string.Empty)
                {
                    MessageBox.Show("입고할 상품의 이름을 입력하세요");
                }
                else if (상품가격textBox.Text == string.Empty)
                {
                    MessageBox.Show("입고할 상품의 가격을 입력하세요");
                }
                else if (상품개수textBox.Text == string.Empty)
                {
                    MessageBox.Show("입고할 상품의 개수를 입력하세요");
                }
                else
                {
                    DataRow newDataRow = mytable.NewRow();
                    newDataRow["상품번호"] = 상품번호textBox.Text;
                    newDataRow["상품이름"] = 상품이름textBox.Text;
                    newDataRow["상품가격"] = 상품가격textBox.Text;
                    newDataRow["상품개수"] = 상품개수textBox.Text;
                    newDataRow["매장ID"] = 매장comboBox.SelectedItem.ToString();
                    newDataRow["상품타입"] = 상품타입comboBox.SelectedItem.ToString();


                    mytable.Rows.Add(newDataRow);

                    상품TableAdapter1.Update(dataSet11.상품);
                    MessageBox.Show("신규 상품을 입고 완료했습니다");

                    상품번호textBox.Text = string.Empty;
                    상품이름textBox.Text = string.Empty;
                    상품가격textBox.Text = string.Empty;
                    상품개수textBox.Text = string.Empty;
                }
            }
            catch (System.Data.ConstraintException)
            {
                MessageBox.Show("이미 존재하는 상품번호입니다");
            }

        }

        private void 상품입고_Load(object sender, EventArgs e)
        {
            매장comboBox.SelectedIndex = 0;


            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable = dataSet11.Tables["상품타입"];


            foreach (DataRow mydataRow in mytable.Rows)
            {
                상품타입comboBox.Items.Add(mydataRow["상품타입"]);
            }
            상품타입comboBox.SelectedIndex = 0;

            매장comboBox1.SelectedIndex = 0;


            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable2 = dataSet11.Tables["상품타입"];

            foreach (DataRow mydataRow in mytable2.Rows)
            {
                상품타입comboBox1.Items.Add(mydataRow["상품타입"]);
            }
           // 상품타입comboBox1.SelectedIndex = 0;

        }

        private void 번호만(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리             
            {
                e.Handled = true;
            }
        }

        private void 매장변경(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];


            foreach (DataRow dataRow in mytable.Rows)
            {
                if (dataRow["매장ID"].ToString() == 매장comboBox1.SelectedItem.ToString() && mytable != null)
                {
                    ListViewItem lvi1 = new ListViewItem(dataRow["상품번호"].ToString());
                    lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                    lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                    lvi1.SubItems.Add(dataRow["상품개수"].ToString());
                    lvi1.SubItems.Add(dataRow["상품가격"].ToString());
                    listView1.Items.Add(lvi1);
                }
            }


                this.listView1.Items[0].Focused = true;
                this.listView1.Items[0].Selected = true;

        }

        private void 상품타입변경(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];

            foreach (DataRow dataRow in mytable.Rows)
            {

                if (dataRow["매장ID"].ToString() == 매장comboBox1.SelectedItem.ToString() && dataRow["상품타입"].ToString() == 상품타입comboBox1.SelectedItem.ToString()&& mytable != null)
                {
                    ListViewItem lvi1 = new ListViewItem(dataRow["상품번호"].ToString());
                    lvi1.SubItems.Add(dataRow["상품이름"].ToString());
                    lvi1.SubItems.Add(dataRow["매장ID"].ToString());
                    lvi1.SubItems.Add(dataRow["상품개수"].ToString());
                    lvi1.SubItems.Add(dataRow["상품가격"].ToString());
                    listView1.Items.Add(lvi1);

                }

            }
        }

        private void 재고추가button_Click(object sender, EventArgs e)
        {
            if (추가할재고textBox.Text == string.Empty)
            {
                MessageBox.Show("추가할 재고의 수량을 입력하세요");
            }
            else
            {

                int SelectRow = listView1.SelectedItems[0].Index;

                string 상품번호 = listView1.Items[SelectRow].SubItems[0].Text;

                string 상품이름 = listView1.Items[SelectRow].SubItems[1].Text;

                this.상품TableAdapter1.Fill(this.dataSet11.상품);
                mytable = dataSet11.Tables["상품"];

                DataRow dataRow = mytable.Rows.Find(상품번호);
                int 추가전재고 = Convert.ToInt32(dataRow["상품개수"].ToString());
                int 추가할재고 = Convert.ToInt32(추가할재고textBox.Text.ToString());
                상품TableAdapter1.상품재고추가(추가할재고, dataRow["상품번호"].ToString());


                this.상품TableAdapter1.Fill(this.dataSet11.상품);
                mytable2 = dataSet11.Tables["상품"];

                DataRow dataRow2 = mytable2.Rows.Find(상품번호);

                listView1.Items[SelectRow].SubItems[3].Text = dataRow2["상품개수"].ToString();
                MessageBox.Show("상품" + 상품번호 + "번 " + 상품이름 + "의 재고를 " + 추가전재고.ToString() + "개에서 "
                    + 추가할재고.ToString() + "개 추가하여 " + dataRow2["상품개수"].ToString() + "개로 갱신하였습니다");
                추가할재고textBox.Text = string.Empty;
            }


        }

        private void 가격변경button_Click(object sender, EventArgs e)
        {
            if (변경할가격textBox.Text == string.Empty)
            {
                MessageBox.Show("변경할가격을 입력하세요");
            }
            else
            {
                int SelectRow = listView1.SelectedItems[0].Index;

                string 상품번호 = listView1.Items[SelectRow].SubItems[0].Text;

                string 상품이름 = listView1.Items[SelectRow].SubItems[1].Text;

                this.상품TableAdapter1.Fill(this.dataSet11.상품);
                mytable = dataSet11.Tables["상품"];

                DataRow dataRow = mytable.Rows.Find(상품번호);
                int 변경전가격 = Convert.ToInt32(dataRow["상품가격"].ToString());
                int 변경할가격 = Convert.ToInt32(변경할가격textBox.Text.ToString());
                상품TableAdapter1.상품가격변경(변경할가격, dataRow["상품번호"].ToString());


                this.상품TableAdapter1.Fill(this.dataSet11.상품);
                mytable2 = dataSet11.Tables["상품"];

                DataRow dataRow2 = mytable2.Rows.Find(상품번호);

                listView1.Items[SelectRow].SubItems[4].Text = dataRow2["상품가격"].ToString();
                MessageBox.Show("상품" + 상품번호 + "번 " + 상품이름 + "의 가격을 " + 변경전가격.ToString() + "원에서 "
                  + dataRow2["상품가격"].ToString() + "원으로 변경하였습니다");
                변경할가격textBox.Text = string.Empty;
            }
        }

        private void 메인button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자화면 showForm = new 관리자화면();
            showForm.ShowDialog();
        }

    }
}
