using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outof_Memory_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Chand";
            string sub = "Csharp";

            Console.WriteLine("Length of name : " + name.Length);
            StringBuilder sb = new StringBuilder(name.Length, name.Length);
            try
            {
                sb.Append(sub);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
             
        }
    }
}
