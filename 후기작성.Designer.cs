
namespace 기말프로젝트
{
    partial class 후기작성
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(후기작성));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.리뷰번호label = new System.Windows.Forms.Label();
            this.후기제목textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.주문번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.주문일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.구매매장 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.후기내용textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.상품이름label = new System.Windows.Forms.Label();
            this.작성button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.제목내용label = new System.Windows.Forms.Label();
            this.후기제목label = new System.Windows.Forms.Label();
            this.후기내용label = new System.Windows.Forms.Label();
            this.후기내용2textBox = new System.Windows.Forms.TextBox();
            this.상품명 = new System.Windows.Forms.Label();
            this.검색button = new System.Windows.Forms.Button();
            this.검색textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.리뷰번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.회원IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품타입DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상품이름DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매장IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.리뷰날짜DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.후기VIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.메인button = new System.Windows.Forms.Button();
            this.주문TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문TableAdapter();
            this.상품TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품TableAdapter();
            this.후기TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.후기TableAdapter();
            this.후기VIEWTableAdapter = new 기말프로젝트.DataSet1TableAdapters.후기VIEWTableAdapter();
            this.주문상태VIEWTableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.주문상태VIEWTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.후기VIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(23, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.리뷰번호label);
            this.tabPage1.Controls.Add(this.후기제목textBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.후기내용textBox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.상품이름label);
            this.tabPage1.Controls.Add(this.작성button);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "후기작성";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "주문이 완료된 상품들만 후기를 작성할수있어요!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(894, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "상품이름:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(747, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "리뷰번호:";
            // 
            // 리뷰번호label
            // 
            this.리뷰번호label.AutoSize = true;
            this.리뷰번호label.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.리뷰번호label.Location = new System.Drawing.Point(830, 62);
            this.리뷰번호label.Name = "리뷰번호label";
            this.리뷰번호label.Size = new System.Drawing.Size(60, 17);
            this.리뷰번호label.TabIndex = 5;
            this.리뷰번호label.Text = "리뷰번호";
            // 
            // 후기제목textBox
            // 
            this.후기제목textBox.Location = new System.Drawing.Point(782, 87);
            this.후기제목textBox.Name = "후기제목textBox";
            this.후기제목textBox.Size = new System.Drawing.Size(192, 32);
            this.후기제목textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(735, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "제목";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.주문번호,
            this.상품이름,
            this.주문일,
            this.구매매장,
            this.가격});
            this.listView1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 417);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.목록);
            // 
            // 주문번호
            // 
            this.주문번호.Text = "주문번호";
            this.주문번호.Width = 80;
            // 
            // 상품이름
            // 
            this.상품이름.Text = "상품명";
            this.상품이름.Width = 80;
            // 
            // 주문일
            // 
            this.주문일.Text = "주문일";
            this.주문일.Width = 210;
            // 
            // 구매매장
            // 
            this.구매매장.Text = "구매매장";
            this.구매매장.Width = 80;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.Width = 80;
            // 
            // 후기내용textBox
            // 
            this.후기내용textBox.Location = new System.Drawing.Point(736, 123);
            this.후기내용textBox.Multiline = true;
            this.후기내용textBox.Name = "후기내용textBox";
            this.후기내용textBox.Size = new System.Drawing.Size(317, 352);
            this.후기내용textBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "작성할 후기목록";
            // 
            // 상품이름label
            // 
            this.상품이름label.AutoSize = true;
            this.상품이름label.Font = new System.Drawing.Font("나눔바른고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품이름label.Location = new System.Drawing.Point(977, 62);
            this.상품이름label.Name = "상품이름label";
            this.상품이름label.Size = new System.Drawing.Size(60, 17);
            this.상품이름label.TabIndex = 6;
            this.상품이름label.Text = "상품이름";
            // 
            // 작성button
            // 
            this.작성button.FlatAppearance.BorderSize = 2;
            this.작성button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.작성button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.작성button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.작성button.Font = new System.Drawing.Font("나눔바른고딕OTF", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.작성button.Location = new System.Drawing.Point(980, 87);
            this.작성button.Name = "작성button";
            this.작성button.Size = new System.Drawing.Size(73, 32);
            this.작성button.TabIndex = 1;
            this.작성button.Text = "후기작성";
            this.작성button.UseVisualStyleBackColor = true;
            this.작성button.Click += new System.EventHandler(this.작성button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.제목내용label);
            this.tabPage2.Controls.Add(this.후기제목label);
            this.tabPage2.Controls.Add(this.후기내용label);
            this.tabPage2.Controls.Add(this.후기내용2textBox);
            this.tabPage2.Controls.Add(this.상품명);
            this.tabPage2.Controls.Add(this.검색button);
            this.tabPage2.Controls.Add(this.검색textBox);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "후기목록";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "모든 고객님들의 후기를 볼 수 있어요!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "작성한 후기목록";
            // 
            // 제목내용label
            // 
            this.제목내용label.AutoSize = true;
            this.제목내용label.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제목내용label.Location = new System.Drawing.Point(908, 93);
            this.제목내용label.Name = "제목내용label";
            this.제목내용label.Size = new System.Drawing.Size(64, 18);
            this.제목내용label.TabIndex = 8;
            this.제목내용label.Text = "제목내용";
            // 
            // 후기제목label
            // 
            this.후기제목label.AutoSize = true;
            this.후기제목label.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.후기제목label.Location = new System.Drawing.Point(833, 90);
            this.후기제목label.Name = "후기제목label";
            this.후기제목label.Size = new System.Drawing.Size(78, 22);
            this.후기제목label.TabIndex = 2;
            this.후기제목label.Text = "후기제목";
            // 
            // 후기내용label
            // 
            this.후기내용label.AutoSize = true;
            this.후기내용label.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.후기내용label.Location = new System.Drawing.Point(834, 115);
            this.후기내용label.Name = "후기내용label";
            this.후기내용label.Size = new System.Drawing.Size(64, 18);
            this.후기내용label.TabIndex = 6;
            this.후기내용label.Text = "후기내용";
            // 
            // 후기내용2textBox
            // 
            this.후기내용2textBox.Location = new System.Drawing.Point(836, 136);
            this.후기내용2textBox.Multiline = true;
            this.후기내용2textBox.Name = "후기내용2textBox";
            this.후기내용2textBox.Size = new System.Drawing.Size(224, 333);
            this.후기내용2textBox.TabIndex = 5;
            // 
            // 상품명
            // 
            this.상품명.AutoSize = true;
            this.상품명.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품명.Location = new System.Drawing.Point(23, 62);
            this.상품명.Name = "상품명";
            this.상품명.Size = new System.Drawing.Size(67, 24);
            this.상품명.TabIndex = 4;
            this.상품명.Text = "상품명";
            // 
            // 검색button
            // 
            this.검색button.FlatAppearance.BorderSize = 3;
            this.검색button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.검색button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.검색button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.검색button.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.검색button.Location = new System.Drawing.Point(312, 59);
            this.검색button.Name = "검색button";
            this.검색button.Size = new System.Drawing.Size(83, 32);
            this.검색button.TabIndex = 3;
            this.검색button.Text = "검색";
            this.검색button.UseVisualStyleBackColor = true;
            this.검색button.Click += new System.EventHandler(this.검색button_Click);
            // 
            // 검색textBox
            // 
            this.검색textBox.Location = new System.Drawing.Point(96, 59);
            this.검색textBox.Name = "검색textBox";
            this.검색textBox.Size = new System.Drawing.Size(210, 32);
            this.검색textBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.리뷰번호,
            this.회원IDDataGridViewTextBoxColumn,
            this.상품타입DataGridViewTextBoxColumn,
            this.상품이름DataGridViewTextBoxColumn,
            this.매장IDDataGridViewTextBoxColumn,
            this.리뷰날짜DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.후기VIEWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 372);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.후기목록클릭);
            // 
            // 리뷰번호
            // 
            this.리뷰번호.DataPropertyName = "리뷰번호";
            this.리뷰번호.HeaderText = "리뷰번호";
            this.리뷰번호.Name = "리뷰번호";
            this.리뷰번호.ReadOnly = true;
            this.리뷰번호.Width = 110;
            // 
            // 회원IDDataGridViewTextBoxColumn
            // 
            this.회원IDDataGridViewTextBoxColumn.DataPropertyName = "회원ID";
            this.회원IDDataGridViewTextBoxColumn.HeaderText = "회원ID";
            this.회원IDDataGridViewTextBoxColumn.Name = "회원IDDataGridViewTextBoxColumn";
            this.회원IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.회원IDDataGridViewTextBoxColumn.Width = 110;
            // 
            // 상품타입DataGridViewTextBoxColumn
            // 
            this.상품타입DataGridViewTextBoxColumn.DataPropertyName = "상품타입";
            this.상품타입DataGridViewTextBoxColumn.HeaderText = "상품타입";
            this.상품타입DataGridViewTextBoxColumn.Name = "상품타입DataGridViewTextBoxColumn";
            this.상품타입DataGridViewTextBoxColumn.ReadOnly = true;
            this.상품타입DataGridViewTextBoxColumn.Width = 110;
            // 
            // 상품이름DataGridViewTextBoxColumn
            // 
            this.상품이름DataGridViewTextBoxColumn.DataPropertyName = "상품이름";
            this.상품이름DataGridViewTextBoxColumn.HeaderText = "상품이름";
            this.상품이름DataGridViewTextBoxColumn.Name = "상품이름DataGridViewTextBoxColumn";
            this.상품이름DataGridViewTextBoxColumn.ReadOnly = true;
            this.상품이름DataGridViewTextBoxColumn.Width = 110;
            // 
            // 매장IDDataGridViewTextBoxColumn
            // 
            this.매장IDDataGridViewTextBoxColumn.DataPropertyName = "매장ID";
            this.매장IDDataGridViewTextBoxColumn.HeaderText = "매장";
            this.매장IDDataGridViewTextBoxColumn.Name = "매장IDDataGridViewTextBoxColumn";
            this.매장IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.매장IDDataGridViewTextBoxColumn.Width = 80;
            // 
            // 리뷰날짜DataGridViewTextBoxColumn
            // 
            this.리뷰날짜DataGridViewTextBoxColumn.DataPropertyName = "리뷰날짜";
            this.리뷰날짜DataGridViewTextBoxColumn.HeaderText = "리뷰날짜";
            this.리뷰날짜DataGridViewTextBoxColumn.Name = "리뷰날짜DataGridViewTextBoxColumn";
            this.리뷰날짜DataGridViewTextBoxColumn.ReadOnly = true;
            this.리뷰날짜DataGridViewTextBoxColumn.Width = 230;
            // 
            // 후기VIEWBindingSource
            // 
            this.후기VIEWBindingSource.DataMember = "후기VIEW";
            this.후기VIEWBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 메인button
            // 
            this.메인button.FlatAppearance.BorderSize = 4;
            this.메인button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.메인button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.메인button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(1008, 46);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(96, 36);
            this.메인button.TabIndex = 1;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.메인button_Click);
            // 
            // 주문TableAdapter1
            // 
            this.주문TableAdapter1.ClearBeforeFill = true;
            // 
            // 상품TableAdapter1
            // 
            this.상품TableAdapter1.ClearBeforeFill = true;
            // 
            // 후기TableAdapter1
            // 
            this.후기TableAdapter1.ClearBeforeFill = true;
            // 
            // 후기VIEWTableAdapter
            // 
            this.후기VIEWTableAdapter.ClearBeforeFill = true;
            // 
            // 주문상태VIEWTableAdapter1
            // 
            this.주문상태VIEWTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 40);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕OTF", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "후기작성";
            // 
            // 후기작성
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.메인button);
            this.Controls.Add(this.tabControl1);
            this.Name = "후기작성";
            this.Load += new System.EventHandler(this.후기작성_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.후기VIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox 후기제목textBox;
        private System.Windows.Forms.TextBox 후기내용textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 작성button;
        private DataSet1TableAdapters.주문TableAdapter 주문TableAdapter1;
        private DataSet1TableAdapters.상품TableAdapter 상품TableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label 상품이름label;
        private System.Windows.Forms.Label 리뷰번호label;
        private DataSet1TableAdapters.후기TableAdapter 후기TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 후기VIEWBindingSource;
        private DataSet1TableAdapters.후기VIEWTableAdapter 후기VIEWTableAdapter;
        private System.Windows.Forms.Label 상품명;
        private System.Windows.Forms.Button 검색button;
        private System.Windows.Forms.TextBox 검색textBox;
        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.Label 후기내용label;
        private System.Windows.Forms.TextBox 후기내용2textBox;
        private System.Windows.Forms.Label 후기제목label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 제목내용label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 주문번호;
        private System.Windows.Forms.ColumnHeader 상품이름;
        private System.Windows.Forms.ColumnHeader 주문일;
        private System.Windows.Forms.ColumnHeader 구매매장;
        private System.Windows.Forms.ColumnHeader 가격;
        private DataSet1TableAdapters.주문상태VIEWTableAdapter 주문상태VIEWTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 리뷰번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 회원IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품타입DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상품이름DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매장IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 리뷰날짜DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}