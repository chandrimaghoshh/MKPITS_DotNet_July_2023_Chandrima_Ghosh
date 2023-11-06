using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Book
    {
        int bookid;
        String title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;

        }
        //method overloaded 
        public void getdata(int bookid)
        {
            this.bookid = bookid;

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;

        }
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.display();
            Console.WriteLine("-----------------book1 details ----------");
            Book b1 = new Book();
            b1.getdata(111, "csharp");
            b1.display();

            Console.WriteLine("-----------------book1 details ----------");
            Book b2 = new Book();
            b2.getdata(111, "csharp", "manish");
            b2.display();

            Console.WriteLine("-----------------book1 details ----------");

            Book b3 = new Book();
            b3.getdata(111, "csharp", "arti", 444);
            b3.display();

            Console.WriteLine("-----------------book1 details ----------");

            Console.ReadLine();

        }
    }
}