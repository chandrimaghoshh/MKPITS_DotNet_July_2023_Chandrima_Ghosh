using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Baseclass_Childclass
{
    class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("Hello from base class method");
        }
    }
    class childclass : baseclass
    {
        public override void show()
        {
            Console.WriteLine("Hello from child class method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            baseclass b = new childclass();
            b.show();

            Console.ReadKey();
        }
    }
}
