using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sampleCode
{
    public class Book
    {
        private string authorName;
        private string bookName;
        private int price;

        public Book()
        {
            authorName = "APJ abdul kalam";
            bookName = "Wings of Fire";
            price = 600;
        }
        public Book(string authorName, string bookName, int price)
        {
            this.authorName = authorName;
            this.bookName = bookName;
            this.price = price;
        }
       
        public string Display()
        {
            return $"Author name - {authorName} book name - {bookName} price - {price}";
        }
    }
}
