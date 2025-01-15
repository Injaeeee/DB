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
    public partial class 회원가입 : MetroForm
    {
        DataTable mytable;
        Boolean 중복체크 = false;
        Boolean 중복체크확인 = false;
        public 회원가입()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            회원TableAdapter1.Fill(dataSet11.회원);
            mytable = dataSet11.Tables["회원"];
            DataRow mynewDataRow = mytable.NewRow();

            mynewDataRow["회원이름"] = textBox1.Text;
            if (this.textBox1.Text == string.Empty)
            {
                MessageBox.Show("이름을 입력해주세요!");

                //종료 - 메서드를 종료

                return;
            }
            mynewDataRow["회원ID"] = textBox2.Text;
            if (this.textBox2.Text == string.Empty)
            {
                MessageBox.Show("아이디를 입력해주세요!");

                //종료 - 메서드를 종료

                return;

            }
            mynewDataRow["회원비밀번호"] = textBox3.Text;
            if (this.textBox3.Text == string.Empty)
            {
                MessageBox.Show("비밀번호를 입력해주세요!");

                //종료 - 메서드를 종료

                return;

            }
            if (this.textBox7.Text == string.Empty)
            {
                MessageBox.Show("비밀번호확인을 입력해주세요!");

                //종료 - 메서드를 종료

                return;

            }
            if (textBox7.Text != textBox3.Text)
            {
                MessageBox.Show("비밀번호 확인이 일치하지 않습니다");

                return;
            }


            mynewDataRow["회원전화번호"] = textBox4.Text;
            if (this.textBox4.Text == string.Empty)
            {
                MessageBox.Show("전화번호를 입력해주세요!");

                //종료 - 메서드를 종료

                return;

            }
            mynewDataRow["회원이메일"] = textBox5.Text;
            if (this.textBox5.Text == string.Empty)
            {
                MessageBox.Show("이메일을 입력해주세요!");

                //종료 - 메서드를 종료

                return;

            }

            if (중복체크 == false)
            {
                MessageBox.Show("아이디 중복체크를 해주세요!");

                return;
            }
            else if (중복체크확인 == false){
                MessageBox.Show("중복된 아이디로 사용하실 수 없습니다");

                return;
            }

            mynewDataRow["회원타입"] = "일반회원";
            mynewDataRow["총구매액"] = "0";
            mytable.Rows.Add(mynewDataRow);
            int numOfRows = 회원TableAdapter1.Update(dataSet11.회원);
            if (numOfRows < 1)
                MessageBox.Show("회원 정보를 입력해주세요");
            else
            {
                MessageBox.Show("CATS마트에 회원가입 되신 걸 환영합니다!");
                this.Visible = false;
                로그인 showForm2 = new 로그인();
                showForm2.ShowDialog();     // show를 showDialog로 바꿔줌
            }


        }

                                                                      

        private void button2_Click(object sender, EventArgs e)
        {
            회원TableAdapter1.Fill(dataSet11.회원);
            mytable = dataSet11.Tables["회원"];


            DataRow dataRow = mytable.Rows.Find(textBox2.Text);


            if (dataRow != null && dataRow["회원ID"].ToString() == textBox2.Text)
            {
                MessageBox.Show("이미 사용 중인 아이디입니다");
                중복체크확인 = false;
            }
            else if (this.textBox2.Text == string.Empty)
                MessageBox.Show("아이디를 입력하세요");
            else
            {
                MessageBox.Show("사용가능한 아이디입니다");
                중복체크확인 = true;
            }


            중복체크 = true;
        }

        private void TEXTCHANGE(object sender, EventArgs e)
        {
              중복체크 = false;
              중복체크확인 = false;
        }

        private void 로그인창button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 showForm = new 로그인();
            showForm.ShowDialog();     // show를 showDialog로 바꿔줌
        }

        private void 회원가입_Load(object sender, EventArgs e)
        {

        }
    }
}
