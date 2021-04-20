
namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bigBookBtn = new System.Windows.Forms.RadioButton();
            this.mediumBookBtn = new System.Windows.Forms.RadioButton();
            this.smallBookBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.publisherText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.authorNameText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.authorIdText = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookUkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukdText = new System.Windows.Forms.TextBox();
            this.pageCountBar = new System.Windows.Forms.TrackBar();
            this.PagesCountLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.releaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uploadDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.authorCountryBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sortByName = new System.Windows.Forms.ToolStripMenuItem();
            this.dateByName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.bottomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCountBar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид книги";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bigBookBtn
            // 
            this.bigBookBtn.AutoSize = true;
            this.bigBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bigBookBtn.Location = new System.Drawing.Point(16, 52);
            this.bigBookBtn.Name = "bigBookBtn";
            this.bigBookBtn.Size = new System.Drawing.Size(82, 21);
            this.bigBookBtn.TabIndex = 2;
            this.bigBookBtn.Text = "Крупная";
            this.bigBookBtn.UseVisualStyleBackColor = true;
            // 
            // mediumBookBtn
            // 
            this.mediumBookBtn.AutoSize = true;
            this.mediumBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mediumBookBtn.Location = new System.Drawing.Point(16, 79);
            this.mediumBookBtn.Name = "mediumBookBtn";
            this.mediumBookBtn.Size = new System.Drawing.Size(83, 21);
            this.mediumBookBtn.TabIndex = 2;
            this.mediumBookBtn.Text = "Средняя";
            this.mediumBookBtn.UseVisualStyleBackColor = true;
            // 
            // smallBookBtn
            // 
            this.smallBookBtn.AutoSize = true;
            this.smallBookBtn.Checked = true;
            this.smallBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.smallBookBtn.Location = new System.Drawing.Point(16, 106);
            this.smallBookBtn.Name = "smallBookBtn";
            this.smallBookBtn.Size = new System.Drawing.Size(69, 21);
            this.smallBookBtn.TabIndex = 2;
            this.smallBookBtn.TabStop = true;
            this.smallBookBtn.Text = "Малая";
            this.smallBookBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Название";
            // 
            // bookNameText
            // 
            this.bookNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bookNameText.Location = new System.Drawing.Point(16, 157);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(120, 23);
            this.bookNameText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "УКД";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Количество страниц";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(11, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Издатель";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // publisherText
            // 
            this.publisherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.publisherText.Location = new System.Drawing.Point(14, 338);
            this.publisherText.Name = "publisherText";
            this.publisherText.Size = new System.Drawing.Size(121, 23);
            this.publisherText.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(13, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Год выпуска";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(10, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Год загрузки";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label9.Location = new System.Drawing.Point(6, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 46);
            this.label9.TabIndex = 1;
            this.label9.Text = "Автор";
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // authorNameText
            // 
            this.authorNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.authorNameText.Location = new System.Drawing.Point(17, 558);
            this.authorNameText.Name = "authorNameText";
            this.authorNameText.Size = new System.Drawing.Size(121, 23);
            this.authorNameText.TabIndex = 4;
            this.authorNameText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(10, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "ФИО";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(10, 584);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Страна";
            this.label11.Click += new System.EventHandler(this.label5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(13, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "ID";
            this.label12.Click += new System.EventHandler(this.label5_Click);
            // 
            // authorIdText
            // 
            this.authorIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.authorIdText.Location = new System.Drawing.Point(16, 669);
            this.authorIdText.Name = "authorIdText";
            this.authorIdText.Size = new System.Drawing.Size(121, 23);
            this.authorIdText.TabIndex = 4;
            this.authorIdText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookType,
            this.bookName,
            this.bookUkd,
            this.bookPages,
            this.publisher,
            this.publishDate,
            this.uploadDate,
            this.authorName,
            this.authorCountry,
            this.authorID});
            this.dataGrid.Location = new System.Drawing.Point(210, 25);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(946, 760);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // bookType
            // 
            this.bookType.HeaderText = "Вид книги";
            this.bookType.Name = "bookType";
            this.bookType.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "Name";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // bookUkd
            // 
            this.bookUkd.HeaderText = "УКД";
            this.bookUkd.Name = "bookUkd";
            this.bookUkd.ReadOnly = true;
            // 
            // bookPages
            // 
            this.bookPages.HeaderText = "Количество страниц";
            this.bookPages.Name = "bookPages";
            this.bookPages.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Издатель";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // publishDate
            // 
            this.publishDate.HeaderText = "Год выпуска";
            this.publishDate.Name = "publishDate";
            this.publishDate.ReadOnly = true;
            // 
            // uploadDate
            // 
            this.uploadDate.HeaderText = "Год загрузки";
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.ReadOnly = true;
            // 
            // authorName
            // 
            this.authorName.HeaderText = "Имя автора";
            this.authorName.Name = "authorName";
            this.authorName.ReadOnly = true;
            // 
            // authorCountry
            // 
            this.authorCountry.HeaderText = "Страна";
            this.authorCountry.Name = "authorCountry";
            this.authorCountry.ReadOnly = true;
            // 
            // authorID
            // 
            this.authorID.HeaderText = "ID автора";
            this.authorID.Name = "authorID";
            this.authorID.ReadOnly = true;
            // 
            // ukdText
            // 
            this.ukdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ukdText.Location = new System.Drawing.Point(15, 210);
            this.ukdText.Name = "ukdText";
            this.ukdText.Size = new System.Drawing.Size(121, 23);
            this.ukdText.TabIndex = 4;
            // 
            // pageCountBar
            // 
            this.pageCountBar.LargeChange = 1;
            this.pageCountBar.Location = new System.Drawing.Point(16, 263);
            this.pageCountBar.Maximum = 1000;
            this.pageCountBar.Name = "pageCountBar";
            this.pageCountBar.Size = new System.Drawing.Size(187, 45);
            this.pageCountBar.TabIndex = 11;
            this.pageCountBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PagesCountLabel
            // 
            this.PagesCountLabel.AutoSize = true;
            this.PagesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PagesCountLabel.Location = new System.Drawing.Point(14, 295);
            this.PagesCountLabel.Name = "PagesCountLabel";
            this.PagesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.PagesCountLabel.TabIndex = 12;
            this.PagesCountLabel.Text = "0";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(18, 736);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(99, 736);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 13;
            this.LoadBtn.Text = "Загрузить";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(99, 710);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 13;
            this.removeBtn.Text = "Удалить";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // releaseDatePicker
            // 
            this.releaseDatePicker.Location = new System.Drawing.Point(14, 391);
            this.releaseDatePicker.Name = "releaseDatePicker";
            this.releaseDatePicker.Size = new System.Drawing.Size(189, 20);
            this.releaseDatePicker.TabIndex = 14;
            // 
            // uploadDatePicker
            // 
            this.uploadDatePicker.Location = new System.Drawing.Point(14, 453);
            this.uploadDatePicker.Name = "uploadDatePicker";
            this.uploadDatePicker.Size = new System.Drawing.Size(189, 20);
            this.uploadDatePicker.TabIndex = 14;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(18, 710);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // authorCountryBox
            // 
            this.authorCountryBox.FormattingEnabled = true;
            this.authorCountryBox.Items.AddRange(new object[] {
            "Магадан",
            "Камбождо",
            "Деревня Горки"});
            this.authorCountryBox.Location = new System.Drawing.Point(16, 611);
            this.authorCountryBox.Name = "authorCountryBox";
            this.authorCountryBox.Size = new System.Drawing.Size(121, 21);
            this.authorCountryBox.TabIndex = 15;
            this.authorCountryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBtn,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1168, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(46, 22);
            this.searchBtn.Text = "Поиск";
            this.searchBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByName,
            this.dateByName});
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton1.Text = "Сортировать по";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // sortByName
            // 
            this.sortByName.Name = "sortByName";
            this.sortByName.Size = new System.Drawing.Size(149, 22);
            this.sortByName.Text = "Названию";
            this.sortByName.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // dateByName
            // 
            this.dateByName.Name = "dateByName";
            this.dateByName.Size = new System.Drawing.Size(149, 22);
            this.dateByName.Text = "Дате загрузки";
            this.dateByName.Click += new System.EventHandler(this.dateByName_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton2.Text = "О программе";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton3.Text = "Очистить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.Location = new System.Drawing.Point(1, 786);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(35, 13);
            this.bottomLabel.TabIndex = 17;
            this.bottomLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 799);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.authorCountryBox);
            this.Controls.Add(this.uploadDatePicker);
            this.Controls.Add(this.releaseDatePicker);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.PagesCountLabel);
            this.Controls.Add(this.pageCountBar);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.publisherText);
            this.Controls.Add(this.authorIdText);
            this.Controls.Add(this.authorNameText);
            this.Controls.Add(this.ukdText);
            this.Controls.Add(this.bookNameText);
            this.Controls.Add(this.smallBookBtn);
            this.Controls.Add(this.mediumBookBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bigBookBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCountBar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bigBookBtn;
        private System.Windows.Forms.RadioButton mediumBookBtn;
        private System.Windows.Forms.RadioButton smallBookBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox publisherText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox authorNameText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox authorIdText;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox ukdText;
        private System.Windows.Forms.TrackBar pageCountBar;
        private System.Windows.Forms.Label PagesCountLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookUkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPages;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorID;
        private System.Windows.Forms.DateTimePicker releaseDatePicker;
        private System.Windows.Forms.DateTimePicker uploadDatePicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox authorCountryBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem sortByName;
        private System.Windows.Forms.ToolStripMenuItem dateByName;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label bottomLabel;
    }
}

