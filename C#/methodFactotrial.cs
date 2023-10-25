using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodFactorial
{
    class Program
    {
        static void factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial = " + fact);
        }
       
        static void Main(string[] args)
        {
            factorial(5);

            Console.ReadKey();
        }
    }
}
