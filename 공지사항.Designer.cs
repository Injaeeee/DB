
namespace 기말프로젝트
{
    partial class 공지사항
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
            this.내용textBox = new System.Windows.Forms.TextBox();
            this.제목textBox = new System.Windows.Forms.TextBox();
            this.작성button = new System.Windows.Forms.Button();
            this.메인button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.공지사항TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.공지사항TableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 내용textBox
            // 
            this.내용textBox.Location = new System.Drawing.Point(40, 211);
            this.내용textBox.Multiline = true;
            this.내용textBox.Name = "내용textBox";
            this.내용textBox.Size = new System.Drawing.Size(397, 337);
            this.내용textBox.TabIndex = 2;
            // 
            // 제목textBox
            // 
            this.제목textBox.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제목textBox.Location = new System.Drawing.Point(40, 154);
            this.제목textBox.Name = "제목textBox";
            this.제목textBox.Size = new System.Drawing.Size(272, 25);
            this.제목textBox.TabIndex = 3;
            // 
            // 작성button
            // 
            this.작성button.FlatAppearance.BorderSize = 5;
            this.작성button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.작성button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.작성button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.작성button.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.작성button.Location = new System.Drawing.Point(318, 150);
            this.작성button.Name = "작성button";
            this.작성button.Size = new System.Drawing.Size(119, 55);
            this.작성button.TabIndex = 4;
            this.작성button.Text = "공지작성";
            this.작성button.UseVisualStyleBackColor = true;
            this.작성button.Click += new System.EventHandler(this.작성button_Click);
            // 
            // 메인button
            // 
            this.메인button.FlatAppearance.BorderSize = 3;
            this.메인button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.메인button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.메인button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(362, 46);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(75, 41);
            this.메인button.TabIndex = 1;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.메인button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "일반공지",
            "상품입고",
            "가격변경"});
            this.comboBox1.Location = new System.Drawing.Point(40, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 공지사항TableAdapter1
            // 
            this.공지사항TableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox2.Location = new System.Drawing.Point(191, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "공지할매장";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(187, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "공지유형";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "공지제목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "공지내용";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 40);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(22, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "공지사항";
            // 
            // 공지사항
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.내용textBox);
            this.Controls.Add(this.메인button);
            this.Controls.Add(this.제목textBox);
            this.Controls.Add(this.작성button);
            this.Name = "공지사항";
            this.Load += new System.EventHandler(this.공지사항_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.TextBox 내용textBox;
        private System.Windows.Forms.TextBox 제목textBox;
        private System.Windows.Forms.Button 작성button;
        private DataSet1TableAdapters.공지사항TableAdapter 공지사항TableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}