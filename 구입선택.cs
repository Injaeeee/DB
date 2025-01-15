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
    public partial class 구입선택 : MetroForm
    {

        DataTable mytable;
        DataTable mytable2;

        public 구입선택()
        {
            InitializeComponent();
          
        }
        public static string loginid;


        private void 구입매장선택_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.장바구니상품VIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            comboBox1.SelectedIndex = 0;
            
            this.장바구니상품VIEWTableAdapter.Fill(this.dataSet11.장바구니상품VIEW);
            this.상품TableAdapter1.Fill(this.dataSet11.상품);
            상품타입listBox.Items.Clear();

            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable = dataSet11.Tables["상품타입"];


            foreach (DataRow mydataRow in mytable.Rows)
            {
                상품타입listBox.Items.Add(mydataRow["상품타입"]);
            }
            


        }




        private void 상품종류listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            상품TableAdapter1.Fill(dataSet11.상품);
            mytable = dataSet11.Tables["상품"];

            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable2 = dataSet11.Tables["상품타입"];

            상품BindingSource.Filter = "상품타입= '" + 상품타입listBox.SelectedItem + "' AND 매장ID= '" + comboBox1.SelectedItem + "'";


        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            장바구니TableAdapter.Fill(dataSet11.장바구니);
            mytable = dataSet11.Tables["장바구니"];
            DataRow mynewDataRow = mytable.NewRow();

            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            

            try
            {
                if (selectedCellCount > 0)
                {
                    mynewDataRow["상품번호"] = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    mynewDataRow["회원ID"] = loginid;
                    
                    if (상품TableAdapter1.품절찾기() == dataGridView1.CurrentRow.Cells[0].Value.ToString()) {
                        MessageBox.Show("해당 상품은 품절입니다");
                        return;
                    }
                    else
                    {
                        mytable.Rows.Add(mynewDataRow);
                        
                    }
                }
                else
                {
                    MessageBox.Show("장바구니에 담을 상품을 선택하세요");
                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show("이미 장바구니에 담은 상품입니다");
            }     
                //this.장바구니상품VIEWBindingSource.EndEdit();
                int numOfRows = 장바구니TableAdapter.Update(dataSet11.장바구니);
                if (numOfRows > 0)
                {
   
                    this.장바구니상품VIEWTableAdapter.Fill(this.dataSet11.장바구니상품VIEW);
                    장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= '"+ comboBox1.SelectedItem + "'";
            }

   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            상품타입TableAdapter1.Fill(dataSet11.상품타입);
            mytable = dataSet11.Tables["상품타입"];

            상품TableAdapter1.Fill(dataSet11.상품);
            mytable2 = dataSet11.Tables["상품"];
            
            if (comboBox1.SelectedIndex == 0)
            {
                매장.Text = "A매장";
                매장.ForeColor = Color.Red;
                button3.FlatAppearance.BorderColor = Color.Red;
                button4.FlatAppearance.BorderColor = Color.Red;
                button5.FlatAppearance.BorderColor = Color.Red;
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Red;
                dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Red;
                상품BindingSource.Filter = "매장ID= 'A'";
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= 'A'";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                매장.Text = "B매장";
                매장.ForeColor = Color.DeepSkyBlue;
                button3.FlatAppearance.BorderColor = Color.DeepSkyBlue;
                button4.FlatAppearance.BorderColor = Color.DeepSkyBlue;
                button5.FlatAppearance.BorderColor = Color.DeepSkyBlue;
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DeepSkyBlue;
                dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.DeepSkyBlue;
                상품BindingSource.Filter = "매장ID= 'B'";
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= 'B'";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                매장.Text = "C매장";
                매장.ForeColor = Color.Gold;
                button3.FlatAppearance.BorderColor = Color.Gold;
                button4.FlatAppearance.BorderColor = Color.Gold;
                button5.FlatAppearance.BorderColor = Color.Gold;
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Gold;
                dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Gold;
                상품BindingSource.Filter = "매장ID= 'C'";
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= 'C'";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                매장.Text = "D매장";
                매장.ForeColor = Color.Green;
                button3.FlatAppearance.BorderColor = Color.Green;
                button4.FlatAppearance.BorderColor = Color.Green;
                button5.FlatAppearance.BorderColor = Color.Green;
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
                dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
                상품BindingSource.Filter = "매장ID= 'D'";
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= 'D'";
            }
            else
            {
                매장.Text = "E매장";
                매장.ForeColor = Color.Brown;
                button3.FlatAppearance.BorderColor = Color.Brown;
                button4.FlatAppearance.BorderColor = Color.Brown;
                button5.FlatAppearance.BorderColor = Color.Brown;
                dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Brown;
                dataGridView2.Columns[2].DefaultCellStyle.ForeColor = Color.Brown;
                상품BindingSource.Filter = "매장ID= 'E'";
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= 'E'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // 장바구니상품VIEWBindingSource.RemoveCurrent();
            //this.장바구니TableAdapter1.Update(this.dataSet11.장바구니);

            int 장바구니행개수 = dataGridView2.Rows.Count;
            if (장바구니행개수 <= 0)
            {
                MessageBox.Show("장바구니에 삭제할 상품이 없습니다");

            }
            else
            {
                DataGridViewRow data = dataGridView2.SelectedRows[0];


                string val = data.Cells[4].Value.ToString();
                장바구니TableAdapter.DeleteQuery(val);

                this.장바구니상품VIEWTableAdapter.Fill(this.dataSet11.장바구니상품VIEW);
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= '"+comboBox1.SelectedItem+"'";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int 장바구니행개수 = dataGridView2.Rows.Count;
            int 가격 = 0;


            if (장바구니행개수 >= 5)
            {

                
                상품TableAdapter1.Fill(dataSet11.상품);
                mytable = dataSet11.Tables["상품"];

                //장바구니에 있는 상품을 주문에 넣는 코드
                주문TableAdapter1.Fill(dataSet11.주문);
                mytable2 = dataSet11.Tables["주문"];





                for (int a = 0; a < 장바구니행개수; a++)
                {


                    DataGridViewRow data = dataGridView2.Rows[a];
                    string val = data.Cells[4].Value.ToString();

                    String s = 주문TableAdapter1.시퀀스().ToString();
                    DataRow newDataRow = mytable2.NewRow();
                    newDataRow["주문번호"] = s;
                    newDataRow["주문날짜"] = DateTime.Now.ToString();
                    newDataRow["후기작성여부"] = "후기없음";
                    newDataRow["주문상태"] = "주문요청";
                    newDataRow["회원ID"] = loginid;
                    newDataRow["상품번호"] = val;
                    newDataRow["판매담당자ID"] = "판매자미지정";
                    newDataRow["매장ID"] = comboBox1.SelectedItem;
                    mytable2.Rows.Add(newDataRow);

                        주문TableAdapter1.Update(dataSet11.주문);



                    //총구입액 더하기 (장바구니 구매액)
                    가격 += Convert.ToInt32(data.Cells[1].Value.ToString());;
                }
                회원TableAdapter1.회원구매액(가격, loginid).ToString();
                MessageBox.Show("회원님의 장바구니 구매액은 총" + 가격.ToString() + "원 입니다");



                //장바구니를 비우는 코드

                for (int b = 0; b < 장바구니행개수; b++)
                {
                    DataGridViewRow data2 = dataGridView2.Rows[b];
                    string val2 = data2.Cells[4].Value.ToString();
                    장바구니TableAdapter.DeleteQuery(val2);
                }



                this.장바구니상품VIEWTableAdapter.Fill(this.dataSet11.장바구니상품VIEW);
                장바구니상품VIEWBindingSource.Filter = "회원ID= '" + loginid + "' AND 매장ID= '"+comboBox1.SelectedItem+"'";
            }
            else if(장바구니행개수 == 0)
            {
                MessageBox.Show("구입할 상품을 장바구니에 담아주세요.");
            }
            else
            {
                MessageBox.Show("장바구니에 5개이상의 상품을 담아야 구입이 가능합니다.");
            }

        //    상품BindingSource.Filter = "상품타입= '" + 상품타입listBox.SelectedItem + "' AND 매장ID= '" + comboBox1.SelectedItem + "'";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 회원화면button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            회원화면 showForm = new 회원화면();
            showForm.ShowDialog();
        }

    }
}
