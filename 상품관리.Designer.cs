
namespace 기말프로젝트
{
    partial class 상품관리
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
            this.dataSet11 = new 기말프로젝트.DataSet1();
            this.상품TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품TableAdapter();
            this.상품타입TableAdapter1 = new 기말프로젝트.DataSet1TableAdapters.상품타입TableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.가격변경button = new System.Windows.Forms.Button();
            this.변경할가격textBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.상품번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.매장 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.추가할재고textBox = new System.Windows.Forms.TextBox();
            this.재고추가button = new System.Windows.Forms.Button();
            this.상품타입comboBox1 = new System.Windows.Forms.ComboBox();
            this.매장comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.상품타입comboBox = new System.Windows.Forms.ComboBox();
            this.매장comboBox = new System.Windows.Forms.ComboBox();
            this.입고button = new System.Windows.Forms.Button();
            this.상품개수textBox = new System.Windows.Forms.TextBox();
            this.상품가격textBox = new System.Windows.Forms.TextBox();
            this.상품이름textBox = new System.Windows.Forms.TextBox();
            this.상품번호textBox = new System.Windows.Forms.TextBox();
            this.상품타입label = new System.Windows.Forms.Label();
            this.매장label = new System.Windows.Forms.Label();
            this.상품개수label = new System.Windows.Forms.Label();
            this.상품가격label = new System.Windows.Forms.Label();
            this.상품이름label = new System.Windows.Forms.Label();
            this.상품번호label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.메인button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 상품TableAdapter1
            // 
            this.상품TableAdapter1.ClearBeforeFill = true;
            // 
            // 상품타입TableAdapter1
            // 
            this.상품타입TableAdapter1.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.가격변경button);
            this.tabPage2.Controls.Add(this.변경할가격textBox);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.추가할재고textBox);
            this.tabPage2.Controls.Add(this.재고추가button);
            this.tabPage2.Controls.Add(this.상품타입comboBox1);
            this.tabPage2.Controls.Add(this.매장comboBox1);
            this.tabPage2.Font = new System.Drawing.Font("나눔바른고딕OTF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "기존상품정보변경";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(166, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "상품타입";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "상품매장";
            // 
            // 가격변경button
            // 
            this.가격변경button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.가격변경button.FlatAppearance.BorderSize = 3;
            this.가격변경button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.가격변경button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.가격변경button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.가격변경button.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.가격변경button.Location = new System.Drawing.Point(504, 171);
            this.가격변경button.Name = "가격변경button";
            this.가격변경button.Size = new System.Drawing.Size(57, 50);
            this.가격변경button.TabIndex = 7;
            this.가격변경button.Text = "가격변경";
            this.가격변경button.UseVisualStyleBackColor = false;
            this.가격변경button.Click += new System.EventHandler(this.가격변경button_Click);
            // 
            // 변경할가격textBox
            // 
            this.변경할가격textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.변경할가격textBox.Location = new System.Drawing.Point(371, 176);
            this.변경할가격textBox.Name = "변경할가격textBox";
            this.변경할가격textBox.Size = new System.Drawing.Size(127, 35);
            this.변경할가격textBox.TabIndex = 6;
            this.변경할가격textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.번호만);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상품번호,
            this.상품이름,
            this.매장,
            this.상품수,
            this.상품가격});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 313);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 상품번호
            // 
            this.상품번호.Text = "상품번호";
            // 
            // 상품이름
            // 
            this.상품이름.Text = "상품이름";
            this.상품이름.Width = 69;
            // 
            // 매장
            // 
            this.매장.Text = "매장";
            // 
            // 상품수
            // 
            this.상품수.Text = "상품수";
            // 
            // 상품가격
            // 
            this.상품가격.Text = "상품가격";
            // 
            // 추가할재고textBox
            // 
            this.추가할재고textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.추가할재고textBox.Location = new System.Drawing.Point(371, 102);
            this.추가할재고textBox.Name = "추가할재고textBox";
            this.추가할재고textBox.Size = new System.Drawing.Size(127, 35);
            this.추가할재고textBox.TabIndex = 3;
            this.추가할재고textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.번호만);
            // 
            // 재고추가button
            // 
            this.재고추가button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.재고추가button.FlatAppearance.BorderSize = 3;
            this.재고추가button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.재고추가button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.재고추가button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.재고추가button.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.재고추가button.Location = new System.Drawing.Point(504, 94);
            this.재고추가button.Name = "재고추가button";
            this.재고추가button.Size = new System.Drawing.Size(57, 51);
            this.재고추가button.TabIndex = 4;
            this.재고추가button.Text = "재고추가";
            this.재고추가button.UseVisualStyleBackColor = false;
            this.재고추가button.Click += new System.EventHandler(this.재고추가button_Click);
            // 
            // 상품타입comboBox1
            // 
            this.상품타입comboBox1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품타입comboBox1.FormattingEnabled = true;
            this.상품타입comboBox1.Location = new System.Drawing.Point(170, 49);
            this.상품타입comboBox1.Name = "상품타입comboBox1";
            this.상품타입comboBox1.Size = new System.Drawing.Size(121, 26);
            this.상품타입comboBox1.TabIndex = 1;
            this.상품타입comboBox1.SelectedIndexChanged += new System.EventHandler(this.상품타입변경);
            // 
            // 매장comboBox1
            // 
            this.매장comboBox1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장comboBox1.FormattingEnabled = true;
            this.매장comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.매장comboBox1.Location = new System.Drawing.Point(21, 49);
            this.매장comboBox1.Name = "매장comboBox1";
            this.매장comboBox1.Size = new System.Drawing.Size(121, 26);
            this.매장comboBox1.TabIndex = 0;
            this.매장comboBox1.SelectedIndexChanged += new System.EventHandler(this.매장변경);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.상품타입comboBox);
            this.tabPage1.Controls.Add(this.매장comboBox);
            this.tabPage1.Controls.Add(this.입고button);
            this.tabPage1.Controls.Add(this.상품개수textBox);
            this.tabPage1.Controls.Add(this.상품가격textBox);
            this.tabPage1.Controls.Add(this.상품이름textBox);
            this.tabPage1.Controls.Add(this.상품번호textBox);
            this.tabPage1.Controls.Add(this.상품타입label);
            this.tabPage1.Controls.Add(this.매장label);
            this.tabPage1.Controls.Add(this.상품개수label);
            this.tabPage1.Controls.Add(this.상품가격label);
            this.tabPage1.Controls.Add(this.상품이름label);
            this.tabPage1.Controls.Add(this.상품번호label);
            this.tabPage1.Font = new System.Drawing.Font("나눔바른고딕OTF", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "신규상품입고";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "입고할 상품정보를 입력하세요";
            // 
            // 상품타입comboBox
            // 
            this.상품타입comboBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품타입comboBox.FormattingEnabled = true;
            this.상품타입comboBox.Location = new System.Drawing.Point(168, 354);
            this.상품타입comboBox.Name = "상품타입comboBox";
            this.상품타입comboBox.Size = new System.Drawing.Size(166, 36);
            this.상품타입comboBox.TabIndex = 14;
            // 
            // 매장comboBox
            // 
            this.매장comboBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장comboBox.FormattingEnabled = true;
            this.매장comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.매장comboBox.Location = new System.Drawing.Point(168, 298);
            this.매장comboBox.Name = "매장comboBox";
            this.매장comboBox.Size = new System.Drawing.Size(166, 36);
            this.매장comboBox.TabIndex = 13;
            // 
            // 입고button
            // 
            this.입고button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.입고button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.입고button.FlatAppearance.BorderSize = 4;
            this.입고button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.입고button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.입고button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.입고button.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.입고button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.입고button.Location = new System.Drawing.Point(447, 340);
            this.입고button.Name = "입고button";
            this.입고button.Size = new System.Drawing.Size(81, 62);
            this.입고button.TabIndex = 12;
            this.입고button.Text = "입고";
            this.입고button.UseVisualStyleBackColor = false;
            this.입고button.Click += new System.EventHandler(this.입고button_Click);
            // 
            // 상품개수textBox
            // 
            this.상품개수textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품개수textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.상품개수textBox.Location = new System.Drawing.Point(168, 247);
            this.상품개수textBox.Name = "상품개수textBox";
            this.상품개수textBox.Size = new System.Drawing.Size(166, 35);
            this.상품개수textBox.TabIndex = 9;
            this.상품개수textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.번호만);
            // 
            // 상품가격textBox
            // 
            this.상품가격textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품가격textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.상품가격textBox.Location = new System.Drawing.Point(168, 189);
            this.상품가격textBox.Name = "상품가격textBox";
            this.상품가격textBox.Size = new System.Drawing.Size(166, 35);
            this.상품가격textBox.TabIndex = 8;
            this.상품가격textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.번호만);
            // 
            // 상품이름textBox
            // 
            this.상품이름textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품이름textBox.Location = new System.Drawing.Point(168, 127);
            this.상품이름textBox.Name = "상품이름textBox";
            this.상품이름textBox.Size = new System.Drawing.Size(166, 35);
            this.상품이름textBox.TabIndex = 7;
            // 
            // 상품번호textBox
            // 
            this.상품번호textBox.Font = new System.Drawing.Font("나눔바른고딕OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품번호textBox.Location = new System.Drawing.Point(168, 64);
            this.상품번호textBox.Name = "상품번호textBox";
            this.상품번호textBox.Size = new System.Drawing.Size(166, 35);
            this.상품번호textBox.TabIndex = 6;
            // 
            // 상품타입label
            // 
            this.상품타입label.AutoSize = true;
            this.상품타입label.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품타입label.Location = new System.Drawing.Point(52, 354);
            this.상품타입label.Name = "상품타입label";
            this.상품타입label.Size = new System.Drawing.Size(110, 31);
            this.상품타입label.TabIndex = 5;
            this.상품타입label.Text = "상품타입";
            // 
            // 매장label
            // 
            this.매장label.AutoSize = true;
            this.매장label.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.매장label.Location = new System.Drawing.Point(62, 301);
            this.매장label.Name = "매장label";
            this.매장label.Size = new System.Drawing.Size(62, 31);
            this.매장label.TabIndex = 4;
            this.매장label.Text = "매장";
            // 
            // 상품개수label
            // 
            this.상품개수label.AutoSize = true;
            this.상품개수label.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품개수label.Location = new System.Drawing.Point(52, 248);
            this.상품개수label.Name = "상품개수label";
            this.상품개수label.Size = new System.Drawing.Size(110, 31);
            this.상품개수label.TabIndex = 3;
            this.상품개수label.Text = "상품개수";
            // 
            // 상품가격label
            // 
            this.상품가격label.AutoSize = true;
            this.상품가격label.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품가격label.Location = new System.Drawing.Point(52, 190);
            this.상품가격label.Name = "상품가격label";
            this.상품가격label.Size = new System.Drawing.Size(110, 31);
            this.상품가격label.TabIndex = 2;
            this.상품가격label.Text = "상품가격";
            // 
            // 상품이름label
            // 
            this.상품이름label.AutoSize = true;
            this.상품이름label.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품이름label.Location = new System.Drawing.Point(52, 128);
            this.상품이름label.Name = "상품이름label";
            this.상품이름label.Size = new System.Drawing.Size(110, 31);
            this.상품이름label.TabIndex = 1;
            this.상품이름label.Text = "상품이름";
            // 
            // 상품번호label
            // 
            this.상품번호label.AutoSize = true;
            this.상품번호label.Font = new System.Drawing.Font("나눔바른고딕OTF", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.상품번호label.Location = new System.Drawing.Point(52, 65);
            this.상품번호label.Name = "상품번호label";
            this.상품번호label.Size = new System.Drawing.Size(110, 31);
            this.상품번호label.TabIndex = 0;
            this.상품번호label.Text = "상품번호";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("나눔바른고딕OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // 메인button
            // 
            this.메인button.FlatAppearance.BorderSize = 3;
            this.메인button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.메인button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.메인button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.메인button.Font = new System.Drawing.Font("나눔바른고딕OTF", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.메인button.Location = new System.Drawing.Point(514, 25);
            this.메인button.Name = "메인button";
            this.메인button.Size = new System.Drawing.Size(84, 45);
            this.메인button.TabIndex = 1;
            this.메인button.Text = "메인";
            this.메인button.UseVisualStyleBackColor = true;
            this.메인button.Click += new System.EventHandler(this.메인button_Click);
            // 
            // 상품관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 522);
            this.Controls.Add(this.메인button);
            this.Controls.Add(this.tabControl1);
            this.Name = "상품관리";
            this.Text = "상품관리";
            this.Load += new System.EventHandler(this.상품입고_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.상품TableAdapter 상품TableAdapter1;
        private DataSet1TableAdapters.상품타입TableAdapter 상품타입TableAdapter1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 상품번호;
        private System.Windows.Forms.ColumnHeader 상품이름;
        private System.Windows.Forms.ColumnHeader 매장;
        private System.Windows.Forms.ColumnHeader 상품수;
        private System.Windows.Forms.TextBox 추가할재고textBox;
        private System.Windows.Forms.Button 재고추가button;
        private System.Windows.Forms.ComboBox 상품타입comboBox1;
        private System.Windows.Forms.ComboBox 매장comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox 상품타입comboBox;
        private System.Windows.Forms.ComboBox 매장comboBox;
        private System.Windows.Forms.Button 입고button;
        private System.Windows.Forms.TextBox 상품개수textBox;
        private System.Windows.Forms.TextBox 상품가격textBox;
        private System.Windows.Forms.TextBox 상품이름textBox;
        private System.Windows.Forms.TextBox 상품번호textBox;
        private System.Windows.Forms.Label 상품타입label;
        private System.Windows.Forms.Label 매장label;
        private System.Windows.Forms.Label 상품개수label;
        private System.Windows.Forms.Label 상품가격label;
        private System.Windows.Forms.Label 상품이름label;
        private System.Windows.Forms.Label 상품번호label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button 가격변경button;
        private System.Windows.Forms.TextBox 변경할가격textBox;
        private System.Windows.Forms.ColumnHeader 상품가격;
        private System.Windows.Forms.Button 메인button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}