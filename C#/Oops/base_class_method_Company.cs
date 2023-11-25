using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_method_Company
{
    class Company
    {
        public string name = "mkcl";

        public void display()
        {
            Console.WriteLine("Company Name : " + name);
        }
    }
    class Franchise : Company
    {
        public string name = "mkpits";

        public void display()
        {
            base.display();
            Console.WriteLine("Franchise Name : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchise f = new Franchise();
            f.display();

            Console.ReadLine();
        }
    }
}
