using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class SearchResult : Form
    {
        public SearchResult(List<Book> searchResults)
        {
            InitializeComponent();
            foreach (Book book in searchResults)
            {
                MessageBox.Show(book.ToString());
                dataGrid.Rows.Add(book.GetBookType(), book.name, book.ukd, book.pageCount, book.publisher, book.year.ToString(), book.uploadDate.ToString(), book.author.name, book.author.country, book.author.id);
            }
        }
    }
}
