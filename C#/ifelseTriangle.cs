using System;
using System.Security.Policy;

namespace triangle
{
    internal class traingle
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c :");
            c = Convert.ToInt32(Console.ReadLine());

            if(a==b && b==c)
            {
                Console.WriteLine("Triangle is Equvilateral");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene");
            }
            Console.ReadKey();
        }
    }
}
