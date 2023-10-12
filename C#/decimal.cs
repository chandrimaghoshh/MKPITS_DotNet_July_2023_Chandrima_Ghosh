using System;

namespace @decimal
{
    internal class Decimal
    {
        static void Main(string[] args)
        {
            decimal d;
            Console.WriteLine("Enter number : ");
            d = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Number is : " + d);

            Console.ReadKey();
        }
    }
}
