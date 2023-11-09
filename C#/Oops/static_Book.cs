using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Book
{
    class Book
    {
        static public int bookid;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 12;
            Console.WriteLine("Book Id : " + Book.bookid);

            Console.ReadKey();
        }
    }
}
