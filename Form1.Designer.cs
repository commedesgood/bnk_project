namespace FinalHomework
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationDataSet1 = new FinalHomework.reservationDataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationDataSet = new FinalHomework.reservationDataSet();
            this.reservationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbHotelTableAdapter = new FinalHomework.reservationDataSet1TableAdapters.tbHotelTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.호텔예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.호텔정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.프로그램종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예약관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(31, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예약호텔정보";
            this.groupBox1.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Location = new System.Drawing.Point(388, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 50);
            this.button4.TabIndex = 16;
            this.button4.Text = "최저가 호텔";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hidDataGridViewTextBoxColumn,
            this.hnameDataGridViewTextBoxColumn,
            this.hclassDataGridViewTextBoxColumn,
            this.hlocationDataGridViewTextBoxColumn,
            this.hpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbHotelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(697, 161);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hidDataGridViewTextBoxColumn
            // 
            this.hidDataGridViewTextBoxColumn.DataPropertyName = "hid";
            this.hidDataGridViewTextBoxColumn.HeaderText = "호텔번호";
            this.hidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hidDataGridViewTextBoxColumn.Name = "hidDataGridViewTextBoxColumn";
            this.hidDataGridViewTextBoxColumn.Width = 125;
            // 
            // hnameDataGridViewTextBoxColumn
            // 
            this.hnameDataGridViewTextBoxColumn.DataPropertyName = "hname";
            this.hnameDataGridViewTextBoxColumn.HeaderText = "호텔이름";
            this.hnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hnameDataGridViewTextBoxColumn.Name = "hnameDataGridViewTextBoxColumn";
            this.hnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // hclassDataGridViewTextBoxColumn
            // 
            this.hclassDataGridViewTextBoxColumn.DataPropertyName = "hclass";
            this.hclassDataGridViewTextBoxColumn.HeaderText = "호텔등급";
            this.hclassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hclassDataGridViewTextBoxColumn.Name = "hclassDataGridViewTextBoxColumn";
            this.hclassDataGridViewTextBoxColumn.Width = 125;
            // 
            // hlocationDataGridViewTextBoxColumn
            // 
            this.hlocationDataGridViewTextBoxColumn.DataPropertyName = "hlocation";
            this.hlocationDataGridViewTextBoxColumn.HeaderText = "호텔위치";
            this.hlocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hlocationDataGridViewTextBoxColumn.Name = "hlocationDataGridViewTextBoxColumn";
            this.hlocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // hpriceDataGridViewTextBoxColumn
            // 
            this.hpriceDataGridViewTextBoxColumn.DataPropertyName = "hprice";
            this.hpriceDataGridViewTextBoxColumn.HeaderText = "호텔가격";
            this.hpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hpriceDataGridViewTextBoxColumn.Name = "hpriceDataGridViewTextBoxColumn";
            this.hpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbHotelBindingSource
            // 
            this.tbHotelBindingSource.DataMember = "tbHotel";
            this.tbHotelBindingSource.DataSource = this.reservationDataSet1;
            // 
            // reservationDataSet1
            // 
            this.reservationDataSet1.DataSetName = "reservationDataSet1";
            this.reservationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(492, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "삭   제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "수   정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "등   록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5성급",
            "4성급",
            "3성급"});
            this.comboBox1.Location = new System.Drawing.Point(106, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(106, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(264, 27);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(106, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 27);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(106, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(106, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "숙박가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "호텔위치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "호텔등급";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "호텔이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "호텔번호";
            // 
            // reservationDataSet
            // 
            this.reservationDataSet.DataSetName = "reservationDataSet";
            this.reservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationDataSetBindingSource
            // 
            this.reservationDataSetBindingSource.DataSource = this.reservationDataSet;
            this.reservationDataSetBindingSource.Position = 0;
            // 
            // tbHotelTableAdapter
            // 
            this.tbHotelTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.호텔예약ToolStripMenuItem,
            this.예약관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 호텔예약ToolStripMenuItem
            // 
            this.호텔예약ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.호텔정보ToolStripMenuItem,
            this.예약하기ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.프로그램종료ToolStripMenuItem});
            this.호텔예약ToolStripMenuItem.Name = "호텔예약ToolStripMenuItem";
            this.호텔예약ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.호텔예약ToolStripMenuItem.Text = "호텔예약";
            this.호텔예약ToolStripMenuItem.Click += new System.EventHandler(this.호텔예약ToolStripMenuItem_Click);
            // 
            // 호텔정보ToolStripMenuItem
            // 
            this.호텔정보ToolStripMenuItem.Name = "호텔정보ToolStripMenuItem";
            this.호텔정보ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.호텔정보ToolStripMenuItem.Text = "호텔정보";
            this.호텔정보ToolStripMenuItem.Click += new System.EventHandler(this.호텔정보ToolStripMenuItem_Click);
            // 
            // 예약하기ToolStripMenuItem
            // 
            this.예약하기ToolStripMenuItem.Name = "예약하기ToolStripMenuItem";
            this.예약하기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.예약하기ToolStripMenuItem.Text = "예약하기";
            this.예약하기ToolStripMenuItem.Click += new System.EventHandler(this.예약하기ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // 프로그램종료ToolStripMenuItem
            // 
            this.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem";
            this.프로그램종료ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.프로그램종료ToolStripMenuItem.Text = "프로그램종료";
            this.프로그램종료ToolStripMenuItem.Click += new System.EventHandler(this.프로그램종료ToolStripMenuItem_Click);
            // 
            // 예약관리ToolStripMenuItem
            // 
            this.예약관리ToolStripMenuItem.Name = "예약관리ToolStripMenuItem";
            this.예약관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.예약관리ToolStripMenuItem.Text = "예약관리";
            this.예약관리ToolStripMenuItem.Click += new System.EventHandler(this.예약관리ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "부산1인호텔예약시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource reservationDataSetBindingSource;
        private reservationDataSet reservationDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private reservationDataSet1 reservationDataSet1;
        private System.Windows.Forms.BindingSource tbHotelBindingSource;
        private reservationDataSet1TableAdapters.tbHotelTableAdapter tbHotelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 호텔예약ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 호텔정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 예약하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 프로그램종료ToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem 예약관리ToolStripMenuItem;
    }
}

