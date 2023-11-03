using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_Para_Book
{
    class Book
    {
        int bookid;
        string booktitle;
        string bookauthor;
        int bookprice;

        public Book()
        {
            bookid = 12;
            booktitle = "Harry Potter";
            bookauthor = "Obama";
            bookprice = 1500;
        }

        public Book(int bookid, string booktitle, string bookauthor, int bookprice)
        {
            this.bookid = bookid;
            this.booktitle = booktitle;
            this.bookauthor = bookauthor;
            this.bookprice = bookprice;
        }
        public void display()
        {
            Console.WriteLine("Book ID : " + bookid);
            Console.WriteLine("Book Title : " + booktitle);
            Console.WriteLine("Book Author : " + bookauthor);
            Console.WriteLine("Book Price : " + bookprice);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();

            b1.display();
            
            Console.WriteLine("---------------------------------");

            Book b2 = new Book(22, "orchid", "chandu",1000);
            b2.display();

            Console.ReadKey();
        }
    }
}
