﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace lab2
{
    public partial class Form1 : Form
    {
        static List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGrid.Columns.Add("column-1", "Header column - 1");
            dataGrid.Rows.Add("Ivanov I.I.", 25, "New York");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PagesCountLabel.Text = pageCountBar.Value.ToString();
        }

        private void RebuildGrid()
        {
            dataGrid.Rows.Clear();
            foreach (Book book in books)
            {
                dataGrid.Rows.Add(book.GetBookType(), book.name, book.ukd, book.pageCount, book.publisher, book.year.ToString("dd-mm-yyyy"), book.uploadDate.ToString("dd-mm-yyyy"), book.author.name, book.author.country, book.author.id);
            }
        }

        private string ValidateData()
        {
            StringBuilder result = new StringBuilder();

            if (String.IsNullOrEmpty(bookNameText.Text))
                result.AppendLine("Неверное имя книги");
            if (String.IsNullOrEmpty(ukdText.Text))
                result.AppendLine("Неверное УКД");
            if (String.IsNullOrEmpty(publisherText.Text))
                result.AppendLine("Неверный издатель");
            if (String.IsNullOrEmpty(authorNameText.Text))
                result.AppendLine("Неверное ФИО автора");
            if (String.IsNullOrEmpty(authorIdText.Text))
                result.AppendLine("Неверное ID автора");
            if (String.IsNullOrEmpty(authorCountryBox.Text))
                result.AppendLine("Неверная страна автора");
            if (pageCountBar.Value <= 0)
                result.AppendLine("Неверное количество страниц");

            return result.Length > 0 ? result.ToString() : null;
        }

        private void AddCurrentRecord()
        {
            /*
            public BookType bookType;
            public int size = 0;
            public string name = "Unknown";
            public string ukd = "";
            public int pageCount = 0;
            public string publisher = "Unknown";
            public DateTime year;
            public DateTime uploadDate;
            public List<Author> authors;
             */

            var book = new Book();
            book.bookType = smallBookBtn.Checked ? BookType.Small : mediumBookBtn.Checked ? BookType.Medium : BookType.Big;
            book.pageCount = pageCountBar.Value;
            book.name = bookNameText.Text;
            book.ukd = ukdText.Text;
            book.publisher = publisherText.Text;
            book.year = releaseDatePicker.Value.Date;
            book.uploadDate = uploadDatePicker.Value.Date;

            var author = new Author();
            author.name = authorNameText.Text;
            author.country = authorCountryBox.Text;
            author.id = authorIdText.Text;

            book.author = author;

            books.Add(book);
            RebuildGrid(); // Мне мегалень делать ивенты, да и они не нужны нигде кроме обновы грида
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*.json|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string filename = saveFileDialog.FileName;

            try
            {
                string result = JsonConvert.SerializeObject(books, Formatting.Indented);
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    sw.Write(result);
                }
                MessageBox.Show("Готово!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string validationResult = ValidateData();
            if (validationResult != null)
            {
                MessageBox.Show(validationResult);
                return;
            }
            AddCurrentRecord();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            string fileName = dialog.FileName;

            string json;

            using (StreamReader sr = new StreamReader(fileName))
            {
                json = sr.ReadToEnd();
            }

            try
            {
                books = JsonConvert.DeserializeObject<List<Book>>(json);
                MessageBox.Show($"Загрузка успешна! Загружено {books.Count} записей.");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            RebuildGrid();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                //dataGrid.Rows.RemoveAt(row.Index);
                books.RemoveAt(row.Index);
            }
            RebuildGrid();
        }
    }
}
