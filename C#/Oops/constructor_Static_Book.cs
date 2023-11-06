using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Static_Book
{
    class Book
    {
        static string booktitle;
        static string bookauthor;
        static Book()
        {
            Console.WriteLine("Static constructor called");
            booktitle = "Throne";
            bookauthor = "Chandrima";
        }
        public static void display()
        {
            Console.WriteLine("Book Title : " + booktitle);
            Console.WriteLine("Book Author : " + booktitle);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.display();
            Console.ReadKey();
        }
    }
}
