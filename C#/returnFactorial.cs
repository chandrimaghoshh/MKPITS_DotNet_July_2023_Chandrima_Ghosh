using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnFactorial
{
    class Program
    {
        static int factorial(int num)
        {
            int fact = 1;
            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int res = factorial(num);
            Console.WriteLine("Factorial = " + res);

            Console.ReadKey();
        }
    }
}
