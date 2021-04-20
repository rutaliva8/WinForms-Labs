using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab2
{
    enum SearchOptions
    {
        Publisher,
        PublishYear,
        Pages
    }

    public partial class Search : Form
    {
        List<Book> books;
        public static List<Book> searchResults;

        public Search()
        {
            books = Library.books;
            foreach (Book book in books)
            {
                MessageBox.Show(book.ToString());
                //dataGrid.Rows.Add(book.GetBookType(), book.name, book.ukd, book.pageCount, book.publisher, book.year.ToString(), book.uploadDate.ToString(), book.author.name, book.author.country, book.author.id);
            }
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private List<Book> DoSearch(SearchOptions mode, string text, bool easySearch, bool ignoreCase)
        {
            return books;
            List<Book> newBooks = new List<Book>();
            newBooks.Add(new Book());
            switch (mode)
            {
                case (SearchOptions.Publisher):
                    if (easySearch)
                    {
                        Regex regex = new Regex($@"(\w*){text}(\w*)", ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.Compiled);

                        newBooks = (from book in books
                                   where regex.IsMatch(book.publisher)
                                   select book).ToList();
                    }
                    else
                    {
                        newBooks = (from book in books
                                    where (ignoreCase ? book.publisher.ToUpper() : book.publisher) == (ignoreCase ? text.ToUpper() : text)
                                    select book).ToList();
                    }
                    break;
                case (SearchOptions.PublishYear):
                    try
                    {
                        newBooks = (from book in books
                                    where book.year == (DateTime.Parse(text))
                                    select book).ToList();
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                    break;
                default:
                    try
                    {
                        newBooks = (from book in books
                                    where book.pageCount == Convert.ToInt32(text)
                                    select book).ToList();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    break;
            }
            return newBooks;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchType.Text) || String.IsNullOrEmpty(searchText.Text))
            {
                MessageBox.Show("Неверные значения поиска");
                return;
            }

            SearchOptions searchOption = (SearchOptions)searchType.SelectedIndex;
            MessageBox.Show($"{searchOption} {searchType.SelectedIndex}");

            searchResults = DoSearch(searchOption, searchText.Text, easySearch.Checked, caseCheckBox.Checked);
            foreach (Book book in Search.searchResults)
            {
                MessageBox.Show(book.ToString());
                //dataGrid.Rows.Add(book.GetBookType(), book.name, book.ukd, book.pageCount, book.publisher, book.year.ToString(), book.uploadDate.ToString(), book.author.name, book.author.country, book.author.id);
            }
            //MessageBox.Show(searchResults.ToString());
            SearchResult searchResult = new SearchResult();
            searchResult.Show();
        }
    }
}
