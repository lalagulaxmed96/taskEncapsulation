using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskEncapsulation
{
    internal class Library
    {

        public Library() { }

        public Book[] books = new Book[0];


        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length-1] = book;
        }
        
        public void ShowAllBooks()
        {
            for (int i = 0; i< books.Length; i++)
            {
                books[i].ShowInfo();
            }
        }




    }
}
