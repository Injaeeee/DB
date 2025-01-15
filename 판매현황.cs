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
    public partial class 판매현황 : MetroForm
    {
        DataTable mytableA;
        DataTable mytableB;
        DataTable mytableC;
        DataTable mytableD;
        DataTable mytableE;

        public static int 판매액A;
        public static int 판매액B;
        public static int 판매액C;
        public static int 판매액D;
        public static int 판매액E;

        public 판매현황()
        {
            InitializeComponent();
        }

        private void 상품현황_Load(object sender, EventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            관리자화면 showForm = new 관리자화면();
            showForm.ShowDialog();
        }

        private void 날짜변경(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value <= dateTimePicker2.Value)
            {

                string day = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string day2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                주문상태VIEWTableAdapter1.날짜판매액(dataSet11.주문상태VIEW,"A", day, day2);
                주문상태VIEWTableAdapter1.날짜판매액(dataSet12.주문상태VIEW, "B", day, day2);
                주문상태VIEWTableAdapter1.날짜판매액(dataSet13.주문상태VIEW, "C", day, day2);
                주문상태VIEWTableAdapter1.날짜판매액(dataSet14.주문상태VIEW, "D", day, day2);
                주문상태VIEWTableAdapter1.날짜판매액(dataSet15.주문상태VIEW, "E", day, day2);

                mytableA = dataSet11.Tables["주문상태VIEW"];
                foreach (DataRow mydataRow in mytableA.Rows)
                {
                    판매액A += Convert.ToInt32(mydataRow["상품가격"]);

                }
                mytableB = dataSet12.Tables["주문상태VIEW"];
                foreach (DataRow mydataRow in mytableB.Rows)
                {
                    판매액B += Convert.ToInt32(mydataRow["상품가격"]);

                }
                mytableC = dataSet13.Tables["주문상태VIEW"];
                foreach (DataRow mydataRow in mytableC.Rows)
                {
                    판매액C += Convert.ToInt32(mydataRow["상품가격"]);

                }
                mytableD = dataSet14.Tables["주문상태VIEW"];
                foreach (DataRow mydataRow in mytableD.Rows)
                {
                    판매액D += Convert.ToInt32(mydataRow["상품가격"]);

                }
                mytableE = dataSet15.Tables["주문상태VIEW"];
                foreach (DataRow mydataRow in mytableE.Rows)
                {
                    판매액E += Convert.ToInt32(mydataRow["상품가격"]);

                }


                AtextBox.Text = 판매액A.ToString();
                BtextBox.Text = 판매액B.ToString();
                CtextBox.Text = 판매액C.ToString();
                DtextBox.Text = 판매액D.ToString();
                EtextBox.Text = 판매액E.ToString();
                총textBox.Text = (판매액A + 판매액B + 판매액C + 판매액D +판매액E).ToString();
         
                chart1.Series[0].Points.Clear();
         
                chart1.Series[0].Points.AddXY("A", 판매액A);
                chart1.Series[0].Points.AddXY("B", 판매액B);
                chart1.Series[0].Points.AddXY("C", 판매액C);
                chart1.Series[0].Points.AddXY("D", 판매액D);
                chart1.Series[0].Points.AddXY("E", 판매액E);
                chart1.Series[0].Points.AddXY("총", 판매액A+판매액B+판매액C+판매액D+판매액E);
            
                판매액A = 0;
                판매액B = 0;
                판매액C = 0;
                판매액D = 0;
                판매액E = 0;

            }
            else
            {
                MessageBox.Show("시작날짜가 마지막날짜보다 클 수없습니다");
   
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
