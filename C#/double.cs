using System;

namespace Double
{
    internal class Double
    {
        static void Main(string[] args)
        {
            double d;

            Console.WriteLine("Enter number : ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number is : " + d);

            Console.ReadKey();

        }
    }
}
