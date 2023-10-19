using System;

namespace forNaturalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 Natural numbers :");

            int counter = 1;
            int sum = 0;

            for (counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("{0}", counter);
                sum = sum + counter;
            }
           
            Console.WriteLine("Sum of 10 natural number is = {0}", sum);
            Console.ReadKey();
        }
    }
}
