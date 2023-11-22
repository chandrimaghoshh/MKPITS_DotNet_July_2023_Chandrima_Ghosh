using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class ProtectedTest
    {
        protected internal string name = "Chandrima";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProtectedTest pp = new ProtectedTest();
            pp.name = "Chestu";
            Console.WriteLine(pp.name);

            Console.ReadKey();
        }
    }
}
