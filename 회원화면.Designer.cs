
namespace 기말프로젝트
{
    partial class 회원화면
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(회원화면));
            this.상품구매button = new System.Windows.Forms.Button();
            this.마이페이지button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.로그아웃button = new System.Windows.Forms.Button();
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.공지button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.회원TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.회원TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 상품구매button
            // 
            this.상품구매button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.상품구매button.FlatAppearance.BorderSize = 6;
            this.상품구매button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.상품구매button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.상품구매button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.상품구매button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.상품구매button.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품구매button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.상품구매button.Location = new System.Drawing.Point(47, 118);
            this.상품구매button.Name = "상품구매button";
            this.상품구매button.Size = new System.Drawing.Size(278, 149);
            this.상품구매button.TabIndex = 0;
            this.상품구매button.Text = "상품구매";
            this.상품구매button.UseVisualStyleBackColor = true;
            this.상품구매button.Click += new System.EventHandler(this.button1_Click);
            // 
            // 마이페이지button
            // 
            this.마이페이지button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.마이페이지button.FlatAppearance.BorderSize = 6;
            this.마이페이지button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.마이페이지button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.마이페이지button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.마이페이지button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.마이페이지button.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.마이페이지button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.마이페이지button.Location = new System.Drawing.Point(331, 118);
            this.마이페이지button.Name = "마이페이지button";
            this.마이페이지button.Size = new System.Drawing.Size(278, 149);
            this.마이페이지button.TabIndex = 1;
            this.마이페이지button.Text = "마이페이지";
            this.마이페이지button.UseVisualStyleBackColor = true;
            this.마이페이지button.Click += new System.EventHandler(this.마이페이지button_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 6;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(47, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 147);
            this.button2.TabIndex = 2;
            this.button2.Text = "상품후기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 로그아웃button
            // 
            this.로그아웃button.FlatAppearance.BorderSize = 3;
            this.로그아웃button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.로그아웃button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.로그아웃button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.로그아웃button.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.로그아웃button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.로그아웃button.Location = new System.Drawing.Point(678, 54);
            this.로그아웃button.Name = "로그아웃button";
            this.로그아웃button.Size = new System.Drawing.Size(99, 36);
            this.로그아웃button.TabIndex = 4;
            this.로그아웃button.Text = "로그아웃";
            this.로그아웃button.UseVisualStyleBackColor = true;
            this.로그아웃button.Click += new System.EventHandler(this.로그아웃button_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 공지button
            // 
            this.공지button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.공지button.FlatAppearance.BorderSize = 6;
            this.공지button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.공지button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.공지button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.공지button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.공지button.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.공지button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.공지button.Location = new System.Drawing.Point(331, 273);
            this.공지button.Name = "공지button";
            this.공지button.Size = new System.Drawing.Size(278, 147);
            this.공지button.TabIndex = 7;
            this.공지button.Text = "공지사항";
            this.공지button.UseVisualStyleBackColor = true;
            this.공지button.Click += new System.EventHandler(this.공지button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(42, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 28);
            this.label.TabIndex = 8;
            this.label.Text = "고객환영";
            // 
            // 회원TableAdapter1
            // 
            this.회원TableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 39);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(323, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "CATS마트";
            // 
            // 회원화면
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.로그아웃button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.공지button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.마이페이지button);
            this.Controls.Add(this.상품구매button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "회원화면";
            this.Load += new System.EventHandler(this.회원화면_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 상품구매button;
        private System.Windows.Forms.Button 마이페이지button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button 로그아웃button;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button 공지button;
        private System.Windows.Forms.Label label;
        private DataSet1TableAdapters.회원TableAdapter 회원TableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}