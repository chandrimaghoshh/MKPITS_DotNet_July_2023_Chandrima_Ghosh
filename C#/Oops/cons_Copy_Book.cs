using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons_Copy
{
    class Book
    {
        int bookid;
        string bookname;

        public Book()
        {
            bookid = 1;
            bookname = "Java";
        }
        public Book(Book b2)
        {
            bookid = b2.bookid;
            bookname = b2.bookname;
        }
        public void display()
        {
            Console.WriteLine("Book Id : " + bookid);
            Console.WriteLine("Book Title : " + bookname);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book(b1);
            Console.WriteLine("book1 details are :");
            b1.display();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("book1 details are :");
            b2.display();

            Console.ReadKey();
        }
    }
}
