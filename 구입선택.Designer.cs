
namespace 기말프로젝트
{
    partial class 구입선택
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(구입선택));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.상품타입listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.상품번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품이름DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품가격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매장IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품타입DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품개수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.상품이름DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품가격DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매장IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품타입DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.장바구니상품VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.회원화면button = new System.Windows.Forms.Button();
            this.장바구니TableAdapter = new 기말프로젝트.DataSet1TableAdapters.장바구니TableAdapter();
            this.상품타입TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품타입TableAdapter();
            this.장바구니상품VIEWTableAdapter = new 기말프로젝트.DataSet1TableAdapters.장바구니상품VIEWTableAdapter();
            this.상품TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품TableAdapter();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.회원TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.회원TableAdapter();
            this.매장 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.상품BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.장바구니상품VIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "구입할 매장을 선택하세요";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox1.Location = new System.Drawing.Point(29, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 30);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 상품타입listBox
            // 
            this.상품타입listBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품타입listBox.FormattingEnabled = true;
            this.상품타입listBox.ItemHeight = 14;
            this.상품타입listBox.Location = new System.Drawing.Point(31, 152);
            this.상품타입listBox.Name = "상품타입listBox";
            this.상품타입listBox.Size = new System.Drawing.Size(176, 466);
            this.상품타입listBox.TabIndex = 13;
            this.상품타입listBox.SelectedIndexChanged += new System.EventHandler(this.상품종류listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "상품종류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(219, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "상품상세";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(218, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "장바구니";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔바른고딕OTF", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.상품번호DataGridViewTextBoxColumn,
            this.상품이름DataGridViewTextBoxColumn,
            this.상품가격DataGridViewTextBoxColumn,
            this.매장IDDataGridViewTextBoxColumn,
            this.상품타입DataGridViewTextBoxColumn,
            this.상품개수});
            this.dataGridView1.DataSource = this.상품BindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(223, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 229);
            this.dataGridView1.TabIndex = 20;
            // 
            // 상품번호DataGridViewTextBoxColumn
            // 
            this.상품번호DataGridViewTextBoxColumn.DataPropertyName = "상품번호";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품번호DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.상품번호DataGridViewTextBoxColumn.HeaderText = "상품번호";
            this.상품번호DataGridViewTextBoxColumn.Name = "상품번호DataGridViewTextBoxColumn";
            this.상품번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 상품이름DataGridViewTextBoxColumn
            // 
            this.상품이름DataGridViewTextBoxColumn.DataPropertyName = "상품이름";
            this.상품이름DataGridViewTextBoxColumn.HeaderText = "상품이름";
            this.상품이름DataGridViewTextBoxColumn.Name = "상품이름DataGridViewTextBoxColumn";
            this.상품이름DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 상품가격DataGridViewTextBoxColumn
            // 
            this.상품가격DataGridViewTextBoxColumn.DataPropertyName = "상품가격";
            this.상품가격DataGridViewTextBoxColumn.HeaderText = "상품가격";
            this.상품가격DataGridViewTextBoxColumn.Name = "상품가격DataGridViewTextBoxColumn";
            this.상품가격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 매장IDDataGridViewTextBoxColumn
            // 
            this.매장IDDataGridViewTextBoxColumn.DataPropertyName = "매장ID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장IDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.매장IDDataGridViewTextBoxColumn.HeaderText = "매장";
            this.매장IDDataGridViewTextBoxColumn.Name = "매장IDDataGridViewTextBoxColumn";
            this.매장IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.매장IDDataGridViewTextBoxColumn.Width = 55;
            // 
            // 상품타입DataGridViewTextBoxColumn
            // 
            this.상품타입DataGridViewTextBoxColumn.DataPropertyName = "상품타입";
            this.상품타입DataGridViewTextBoxColumn.HeaderText = "상품타입";
            this.상품타입DataGridViewTextBoxColumn.Name = "상품타입DataGridViewTextBoxColumn";
            this.상품타입DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 상품개수
            // 
            this.상품개수.DataPropertyName = "상품개수";
            this.상품개수.HeaderText = "상품개수";
            this.상품개수.Name = "상품개수";
            this.상품개수.ReadOnly = true;
            // 
            // 상품BindingSource
            // 
            this.상품BindingSource.DataMember = "상품";
            this.상품BindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(853, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 91);
            this.button3.TabIndex = 22;
            this.button3.Text = "장바구니담기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔바른고딕OTF", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.상품이름DataGridViewTextBoxColumn1,
            this.상품가격DataGridViewTextBoxColumn1,
            this.매장IDDataGridViewTextBoxColumn1,
            this.상품타입DataGridViewTextBoxColumn1,
            this.상품번호,
            this.회원ID});
            this.dataGridView2.DataSource = this.장바구니상품VIEWBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(223, 394);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(624, 224);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // 상품이름DataGridViewTextBoxColumn1
            // 
            this.상품이름DataGridViewTextBoxColumn1.DataPropertyName = "상품이름";
            this.상품이름DataGridViewTextBoxColumn1.HeaderText = "상품이름";
            this.상품이름DataGridViewTextBoxColumn1.Name = "상품이름DataGridViewTextBoxColumn1";
            this.상품이름DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 상품가격DataGridViewTextBoxColumn1
            // 
            this.상품가격DataGridViewTextBoxColumn1.DataPropertyName = "상품가격";
            this.상품가격DataGridViewTextBoxColumn1.HeaderText = "상품가격";
            this.상품가격DataGridViewTextBoxColumn1.Name = "상품가격DataGridViewTextBoxColumn1";
            this.상품가격DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 매장IDDataGridViewTextBoxColumn1
            // 
            this.매장IDDataGridViewTextBoxColumn1.DataPropertyName = "매장ID";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장IDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.매장IDDataGridViewTextBoxColumn1.HeaderText = "매장";
            this.매장IDDataGridViewTextBoxColumn1.Name = "매장IDDataGridViewTextBoxColumn1";
            this.매장IDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.매장IDDataGridViewTextBoxColumn1.Width = 55;
            // 
            // 상품타입DataGridViewTextBoxColumn1
            // 
            this.상품타입DataGridViewTextBoxColumn1.DataPropertyName = "상품타입";
            this.상품타입DataGridViewTextBoxColumn1.HeaderText = "상품타입";
            this.상품타입DataGridViewTextBoxColumn1.Name = "상품타입DataGridViewTextBoxColumn1";
            this.상품타입DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 상품번호
            // 
            this.상품번호.DataPropertyName = "상품번호";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품번호.DefaultCellStyle = dataGridViewCellStyle8;
            this.상품번호.HeaderText = "상품번호";
            this.상품번호.Name = "상품번호";
            this.상품번호.ReadOnly = true;
            // 
            // 회원ID
            // 
            this.회원ID.DataPropertyName = "회원ID";
            this.회원ID.HeaderText = "회원ID";
            this.회원ID.Name = "회원ID";
            this.회원ID.ReadOnly = true;
            // 
            // 장바구니상품VIEWBindingSource
            // 
            this.장바구니상품VIEWBindingSource.DataMember = "장바구니상품VIEW";
            this.장바구니상품VIEWBindingSource.DataSource = this.dataSet11;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(853, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 91);
            this.button4.TabIndex = 24;
            this.button4.Text = "장바구니삭제";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("나눔바른고딕OTF", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(853, 527);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 91);
            this.button5.TabIndex = 25;
            this.button5.Text = "구입";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // 회원화면button
            // 
            this.회원화면button.FlatAppearance.BorderSize = 3;
            this.회원화면button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.회원화면button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.회원화면button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.회원화면button.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.회원화면button.Location = new System.Drawing.Point(919, 55);
            this.회원화면button.Name = "회원화면button";
            this.회원화면button.Size = new System.Drawing.Size(83, 30);
            this.회원화면button.TabIndex = 28;
            this.회원화면button.Text = "메인";
            this.회원화면button.UseVisualStyleBackColor = true;
            this.회원화면button.Click += new System.EventHandler(this.회원화면button_Click);
            // 
            // 장바구니TableAdapter
            // 
            this.장바구니TableAdapter.ClearBeforeFill = true;
            // 
            // 상품타입TableAdapter1
            // 
            this.상품타입TableAdapter1.ClearBeforeFill = true;
            // 
            // 장바구니상품VIEWTableAdapter
            // 
            this.장바구니상품VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // 상품TableAdapter1
            // 
            this.상품TableAdapter1.ClearBeforeFill = true;
            // 
            // 주문TableAdapter1
            // 
            this.주문TableAdapter1.ClearBeforeFill = true;
            // 
            // 회원TableAdapter1
            // 
            this.회원TableAdapter1.ClearBeforeFill = true;
            // 
            // 매장
            // 
            this.매장.AutoSize = true;
            this.매장.BackColor = System.Drawing.Color.Transparent;
            this.매장.Font = new System.Drawing.Font("나눔바른고딕OTF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장.ForeColor = System.Drawing.Color.White;
            this.매장.Location = new System.Drawing.Point(23, 7);
            this.매장.Name = "매장";
            this.매장.Size = new System.Drawing.Size(85, 43);
            this.매장.TabIndex = 29;
            this.매장.Text = "매장";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.매장);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 50);
            this.panel1.TabIndex = 31;
            // 
            // 구입선택
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.회원화면button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.상품타입listBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "구입선택";
            this.Load += new System.EventHandler(this.구입매장선택_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.상품BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.장바구니상품VIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox 상품타입listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.장바구니TableAdapter 장바구니TableAdapter;
        private DataSet1TableAdapters.상품타입TableAdapter 상품타입TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품위치DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 상품BindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource 장바구니상품VIEWBindingSource;
        private DataSet1TableAdapters.장바구니상품VIEWTableAdapter 장바구니상품VIEWTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DataSet1TableAdapters.상품TableAdapter 상품TableAdapter1;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 유통기한DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button 회원화면button;
        private DataSet1TableAdapters.회원TableAdapter 회원TableAdapter1;
        private System.Windows.Forms.Label 매장;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품이름DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품가격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매장IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품타입DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품개수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품이름DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품가격DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매장IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품타입DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원ID;
    }
}