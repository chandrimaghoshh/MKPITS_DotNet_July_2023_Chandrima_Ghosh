using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_more_Method
{
    class Book
    {
        public static int bookid;
        public static void display()
        {
            Console.WriteLine("Hello form static display method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.display();

            Book.bookid = 12;

            Program p = new Program();
            p.Main();

            Console.WriteLine("Book ID : " + Book.bookid); 
        }
        void Main()
        {
            Console.WriteLine("Hello from Main method");

            Console.ReadKey();
        }
    }
}
