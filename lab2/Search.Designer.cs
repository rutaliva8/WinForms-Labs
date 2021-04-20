
namespace lab2
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchType = new System.Windows.Forms.ComboBox();
            this.easySearch = new System.Windows.Forms.CheckBox();
            this.caseCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полное совпадение";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchText.Location = new System.Drawing.Point(16, 74);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(330, 29);
            this.searchText.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(16, 177);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 31);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchType
            // 
            this.searchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchType.FormattingEnabled = true;
            this.searchType.Items.AddRange(new object[] {
            "издательство",
            "год издания",
            "количество страниц"});
            this.searchType.Location = new System.Drawing.Point(16, 36);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(330, 32);
            this.searchType.TabIndex = 3;
            // 
            // easySearch
            // 
            this.easySearch.AutoSize = true;
            this.easySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.easySearch.Location = new System.Drawing.Point(16, 109);
            this.easySearch.Name = "easySearch";
            this.easySearch.Size = new System.Drawing.Size(232, 28);
            this.easySearch.TabIndex = 4;
            this.easySearch.Text = "Неполное совпадение";
            this.easySearch.UseVisualStyleBackColor = true;
            this.easySearch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // caseCheckBox
            // 
            this.caseCheckBox.AutoSize = true;
            this.caseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.caseCheckBox.Location = new System.Drawing.Point(16, 143);
            this.caseCheckBox.Name = "caseCheckBox";
            this.caseCheckBox.Size = new System.Drawing.Size(237, 28);
            this.caseCheckBox.TabIndex = 4;
            this.caseCheckBox.Text = "Игнорировать регистр";
            this.caseCheckBox.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 215);
            this.Controls.Add(this.caseCheckBox);
            this.Controls.Add(this.easySearch);
            this.Controls.Add(this.searchType);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.CheckBox easySearch;
        private System.Windows.Forms.CheckBox caseCheckBox;
    }
}