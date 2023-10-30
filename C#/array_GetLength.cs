using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_GetLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int l = arr.GetLength(0);

            Console.WriteLine("Length : "+l);

            Console.ReadKey();
        }

    }
}
