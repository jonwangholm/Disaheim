using Program;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim_2._0
{
    public class BookRepository
    {
        Utility utility = new Utility();

        private static List<Book> books = new List<Book>();

        public void addBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string ItemId)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ItemId == ItemId)
                {
                    return books[i];
                }
            }
            return null; 
        }

        public double getTotalValue()
        {
            double pris = 0;
            for (int i = 0; i < books.Count; i++)
            {
                pris += utility.getValeueOfBook(books[i]);
            }
            return pris;

        }

    }
}
