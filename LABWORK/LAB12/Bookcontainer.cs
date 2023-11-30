using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABWORK.LAB12
{
    internal class Bookcontainer
    {
        private Book[] books;
        public Bookcontainer(Book[] books)
        {
            this.books = books;
        }
        public void SortBooks(Comparison<Book> comparison)
        {
            Array.Sort(books, comparison);
        }
        public void PrintBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

    }
}
