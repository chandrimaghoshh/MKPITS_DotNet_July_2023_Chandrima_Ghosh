using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_constructor
{
    class Company
    {
        public string name = "Fendhal";

        public Company()
        {
            Console.WriteLine("Base class constructor");
            Console.WriteLine("Company Name : " + name);
        }
    }
    class Frenchis : Company
    {
        public string name = "Mkpits";
        public Frenchis()
        {
            Console.WriteLine("Derived class constructor");
            Console.WriteLine("Frenchis Name : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Frenchis f = new Frenchis();

            Console.ReadLine();
        }
    }
}
