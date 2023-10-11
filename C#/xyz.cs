using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyzProgram
{
    internal class xyz
    {
        static void Main(string[] args)
        {
            int x, y, z, res;

            Console.WriteLine("Enter num1 :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 :");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3 :");
            z = Convert.ToInt32(Console.ReadLine());

            res = (x + y) * z;
            Console.WriteLine("Result1 : " + res);

            res = x * y + y * z;
            Console.WriteLine("Result2 : " + res);

            Console.ReadKey();
        }
    }
}
