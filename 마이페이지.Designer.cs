
namespace 기말프로젝트
{
    partial class 마이페이지
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(마이페이지));
            this.button1 = new System.Windows.Forms.Button();
            this.회원탈퇴button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.로그아웃button = new System.Windows.Forms.Button();
            this.환불요청button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.주문번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.주문날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.구매매장 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.주문상태 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.상품TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품TableAdapter();
            this.회원TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.회원TableAdapter();
            this.장바구니TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.장바구니TableAdapter();
            this.주문상태VIEWTableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문상태VIEWTableAdapter();
            this.후기TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.후기TableAdapter();
            this.구매label = new System.Windows.Forms.Label();
            this.회원label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(720, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "메인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 회원탈퇴button
            // 
            this.회원탈퇴button.BackColor = System.Drawing.Color.Red;
            this.회원탈퇴button.FlatAppearance.BorderSize = 3;
            this.회원탈퇴button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.회원탈퇴button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.회원탈퇴button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.회원탈퇴button.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.회원탈퇴button.ForeColor = System.Drawing.Color.Black;
            this.회원탈퇴button.Location = new System.Drawing.Point(301, 63);
            this.회원탈퇴button.Name = "회원탈퇴button";
            this.회원탈퇴button.Size = new System.Drawing.Size(127, 49);
            this.회원탈퇴button.TabIndex = 3;
            this.회원탈퇴button.Text = "회원탈퇴";
            this.회원탈퇴button.UseVisualStyleBackColor = false;
            this.회원탈퇴button.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(12, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "고객등급확인";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "구매내역 (영수증)";
            // 
            // 로그아웃button
            // 
            this.로그아웃button.FlatAppearance.BorderSize = 3;
            this.로그아웃button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.로그아웃button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.로그아웃button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.로그아웃button.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.로그아웃button.Location = new System.Drawing.Point(168, 63);
            this.로그아웃button.Name = "로그아웃button";
            this.로그아웃button.Size = new System.Drawing.Size(127, 49);
            this.로그아웃button.TabIndex = 8;
            this.로그아웃button.Text = "로그아웃";
            this.로그아웃button.UseVisualStyleBackColor = true;
            this.로그아웃button.Click += new System.EventHandler(this.로그아웃button_Click);
            // 
            // 환불요청button
            // 
            this.환불요청button.FlatAppearance.BorderSize = 3;
            this.환불요청button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.환불요청button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.환불요청button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.환불요청button.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.환불요청button.Location = new System.Drawing.Point(640, 203);
            this.환불요청button.Name = "환불요청button";
            this.환불요청button.Size = new System.Drawing.Size(107, 70);
            this.환불요청button.TabIndex = 9;
            this.환불요청button.Text = "환불요청";
            this.환불요청button.UseVisualStyleBackColor = true;
            this.환불요청button.Click += new System.EventHandler(this.환불요청button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.주문번호,
            this.상품번호,
            this.상품명,
            this.주문날짜,
            this.구매매장,
            this.가격,
            this.주문상태});
            this.listView1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(622, 393);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 주문번호
            // 
            this.주문번호.Text = "주문번호";
            this.주문번호.Width = 70;
            // 
            // 상품번호
            // 
            this.상품번호.Text = "상품번호";
            this.상품번호.Width = 70;
            // 
            // 상품명
            // 
            this.상품명.Text = "상품명";
            // 
            // 주문날짜
            // 
            this.주문날짜.Text = "주문날짜";
            this.주문날짜.Width = 220;
            // 
            // 구매매장
            // 
            this.구매매장.Text = "매장";
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            // 
            // 주문상태
            // 
            this.주문상태.Text = "주문상태";
            this.주문상태.Width = 70;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 주문TableAdapter1
            // 
            this.주문TableAdapter1.ClearBeforeFill = true;
            // 
            // 상품TableAdapter1
            // 
            this.상품TableAdapter1.ClearBeforeFill = true;
            // 
            // 회원TableAdapter1
            // 
            this.회원TableAdapter1.ClearBeforeFill = true;
            // 
            // 장바구니TableAdapter1
            // 
            this.장바구니TableAdapter1.ClearBeforeFill = true;
            // 
            // 주문상태VIEWTableAdapter1
            // 
            this.주문상태VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // 후기TableAdapter1
            // 
            this.후기TableAdapter1.ClearBeforeFill = true;
            // 
            // 구매label
            // 
            this.구매label.AutoSize = true;
            this.구매label.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.구매label.Location = new System.Drawing.Point(15, 130);
            this.구매label.Name = "구매label";
            this.구매label.Size = new System.Drawing.Size(86, 24);
            this.구매label.TabIndex = 14;
            this.구매label.Text = "총구매액";
            // 
            // 회원label
            // 
            this.회원label.AutoSize = true;
            this.회원label.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.회원label.Location = new System.Drawing.Point(636, 331);
            this.회원label.Name = "회원label";
            this.회원label.Size = new System.Drawing.Size(78, 22);
            this.회원label.TabIndex = 15;
            this.회원label.Text = "회원이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(536, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "선택한 상품을 환불요청합니다";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 356);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 40);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(354, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "마이페이지";
            // 
            // 마이페이지
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.회원label);
            this.Controls.Add(this.구매label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.환불요청button);
            this.Controls.Add(this.로그아웃button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.회원탈퇴button);
            this.Controls.Add(this.button1);
            this.Name = "마이페이지";
            this.Load += new System.EventHandler(this.마이페이지_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button 회원탈퇴button;
        private System.Windows.Forms.Button button4;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private DataSet1TableAdapters.상품TableAdapter 상품TableAdapter1;
        private System.Windows.Forms.Label label2;
        private DataSet1TableAdapters.회원TableAdapter 회원TableAdapter1;
        private System.Windows.Forms.Button 로그아웃button;
        private System.Windows.Forms.Button 환불요청button;
        private DataSet1TableAdapters.장바구니TableAdapter 장바구니TableAdapter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 주문번호;
        private System.Windows.Forms.ColumnHeader 상품번호;
        private System.Windows.Forms.ColumnHeader 상품명;
        private System.Windows.Forms.ColumnHeader 주문날짜;
        private System.Windows.Forms.ColumnHeader 구매매장;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.ColumnHeader 주문상태;
        private DataSet1TableAdapters.주문상태VIEWTableAdapter 주문상태VIEWTableAdapter1;
        private DataSet1TableAdapters.후기TableAdapter 후기TableAdapter1;
        private System.Windows.Forms.Label 구매label;
        private System.Windows.Forms.Label 회원label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}