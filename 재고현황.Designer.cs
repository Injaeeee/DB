
namespace 기말프로젝트
{
    partial class 재고현황
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.메인button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.상품타입listBox = new System.Windows.Forms.ListBox();
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.상품타입TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품타입TableAdapter();
            this.상품TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품TableAdapter();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.재고현황listView = new System.Windows.Forms.ListView();
            this.상품번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.매장ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.판매가능상품 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.반품된수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 메인button
            // 
            this.메인button.FlatAppearance.BorderSize = 3;
            this.메인button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.메인button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.메인button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(872, 49);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(92, 31);
            this.메인button.TabIndex = 0;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.메인button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox1.Location = new System.Drawing.Point(30, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.매장);
            // 
            // 상품타입listBox
            // 
            this.상품타입listBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품타입listBox.FormattingEnabled = true;
            this.상품타입listBox.ItemHeight = 14;
            this.상품타입listBox.Location = new System.Drawing.Point(30, 151);
            this.상품타입listBox.Name = "상품타입listBox";
            this.상품타입listBox.Size = new System.Drawing.Size(181, 326);
            this.상품타입listBox.TabIndex = 2;
            this.상품타입listBox.SelectedIndexChanged += new System.EventHandler(this.상품타입);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 상품타입TableAdapter1
            // 
            this.상품타입TableAdapter1.ClearBeforeFill = true;
            // 
            // 상품TableAdapter1
            // 
            this.상품TableAdapter1.ClearBeforeFill = true;
            // 
            // 주문TableAdapter1
            // 
            this.주문TableAdapter1.ClearBeforeFill = true;
            // 
            // 재고현황listView
            // 
            this.재고현황listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상품번호,
            this.상품이름,
            this.매장ID,
            this.판매가능상품,
            this.반품된수});
            this.재고현황listView.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.재고현황listView.FullRowSelect = true;
            this.재고현황listView.HideSelection = false;
            this.재고현황listView.Location = new System.Drawing.Point(229, 151);
            this.재고현황listView.Name = "재고현황listView";
            this.재고현황listView.Size = new System.Drawing.Size(426, 328);
            this.재고현황listView.TabIndex = 4;
            this.재고현황listView.UseCompatibleStateImageBehavior = false;
            this.재고현황listView.View = System.Windows.Forms.View.Details;
            this.재고현황listView.SelectedIndexChanged += new System.EventHandler(this.상품선택);
            // 
            // 상품번호
            // 
            this.상품번호.Text = "상품번호";
            this.상품번호.Width = 80;
            // 
            // 상품이름
            // 
            this.상품이름.Text = "상품이름";
            this.상품이름.Width = 80;
            // 
            // 매장ID
            // 
            this.매장ID.Text = "매장";
            // 
            // 판매가능상품
            // 
            this.판매가능상품.Text = "판매가능수";
            this.판매가능상품.Width = 90;
            // 
            // 반품된수
            // 
            this.반품된수.Text = "반품된수";
            this.반품된수.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "매장을선택하세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "상품타입을선택하세요";
            // 
            // chart1
            // 
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(661, 149);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "판매가능수";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Black;
            series4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "반품된수";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(317, 344);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 43);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "재고현황";
            // 
            // 재고현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.재고현황listView);
            this.Controls.Add(this.상품타입listBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.메인button);
            this.Name = "재고현황";
            this.Load += new System.EventHandler(this.재고현황_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox 상품타입listBox;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.상품타입TableAdapter 상품타입TableAdapter1;
        private DataSet1TableAdapters.상품TableAdapter 상품TableAdapter1;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private System.Windows.Forms.ListView 재고현황listView;
        private System.Windows.Forms.ColumnHeader 상품번호;
        private System.Windows.Forms.ColumnHeader 상품이름;
        private System.Windows.Forms.ColumnHeader 매장ID;
        private System.Windows.Forms.ColumnHeader 판매가능상품;
        private System.Windows.Forms.ColumnHeader 반품된수;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}