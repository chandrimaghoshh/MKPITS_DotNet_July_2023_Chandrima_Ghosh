using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_access_specifier
{
    class Test
    {
        internal string name = "chandrima";
        internal void msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Console.WriteLine("Hello " + t.name);
            t.msg("Chester");

            Console.ReadKey();
        }
    }
}
