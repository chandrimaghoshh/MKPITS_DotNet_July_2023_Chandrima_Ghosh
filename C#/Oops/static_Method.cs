using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Method
{
    internal class Program
    {
        static void display()
        {
            Console.WriteLine("Hello from static method");
        }
        static void Main(string[] args)
        {
            display();

            Console.ReadKey();  //to access static method display instance is not required
        }
    }
}
