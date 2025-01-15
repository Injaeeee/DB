
namespace 기말프로젝트
{
    partial class 승인목록
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.주문상태VIEWTableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문상태VIEWTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.주문상태VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.주문번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문날짜DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문상태DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판매담당자IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품개수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품가격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품이름DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.주문상태VIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 주문상태VIEWTableAdapter1
            // 
            this.주문상태VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른고딕OTF", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.주문번호DataGridViewTextBoxColumn,
            this.주문날짜DataGridViewTextBoxColumn,
            this.주문상태DataGridViewTextBoxColumn,
            this.회원IDDataGridViewTextBoxColumn,
            this.상품번호DataGridViewTextBoxColumn,
            this.판매담당자IDDataGridViewTextBoxColumn,
            this.상품개수DataGridViewTextBoxColumn,
            this.상품가격DataGridViewTextBoxColumn,
            this.상품이름DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.주문상태VIEWBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(22, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(905, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // 주문상태VIEWBindingSource
            // 
            this.주문상태VIEWBindingSource.DataMember = "주문상태VIEW";
            this.주문상태VIEWBindingSource.DataSource = this.dataSet11;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(858, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "메인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "담당자님이 승인한 상품목록";
            // 
            // 주문번호DataGridViewTextBoxColumn
            // 
            this.주문번호DataGridViewTextBoxColumn.DataPropertyName = "주문번호";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문번호DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.주문번호DataGridViewTextBoxColumn.HeaderText = "주문번호";
            this.주문번호DataGridViewTextBoxColumn.Name = "주문번호DataGridViewTextBoxColumn";
            this.주문번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.주문번호DataGridViewTextBoxColumn.Width = 80;
            // 
            // 주문날짜DataGridViewTextBoxColumn
            // 
            this.주문날짜DataGridViewTextBoxColumn.DataPropertyName = "판매날짜";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔바른고딕OTF", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문날짜DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.주문날짜DataGridViewTextBoxColumn.HeaderText = "판매날짜";
            this.주문날짜DataGridViewTextBoxColumn.Name = "주문날짜DataGridViewTextBoxColumn";
            this.주문날짜DataGridViewTextBoxColumn.ReadOnly = true;
            this.주문날짜DataGridViewTextBoxColumn.Width = 190;
            // 
            // 주문상태DataGridViewTextBoxColumn
            // 
            this.주문상태DataGridViewTextBoxColumn.DataPropertyName = "주문상태";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문상태DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.주문상태DataGridViewTextBoxColumn.HeaderText = "주문상태";
            this.주문상태DataGridViewTextBoxColumn.Name = "주문상태DataGridViewTextBoxColumn";
            this.주문상태DataGridViewTextBoxColumn.ReadOnly = true;
            this.주문상태DataGridViewTextBoxColumn.Width = 80;
            // 
            // 회원IDDataGridViewTextBoxColumn
            // 
            this.회원IDDataGridViewTextBoxColumn.DataPropertyName = "회원ID";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.회원IDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.회원IDDataGridViewTextBoxColumn.HeaderText = "회원ID";
            this.회원IDDataGridViewTextBoxColumn.Name = "회원IDDataGridViewTextBoxColumn";
            this.회원IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.회원IDDataGridViewTextBoxColumn.Width = 90;
            // 
            // 상품번호DataGridViewTextBoxColumn
            // 
            this.상품번호DataGridViewTextBoxColumn.DataPropertyName = "상품번호";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품번호DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.상품번호DataGridViewTextBoxColumn.HeaderText = "상품번호";
            this.상품번호DataGridViewTextBoxColumn.Name = "상품번호DataGridViewTextBoxColumn";
            this.상품번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.상품번호DataGridViewTextBoxColumn.Width = 80;
            // 
            // 판매담당자IDDataGridViewTextBoxColumn
            // 
            this.판매담당자IDDataGridViewTextBoxColumn.DataPropertyName = "판매담당자ID";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.판매담당자IDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.판매담당자IDDataGridViewTextBoxColumn.HeaderText = "판매담당자";
            this.판매담당자IDDataGridViewTextBoxColumn.Name = "판매담당자IDDataGridViewTextBoxColumn";
            this.판매담당자IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 상품개수DataGridViewTextBoxColumn
            // 
            this.상품개수DataGridViewTextBoxColumn.DataPropertyName = "상품개수";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품개수DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.상품개수DataGridViewTextBoxColumn.HeaderText = "상품개수";
            this.상품개수DataGridViewTextBoxColumn.Name = "상품개수DataGridViewTextBoxColumn";
            this.상품개수DataGridViewTextBoxColumn.ReadOnly = true;
            this.상품개수DataGridViewTextBoxColumn.Width = 80;
            // 
            // 상품가격DataGridViewTextBoxColumn
            // 
            this.상품가격DataGridViewTextBoxColumn.DataPropertyName = "상품가격";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품가격DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.상품가격DataGridViewTextBoxColumn.HeaderText = "상품가격";
            this.상품가격DataGridViewTextBoxColumn.Name = "상품가격DataGridViewTextBoxColumn";
            this.상품가격DataGridViewTextBoxColumn.ReadOnly = true;
            this.상품가격DataGridViewTextBoxColumn.Width = 80;
            // 
            // 상품이름DataGridViewTextBoxColumn
            // 
            this.상품이름DataGridViewTextBoxColumn.DataPropertyName = "상품이름";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품이름DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.상품이름DataGridViewTextBoxColumn.HeaderText = "상품이름";
            this.상품이름DataGridViewTextBoxColumn.Name = "상품이름DataGridViewTextBoxColumn";
            this.상품이름DataGridViewTextBoxColumn.ReadOnly = true;
            this.상품이름DataGridViewTextBoxColumn.Width = 80;
            // 
            // 승인목록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "승인목록";
            this.Load += new System.EventHandler(this.승인목록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.주문상태VIEWBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet11;
        private DataSet1TableAdapters.주문상태VIEWTableAdapter 주문상태VIEWTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 주문상태VIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매장IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문날짜DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문상태DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판매담당자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품개수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품가격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품이름DataGridViewTextBoxColumn;
    }
}