using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    enum BookType
    {
        Small,
        Medium,
        Big
    }

    [Serializable]
    class Book
    {
        public BookType bookType;
        //public int size = 0;
        public string name = "Unknown";
        public string ukd = "";
        public int pageCount = 0;
        public string publisher = "Unknown";
        public DateTime year;
        public DateTime uploadDate;
        public Author author;

        public string GetBookType() => bookType == BookType.Big ? "Большая" : bookType == BookType.Medium ? "Средняя" : "Маленькая";
    }
}
