using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public enum BookType
    {
        Small,
        Medium,
        Big
    }

    [Serializable]
    public class Book : IComparable
    {
        public static bool sortMode = false;

        public BookType bookType;
        //public int size = 0;
        public string name = "Unknown";
        public string ukd = "";
        public int pageCount = 0;
        public string publisher = "Unknown";
        public DateTime year;
        public DateTime uploadDate;
        public Author author;

        public int CompareTo(object obj)
        {
            Book other = obj as Book;
            if (other != null)
                return sortMode ? (this.name.CompareTo(other.name)) : (this.uploadDate.CompareTo(other.uploadDate));
            return 0;
        }

        public string GetBookType() => bookType == BookType.Big ? "Большая" : bookType == BookType.Medium ? "Средняя" : "Маленькая";
    }

    public static class Library
    {
        public static List<Book> books = new List<Book>();
    }
}
