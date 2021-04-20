
namespace lab2
{
    partial class SearchResult
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(776, 426);
            this.dataGrid.TabIndex = 10;
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
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Name = "SearchResult";
            this.Text = "SearchResult";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
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
    }
}