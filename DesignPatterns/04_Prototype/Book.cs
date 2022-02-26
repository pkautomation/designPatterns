using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Prototype
{
    internal class Book
    {
        public string Name { get; set; }
        public string Title { get; set; }

        private string author { get; set; }

        public Book(string author) {
            this.author = author;
        }

        public string GetAuthor()
        {
            return author;
        }

        // this deep copy in this case
        public Book Clone()
        {
            Book book = (Book) this.MemberwiseClone();
            return book;
        }
    }
}
