using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{ 
    class Program
    {
        private string name = "Shantosh Kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            // Accessing private variable  
            Console.WriteLine("Hello " + program.name);
            // Accessing private function  
            program.Msg("Peter Decosta");

            Console.ReadKey();
        }
    }
}