using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evnod
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2 ==0)
            {
                Console.WriteLine("Num is even");
            }
            else
            {
                Console.WriteLine("Num is odd");
            }
            Console.ReadKey();
        }
    }
}
