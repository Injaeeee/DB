
namespace 기말프로젝트
{
    partial class 고객관리
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.구매횟수label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.회원BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.환불횟수label = new System.Windows.Forms.Label();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.회원TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.회원TableAdapter();
            this.저장button = new System.Windows.Forms.Button();
            this.메인button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.고객이름label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.회원IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원비밀번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원이름DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원전화번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원이메일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원가입날짜DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총구매액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원타입DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.회원BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 구매횟수label
            // 
            this.구매횟수label.AutoSize = true;
            this.구매횟수label.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.구매횟수label.Location = new System.Drawing.Point(912, 163);
            this.구매횟수label.Name = "구매횟수label";
            this.구매횟수label.Size = new System.Drawing.Size(96, 28);
            this.구매횟수label.TabIndex = 0;
            this.구매횟수label.Text = "구매횟수";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔바른고딕OTF", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.회원IDDataGridViewTextBoxColumn,
            this.회원비밀번호DataGridViewTextBoxColumn,
            this.회원이름DataGridViewTextBoxColumn,
            this.회원전화번호DataGridViewTextBoxColumn,
            this.회원이메일DataGridViewTextBoxColumn,
            this.회원가입날짜DataGridViewTextBoxColumn,
            this.총구매액,
            this.회원타입DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.회원BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(23, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(847, 262);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.정보보기);
            // 
            // 회원BindingSource
            // 
            this.회원BindingSource.DataMember = "회원";
            this.회원BindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 환불횟수label
            // 
            this.환불횟수label.AutoSize = true;
            this.환불횟수label.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.환불횟수label.Location = new System.Drawing.Point(1001, 163);
            this.환불횟수label.Name = "환불횟수label";
            this.환불횟수label.Size = new System.Drawing.Size(96, 28);
            this.환불횟수label.TabIndex = 2;
            this.환불횟수label.Text = "환불횟수";
            // 
            // 주문TableAdapter1
            // 
            this.주문TableAdapter1.ClearBeforeFill = true;
            // 
            // 회원TableAdapter1
            // 
            this.회원TableAdapter1.ClearBeforeFill = true;
            // 
            // 저장button
            // 
            this.저장button.BackColor = System.Drawing.Color.Fuchsia;
            this.저장button.FlatAppearance.BorderSize = 4;
            this.저장button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.저장button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.저장button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.저장button.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.저장button.Location = new System.Drawing.Point(926, 288);
            this.저장button.Name = "저장button";
            this.저장button.Size = new System.Drawing.Size(119, 75);
            this.저장button.TabIndex = 3;
            this.저장button.Text = "회원타입변경";
            this.저장button.UseVisualStyleBackColor = false;
            this.저장button.Click += new System.EventHandler(this.저장button_Click);
            // 
            // 메인button
            // 
            this.메인button.FlatAppearance.BorderSize = 3;
            this.메인button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.메인button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.메인button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(1006, 46);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(75, 43);
            this.메인button.TabIndex = 4;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.메인button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(894, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "구매횟수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(986, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "환불횟수";
            // 
            // 고객이름label
            // 
            this.고객이름label.AutoSize = true;
            this.고객이름label.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.고객이름label.Location = new System.Drawing.Point(894, 115);
            this.고객이름label.Name = "고객이름label";
            this.고객이름label.Size = new System.Drawing.Size(48, 24);
            this.고객이름label.TabIndex = 8;
            this.고객이름label.Text = "고객";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 40);
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
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "고객관리";
            // 
            // 회원IDDataGridViewTextBoxColumn
            // 
            this.회원IDDataGridViewTextBoxColumn.DataPropertyName = "회원ID";
            this.회원IDDataGridViewTextBoxColumn.HeaderText = "회원ID";
            this.회원IDDataGridViewTextBoxColumn.Name = "회원IDDataGridViewTextBoxColumn";
            this.회원IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 회원비밀번호DataGridViewTextBoxColumn
            // 
            this.회원비밀번호DataGridViewTextBoxColumn.DataPropertyName = "회원비밀번호";
            this.회원비밀번호DataGridViewTextBoxColumn.HeaderText = "회원비밀번호";
            this.회원비밀번호DataGridViewTextBoxColumn.Name = "회원비밀번호DataGridViewTextBoxColumn";
            this.회원비밀번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 회원이름DataGridViewTextBoxColumn
            // 
            this.회원이름DataGridViewTextBoxColumn.DataPropertyName = "회원이름";
            this.회원이름DataGridViewTextBoxColumn.HeaderText = "회원이름";
            this.회원이름DataGridViewTextBoxColumn.Name = "회원이름DataGridViewTextBoxColumn";
            this.회원이름DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 회원전화번호DataGridViewTextBoxColumn
            // 
            this.회원전화번호DataGridViewTextBoxColumn.DataPropertyName = "회원전화번호";
            this.회원전화번호DataGridViewTextBoxColumn.HeaderText = "회원전화번호";
            this.회원전화번호DataGridViewTextBoxColumn.Name = "회원전화번호DataGridViewTextBoxColumn";
            this.회원전화번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 회원이메일DataGridViewTextBoxColumn
            // 
            this.회원이메일DataGridViewTextBoxColumn.DataPropertyName = "회원이메일";
            this.회원이메일DataGridViewTextBoxColumn.HeaderText = "회원이메일";
            this.회원이메일DataGridViewTextBoxColumn.Name = "회원이메일DataGridViewTextBoxColumn";
            this.회원이메일DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 회원가입날짜DataGridViewTextBoxColumn
            // 
            this.회원가입날짜DataGridViewTextBoxColumn.DataPropertyName = "회원가입날짜";
            this.회원가입날짜DataGridViewTextBoxColumn.HeaderText = "회원가입날짜";
            this.회원가입날짜DataGridViewTextBoxColumn.Name = "회원가입날짜DataGridViewTextBoxColumn";
            this.회원가입날짜DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 총구매액
            // 
            this.총구매액.DataPropertyName = "총구매액";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.총구매액.DefaultCellStyle = dataGridViewCellStyle2;
            this.총구매액.HeaderText = "총구매액";
            this.총구매액.Name = "총구매액";
            this.총구매액.ReadOnly = true;
            // 
            // 회원타입DataGridViewTextBoxColumn
            // 
            this.회원타입DataGridViewTextBoxColumn.DataPropertyName = "회원타입";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔바른고딕OTF", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.회원타입DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.회원타입DataGridViewTextBoxColumn.HeaderText = "회원타입";
            this.회원타입DataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "우수회원",
            "불량회원",
            "일반회원"});
            this.회원타입DataGridViewTextBoxColumn.Name = "회원타입DataGridViewTextBoxColumn";
            this.회원타입DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.회원타입DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 고객관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.고객이름label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.메인button);
            this.Controls.Add(this.저장button);
            this.Controls.Add(this.환불횟수label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.구매횟수label);
            this.Name = "고객관리";
            this.Load += new System.EventHandler(this.고객관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.회원BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 구매횟수label;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1TableAdapters.회원TableAdapter 회원TableAdapter1;
        private System.Windows.Forms.BindingSource 회원BindingSource;
        private System.Windows.Forms.Label 환불횟수label;
        private System.Windows.Forms.Button 저장button;
        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 고객이름label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원비밀번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원이름DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원전화번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원이메일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원가입날짜DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총구매액;
        private System.Windows.Forms.DataGridViewComboBoxColumn 회원타입DataGridViewTextBoxColumn;
    }
}