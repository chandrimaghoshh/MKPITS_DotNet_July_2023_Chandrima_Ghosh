using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace gotoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) goto Even;
            Console.WriteLine("Odd No. ");

            goto End;

        Even:
            Console.WriteLine("Even No. ");

        End:
            Console.WriteLine("Bye");
           
        Console.ReadKey();
        }
    }
}
