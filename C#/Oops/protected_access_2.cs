using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_2
{
    class Test
    {
        protected string name = "Chandrima";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    
    internal class Program : Test
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello " + p.name);
            p.Msg ("Chandu");

            Console.ReadKey();
        }
    }
}
