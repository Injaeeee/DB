
namespace 기말프로젝트
{
    partial class 상품현황
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.판매수량VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.환불수량VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.상품이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.매장 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품TableAdapter();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.판매수량VIEWTableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.판매수량VIEWTableAdapter();
            this.환불수량VIEWTableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.환불수량VIEWTableAdapter();
            this.메인button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.판매수량VIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.환불수량VIEWBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.Title = "상품";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "판매수";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.판매수량VIEWBindingSource;
            legend1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 144);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Fuchsia;
            series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "판매수";
            series1.XValueMember = "상품번호";
            series1.YValueMembers = "판매된수";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(602, 353);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // 판매수량VIEWBindingSource
            // 
            this.판매수량VIEWBindingSource.DataMember = "판매수량VIEW";
            this.판매수량VIEWBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart2
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.Title = "상품";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "반품수";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.환불수량VIEWBindingSource;
            legend2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(871, 144);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Black;
            series2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "반품수";
            series2.XValueMember = "상품번호";
            series2.YValueMembers = "환불된수";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(590, 353);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // 환불수량VIEWBindingSource
            // 
            this.환불수량VIEWBindingSource.DataMember = "환불수량VIEW";
            this.환불수량VIEWBindingSource.DataSource = this.dataSet11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상품이름,
            this.상품번호,
            this.매장});
            this.listView1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(583, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 389);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 상품이름
            // 
            this.상품이름.Text = "상품이름";
            this.상품이름.Width = 80;
            // 
            // 상품번호
            // 
            this.상품번호.Text = "상품번호";
            this.상품번호.Width = 80;
            // 
            // 매장
            // 
            this.매장.Text = "매장";
            // 
            // 상품TableAdapter1
            // 
            this.상품TableAdapter1.ClearBeforeFill = true;
            // 
            // 주문TableAdapter1
            // 
            this.주문TableAdapter1.ClearBeforeFill = true;
            // 
            // 판매수량VIEWTableAdapter1
            // 
            this.판매수량VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // 환불수량VIEWTableAdapter1
            // 
            this.환불수량VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // 메인button
            // 
            this.메인button.FlatAppearance.BorderSize = 3;
            this.메인button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.메인button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.메인button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(1351, 63);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(86, 37);
            this.메인button.TabIndex = 6;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.메인button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(178, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "판매상품수치";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1054, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "반품상품수치";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 42);
            this.panel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(508, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(415, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "판매,환불이 많은 상품 TOP 10";
            // 
            // 상품현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.메인button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "상품현황";
            this.Load += new System.EventHandler(this.상품현황_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.판매수량VIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.환불수량VIEWBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private DataSet1TableAdapters.상품TableAdapter 상품TableAdapter1;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataSet1TableAdapters.판매수량VIEWTableAdapter 판매수량VIEWTableAdapter1;
        private DataSet1TableAdapters.환불수량VIEWTableAdapter 환불수량VIEWTableAdapter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource 환불수량VIEWBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 상품이름;
        private System.Windows.Forms.ColumnHeader 상품번호;
        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource 판매수량VIEWBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader 매장;
    }
}