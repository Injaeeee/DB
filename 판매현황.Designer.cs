
namespace 기말프로젝트
{
    partial class 판매현황
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.메인button = new System.Windows.Forms.Button();
            this.Alabel = new System.Windows.Forms.Label();
            this.Blabel = new System.Windows.Forms.Label();
            this.Clabel = new System.Windows.Forms.Label();
            this.Dlabel = new System.Windows.Forms.Label();
            this.Elabel = new System.Windows.Forms.Label();
            this.총label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AtextBox = new System.Windows.Forms.TextBox();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.CtextBox = new System.Windows.Forms.TextBox();
            this.DtextBox = new System.Windows.Forms.TextBox();
            this.EtextBox = new System.Windows.Forms.TextBox();
            this.총textBox = new System.Windows.Forms.TextBox();
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.주문상태VIEWTableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문상태VIEWTableAdapter();
            this.dataSet12 = new 기말프로젝트.DataSet1();
            this.dataSet13 = new 기말프로젝트.DataSet1();
            this.dataSet14 = new 기말프로젝트.DataSet1();
            this.dataSet15 = new 기말프로젝트.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).BeginInit();
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
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(629, 63);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(75, 39);
            this.메인button.TabIndex = 0;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alabel
            // 
            this.Alabel.AutoSize = true;
            this.Alabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Alabel.Location = new System.Drawing.Point(36, 163);
            this.Alabel.Name = "Alabel";
            this.Alabel.Size = new System.Drawing.Size(170, 33);
            this.Alabel.TabIndex = 2;
            this.Alabel.Text = "A마트 판매액";
            // 
            // Blabel
            // 
            this.Blabel.AutoSize = true;
            this.Blabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Blabel.Location = new System.Drawing.Point(33, 207);
            this.Blabel.Name = "Blabel";
            this.Blabel.Size = new System.Drawing.Size(169, 33);
            this.Blabel.TabIndex = 3;
            this.Blabel.Text = "B마트 판매액";
            // 
            // Clabel
            // 
            this.Clabel.AutoSize = true;
            this.Clabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clabel.Location = new System.Drawing.Point(36, 253);
            this.Clabel.Name = "Clabel";
            this.Clabel.Size = new System.Drawing.Size(170, 33);
            this.Clabel.TabIndex = 4;
            this.Clabel.Text = "C마트 판매액";
            // 
            // Dlabel
            // 
            this.Dlabel.AutoSize = true;
            this.Dlabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Dlabel.Location = new System.Drawing.Point(36, 302);
            this.Dlabel.Name = "Dlabel";
            this.Dlabel.Size = new System.Drawing.Size(172, 33);
            this.Dlabel.TabIndex = 5;
            this.Dlabel.Text = "D마트 판매액";
            // 
            // Elabel
            // 
            this.Elabel.AutoSize = true;
            this.Elabel.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Elabel.Location = new System.Drawing.Point(38, 347);
            this.Elabel.Name = "Elabel";
            this.Elabel.Size = new System.Drawing.Size(168, 33);
            this.Elabel.TabIndex = 6;
            this.Elabel.Text = "E마트 판매액";
            // 
            // 총label
            // 
            this.총label.AutoSize = true;
            this.총label.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.총label.Location = new System.Drawing.Point(61, 393);
            this.총label.Name = "총label";
            this.총label.Size = new System.Drawing.Size(125, 33);
            this.총label.TabIndex = 7;
            this.총label.Text = "총 판매액";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 26);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 25, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.날짜변경);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Location = new System.Drawing.Point(383, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 26);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2022, 11, 25, 3, 1, 31, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.날짜변경);
            // 
            // AtextBox
            // 
            this.AtextBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AtextBox.Location = new System.Drawing.Point(212, 163);
            this.AtextBox.Name = "AtextBox";
            this.AtextBox.ReadOnly = true;
            this.AtextBox.Size = new System.Drawing.Size(135, 35);
            this.AtextBox.TabIndex = 10;
            // 
            // BtextBox
            // 
            this.BtextBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtextBox.Location = new System.Drawing.Point(212, 207);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.ReadOnly = true;
            this.BtextBox.Size = new System.Drawing.Size(135, 35);
            this.BtextBox.TabIndex = 11;
            // 
            // CtextBox
            // 
            this.CtextBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CtextBox.Location = new System.Drawing.Point(212, 253);
            this.CtextBox.Name = "CtextBox";
            this.CtextBox.ReadOnly = true;
            this.CtextBox.Size = new System.Drawing.Size(135, 35);
            this.CtextBox.TabIndex = 12;
            // 
            // DtextBox
            // 
            this.DtextBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DtextBox.Location = new System.Drawing.Point(212, 300);
            this.DtextBox.Name = "DtextBox";
            this.DtextBox.ReadOnly = true;
            this.DtextBox.Size = new System.Drawing.Size(135, 35);
            this.DtextBox.TabIndex = 13;
            // 
            // EtextBox
            // 
            this.EtextBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EtextBox.Location = new System.Drawing.Point(214, 347);
            this.EtextBox.Name = "EtextBox";
            this.EtextBox.ReadOnly = true;
            this.EtextBox.Size = new System.Drawing.Size(133, 35);
            this.EtextBox.TabIndex = 14;
            // 
            // 총textBox
            // 
            this.총textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.총textBox.Location = new System.Drawing.Point(214, 393);
            this.총textBox.Name = "총textBox";
            this.총textBox.ReadOnly = true;
            this.총textBox.Size = new System.Drawing.Size(133, 35);
            this.총textBox.TabIndex = 15;
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
            // 주문상태VIEWTableAdapter1
            // 
            this.주문상태VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet1";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet14
            // 
            this.dataSet14.DataSetName = "DataSet1";
            this.dataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet15
            // 
            this.dataSet15.DataSetName = "DataSet1";
            this.dataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(336, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "~";
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(353, 145);
            this.chart1.Name = "chart1";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.WideDownwardDiagonal;
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Black;
            series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "판매액";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(351, 300);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 40);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(23, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "판매액현황";
            // 
            // 판매현황
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.총textBox);
            this.Controls.Add(this.EtextBox);
            this.Controls.Add(this.DtextBox);
            this.Controls.Add(this.CtextBox);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.AtextBox);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.총label);
            this.Controls.Add(this.Elabel);
            this.Controls.Add(this.Dlabel);
            this.Controls.Add(this.Clabel);
            this.Controls.Add(this.Blabel);
            this.Controls.Add(this.Alabel);
            this.Controls.Add(this.메인button);
            this.Name = "판매현황";
            this.Load += new System.EventHandler(this.상품현황_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.Label Alabel;
        private System.Windows.Forms.Label Blabel;
        private System.Windows.Forms.Label Clabel;
        private System.Windows.Forms.Label Dlabel;
        private System.Windows.Forms.Label Elabel;
        private System.Windows.Forms.Label 총label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox AtextBox;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.TextBox CtextBox;
        private System.Windows.Forms.TextBox DtextBox;
        private System.Windows.Forms.TextBox EtextBox;
        private System.Windows.Forms.TextBox 총textBox;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private DataSet1TableAdapters.주문상태VIEWTableAdapter 주문상태VIEWTableAdapter1;
        private DataSet1 dataSet12;
        private DataSet1 dataSet13;
        private DataSet1 dataSet14;
        private DataSet1 dataSet15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}