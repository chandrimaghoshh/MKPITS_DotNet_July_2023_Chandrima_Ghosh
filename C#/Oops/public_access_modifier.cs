using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_modifier
{
    class PublicTest
    {
        public string name = "Chandrima Ghosh";
        public void msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PublicTest test = new PublicTest();
            Console.WriteLine("Hello" + test.name);

            test.msg("Chandu");
            Console.ReadKey();
        }
    }
}
