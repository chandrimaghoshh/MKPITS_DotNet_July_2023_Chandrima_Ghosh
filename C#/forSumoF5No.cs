using System;
using System.Runtime.Remoting.Services;

namespace forSumoF5no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter;
            int sum = 0;

            for(counter = 1; counter <=5; counter++)
            {
                    Console.WriteLine("Enter num:");
                    num = Convert.ToInt32(Console.ReadLine());

                    sum = sum + num;
                
            }
            Console.WriteLine("Sum of 5 num : " + sum);
            Console.ReadKey();
        }
    }
}
