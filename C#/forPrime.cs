using System;
using System.Runtime.Remoting.Services;

namespace forPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int counter = 2;
            int num;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter= 2; counter < num; counter++)
            {
                if(num % counter == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("prime no");
            }
            else
            {
                Console.WriteLine("Not prime no");
            }
            Console.ReadKey();
        }
    }
}
