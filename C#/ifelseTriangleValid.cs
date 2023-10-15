using System;

namespace triangleValid
{
    internal class Triangle
    {
        static void Main(string[] args)
        {
            int a, b, c,sum;

            Console.WriteLine("Enter a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c : ");
            c = Convert.ToInt32(Console.ReadLine());

            sum = a + b + c;

            if(sum == 180)
            {
                Console.WriteLine("Triangle is valid");
            }
            else
            {
                Console.WriteLine("Triangle is not valid");
            }
            Console.ReadKey();
        }
    }
}
