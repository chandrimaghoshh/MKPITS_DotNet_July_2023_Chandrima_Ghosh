using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionAdd2Num
{
    class Program
    {
        static int add(int num1, int num2)
        {
            int res = 0;
            res = num1 + num2;

            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = add(num1, num2);
            Console.WriteLine("Additon = " + res);

            Console.ReadKey();
        }
    }
}
