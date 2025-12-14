namespace FinalHomework
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblsid = new System.Windows.Forms.Label();
            this.lblshname = new System.Windows.Forms.Label();
            this.lblsbank = new System.Windows.Forms.Label();
            this.lblsstay = new System.Windows.Forms.Label();
            this.lblsamount = new System.Windows.Forms.Label();
            this.lblsdate = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.txtshname = new System.Windows.Forms.ComboBox();
            this.tbHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationDataSet3 = new FinalHomework.reservationDataSet3();
            this.txtsbank = new System.Windows.Forms.ComboBox();
            this.txtsstay = new System.Windows.Forms.TextBox();
            this.txtsamount = new System.Windows.Forms.TextBox();
            this.txtsdate = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sstayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbShedualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationDataSet2 = new FinalHomework.reservationDataSet2();
            this.tbShedualTableAdapter = new FinalHomework.reservationDataSet2TableAdapters.tbShedualTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsalerate = new System.Windows.Forms.Label();
            this.tbHotelTableAdapter = new FinalHomework.reservationDataSet3TableAdapters.tbHotelTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.금액보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.할인금액ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbHotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbShedualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsid
            // 
            this.lblsid.AutoSize = true;
            this.lblsid.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsid.Location = new System.Drawing.Point(13, 23);
            this.lblsid.Name = "lblsid";
            this.lblsid.Size = new System.Drawing.Size(73, 20);
            this.lblsid.TabIndex = 0;
            this.lblsid.Text = "예약번호";
            // 
            // lblshname
            // 
            this.lblshname.AutoSize = true;
            this.lblshname.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblshname.Location = new System.Drawing.Point(12, 53);
            this.lblshname.Name = "lblshname";
            this.lblshname.Size = new System.Drawing.Size(73, 20);
            this.lblshname.TabIndex = 1;
            this.lblshname.Text = "예약호텔";
            // 
            // lblsbank
            // 
            this.lblsbank.AutoSize = true;
            this.lblsbank.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsbank.Location = new System.Drawing.Point(12, 83);
            this.lblsbank.Name = "lblsbank";
            this.lblsbank.Size = new System.Drawing.Size(73, 20);
            this.lblsbank.TabIndex = 2;
            this.lblsbank.Text = "결제은행";
            // 
            // lblsstay
            // 
            this.lblsstay.AutoSize = true;
            this.lblsstay.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsstay.Location = new System.Drawing.Point(12, 114);
            this.lblsstay.Name = "lblsstay";
            this.lblsstay.Size = new System.Drawing.Size(73, 20);
            this.lblsstay.TabIndex = 3;
            this.lblsstay.Text = "숙박기간";
            // 
            // lblsamount
            // 
            this.lblsamount.AutoSize = true;
            this.lblsamount.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblsamount.Location = new System.Drawing.Point(12, 142);
            this.lblsamount.Name = "lblsamount";
            this.lblsamount.Size = new System.Drawing.Size(73, 20);
            this.lblsamount.TabIndex = 4;
            this.lblsamount.Text = "결제금액";
            this.lblsamount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblsamount_MouseUp);
            // 
            // lblsdate
            // 
            this.lblsdate.AutoSize = true;
            this.lblsdate.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsdate.Location = new System.Drawing.Point(13, 171);
            this.lblsdate.Name = "lblsdate";
            this.lblsdate.Size = new System.Drawing.Size(73, 20);
            this.lblsdate.TabIndex = 5;
            this.lblsdate.Text = "예약날짜";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sname.Location = new System.Drawing.Point(13, 202);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(73, 20);
            this.sname.TabIndex = 6;
            this.sname.Text = "고객이름";
            // 
            // txtsid
            // 
            this.txtsid.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsid.Location = new System.Drawing.Point(92, 18);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(169, 22);
            this.txtsid.TabIndex = 7;
            this.txtsid.Click += new System.EventHandler(this.txtsid_Click);
            // 
            // txtshname
            // 
            this.txtshname.DataSource = this.tbHotelBindingSource;
            this.txtshname.DisplayMember = "hname";
            this.txtshname.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtshname.FormattingEnabled = true;
            this.txtshname.Location = new System.Drawing.Point(92, 50);
            this.txtshname.Name = "txtshname";
            this.txtshname.Size = new System.Drawing.Size(169, 23);
            this.txtshname.TabIndex = 8;
            this.txtshname.ValueMember = "hprice";
            this.txtshname.SelectedIndexChanged += new System.EventHandler(this.txtshname_SelectedIndexChanged);
            // 
            // tbHotelBindingSource
            // 
            this.tbHotelBindingSource.DataMember = "tbHotel";
            this.tbHotelBindingSource.DataSource = this.reservationDataSet3;
            // 
            // reservationDataSet3
            // 
            this.reservationDataSet3.DataSetName = "reservationDataSet3";
            this.reservationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsbank
            // 
            this.txtsbank.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsbank.FormattingEnabled = true;
            this.txtsbank.Items.AddRange(new object[] {
            "부산은행",
            "국민은행",
            "신한은행",
            "하나은행",
            "우리은행"});
            this.txtsbank.Location = new System.Drawing.Point(91, 80);
            this.txtsbank.Name = "txtsbank";
            this.txtsbank.Size = new System.Drawing.Size(169, 23);
            this.txtsbank.TabIndex = 9;
            this.txtsbank.SelectedIndexChanged += new System.EventHandler(this.txtsbank_SelectedIndexChanged);
            // 
            // txtsstay
            // 
            this.txtsstay.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsstay.Location = new System.Drawing.Point(92, 109);
            this.txtsstay.Name = "txtsstay";
            this.txtsstay.Size = new System.Drawing.Size(169, 22);
            this.txtsstay.TabIndex = 10;
            // 
            // txtsamount
            // 
            this.txtsamount.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsamount.Location = new System.Drawing.Point(92, 140);
            this.txtsamount.Name = "txtsamount";
            this.txtsamount.Size = new System.Drawing.Size(169, 22);
            this.txtsamount.TabIndex = 11;
            // 
            // txtsdate
            // 
            this.txtsdate.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsdate.Location = new System.Drawing.Point(92, 171);
            this.txtsdate.Name = "txtsdate";
            this.txtsdate.Size = new System.Drawing.Size(169, 22);
            this.txtsdate.TabIndex = 12;
            // 
            // txtsname
            // 
            this.txtsname.Font = new System.Drawing.Font("나눔고딕", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsname.Location = new System.Drawing.Point(92, 202);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(169, 22);
            this.txtsname.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(273, 23);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.shnameDataGridViewTextBoxColumn,
            this.sbankDataGridViewTextBoxColumn,
            this.sstayDataGridViewTextBoxColumn,
            this.samountDataGridViewTextBoxColumn,
            this.sdateDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbShedualBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(944, 285);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "예약번호";
            this.sidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.Width = 125;
            // 
            // shnameDataGridViewTextBoxColumn
            // 
            this.shnameDataGridViewTextBoxColumn.DataPropertyName = "shname";
            this.shnameDataGridViewTextBoxColumn.HeaderText = "예약호텔";
            this.shnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shnameDataGridViewTextBoxColumn.Name = "shnameDataGridViewTextBoxColumn";
            this.shnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sbankDataGridViewTextBoxColumn
            // 
            this.sbankDataGridViewTextBoxColumn.DataPropertyName = "sbank";
            this.sbankDataGridViewTextBoxColumn.HeaderText = "결제은행";
            this.sbankDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sbankDataGridViewTextBoxColumn.Name = "sbankDataGridViewTextBoxColumn";
            this.sbankDataGridViewTextBoxColumn.Width = 125;
            // 
            // sstayDataGridViewTextBoxColumn
            // 
            this.sstayDataGridViewTextBoxColumn.DataPropertyName = "sstay";
            this.sstayDataGridViewTextBoxColumn.HeaderText = "숙박기간";
            this.sstayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sstayDataGridViewTextBoxColumn.Name = "sstayDataGridViewTextBoxColumn";
            this.sstayDataGridViewTextBoxColumn.Width = 125;
            // 
            // samountDataGridViewTextBoxColumn
            // 
            this.samountDataGridViewTextBoxColumn.DataPropertyName = "samount";
            this.samountDataGridViewTextBoxColumn.HeaderText = "결제금액";
            this.samountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.samountDataGridViewTextBoxColumn.Name = "samountDataGridViewTextBoxColumn";
            this.samountDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdateDataGridViewTextBoxColumn
            // 
            this.sdateDataGridViewTextBoxColumn.DataPropertyName = "sdate";
            this.sdateDataGridViewTextBoxColumn.HeaderText = "예약날짜";
            this.sdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdateDataGridViewTextBoxColumn.Name = "sdateDataGridViewTextBoxColumn";
            this.sdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "고객이름";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbShedualBindingSource
            // 
            this.tbShedualBindingSource.DataMember = "tbShedual";
            this.tbShedualBindingSource.DataSource = this.reservationDataSet2;
            // 
            // reservationDataSet2
            // 
            this.reservationDataSet2.DataSetName = "reservationDataSet2";
            this.reservationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbShedualTableAdapter
            // 
            this.tbShedualTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(533, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "예약등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(533, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "예약수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(533, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "예약삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(533, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 43);
            this.button4.TabIndex = 19;
            this.button4.Text = "여행지추천";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(654, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 140);
            this.listBox1.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button5.Location = new System.Drawing.Point(533, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 43);
            this.button5.TabIndex = 21;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(655, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblsalerate
            // 
            this.lblsalerate.AutoSize = true;
            this.lblsalerate.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsalerate.ForeColor = System.Drawing.Color.Red;
            this.lblsalerate.Location = new System.Drawing.Point(863, 46);
            this.lblsalerate.Name = "lblsalerate";
            this.lblsalerate.Size = new System.Drawing.Size(78, 17);
            this.lblsalerate.TabIndex = 23;
            this.lblsalerate.Text = "은행할인율";
            // 
            // tbHotelTableAdapter
            // 
            this.tbHotelTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.금액보기ToolStripMenuItem,
            this.할인금액ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 금액보기ToolStripMenuItem
            // 
            this.금액보기ToolStripMenuItem.Name = "금액보기ToolStripMenuItem";
            this.금액보기ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.금액보기ToolStripMenuItem.Text = "금액보기";
            this.금액보기ToolStripMenuItem.Click += new System.EventHandler(this.금액보기ToolStripMenuItem_Click);
            // 
            // 할인금액ToolStripMenuItem
            // 
            this.할인금액ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.할인금액ToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.할인금액ToolStripMenuItem.Name = "할인금액ToolStripMenuItem";
            this.할인금액ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.할인금액ToolStripMenuItem.Text = "할인금액";
            this.할인금액ToolStripMenuItem.Click += new System.EventHandler(this.할인금액ToolStripMenuItem_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDate.Location = new System.Drawing.Point(269, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 20);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "선택날짜";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(954, 533);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblsalerate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtsdate);
            this.Controls.Add(this.txtsamount);
            this.Controls.Add(this.txtsstay);
            this.Controls.Add(this.txtsbank);
            this.Controls.Add(this.txtshname);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.lblsdate);
            this.Controls.Add(this.lblsamount);
            this.Controls.Add(this.lblsstay);
            this.Controls.Add(this.lblsbank);
            this.Controls.Add(this.lblshname);
            this.Controls.Add(this.lblsid);
            this.Name = "Form2";
            this.Text = "호텔예약프로그램";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbHotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbShedualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsid;
        private System.Windows.Forms.Label lblshname;
        private System.Windows.Forms.Label lblsbank;
        private System.Windows.Forms.Label lblsstay;
        private System.Windows.Forms.Label lblsamount;
        private System.Windows.Forms.Label lblsdate;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.ComboBox txtshname;
        private System.Windows.Forms.ComboBox txtsbank;
        private System.Windows.Forms.TextBox txtsstay;
        private System.Windows.Forms.TextBox txtsamount;
        private System.Windows.Forms.TextBox txtsdate;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private reservationDataSet2 reservationDataSet2;
        private System.Windows.Forms.BindingSource tbShedualBindingSource;
        private reservationDataSet2TableAdapters.tbShedualTableAdapter tbShedualTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblsalerate;
        private reservationDataSet3 reservationDataSet3;
        private System.Windows.Forms.BindingSource tbHotelBindingSource;
        private reservationDataSet3TableAdapters.tbHotelTableAdapter tbHotelTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 금액보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 할인금액ToolStripMenuItem;
        private System.Windows.Forms.Label lblDate;
    }
}