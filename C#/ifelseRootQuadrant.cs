using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootQuadrant
{
    internal class RootQuadrant
    {
        static void Main(string[] args)
        {
            int a, b, c, total;

            Console.WriteLine("Enter value of a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            total = b * b - 4 * a * c;

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
