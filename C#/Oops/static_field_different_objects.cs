using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_different_objects
{
    class Book
    {
        static string title;
        static Book()
        {
            Console.WriteLine("Static constructor called");
            title = "mkpits";
        }
        public void display()
        {
            Console.WriteLine("Book Title : " + title);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.display();

            Book b2 = new Book();
            b2.display();

            Console.ReadKey();

        }
    }
}
