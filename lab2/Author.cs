using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class AuthorBuilder
    {
        private Author author;

        // Новый экземпляр строителя должен содержать пустой объект продукта,
        // который используется в дальнейшей сборке.
        public AuthorBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            author = new Author();
        }

        public AuthorBuilder SetName(string name) {author.name = name; return this;}
        public AuthorBuilder SetCountry(string country) { author.country = country; return this; }
        public AuthorBuilder SetId(string id) { author.id = id; return this; }

        public Author GetAuthor()
        {
            Author result = this.author;

            this.Reset();

            return result;
        }


    }

    public class Author
    {
        public string name = "Unknown";
        public string country;
        public string id = "ERR";
    }
}
