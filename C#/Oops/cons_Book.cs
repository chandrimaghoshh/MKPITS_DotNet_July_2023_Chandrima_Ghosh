using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Book
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        public Book()
        {
            bookid = 123;
            title = "Doremon";
            author = "Chandrima";
            price = 1500;
        }
        public void display()
        {
            Console.WriteLine("Book Details : ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Book ID : " + bookid);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Author : " + author);
            Console.WriteLine("Book Price : " + price);
            Console.WriteLine("------------------------------------");
        }
    
         
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();

            Console.ReadKey();
        }
    }
}
