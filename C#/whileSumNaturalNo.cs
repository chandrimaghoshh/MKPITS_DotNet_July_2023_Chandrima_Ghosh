using System;

namespace whileSumNaturalNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 Natural numbers :");
            int counter = 1, sum=0;

            while (counter <= 10)
            {
                Console.WriteLine(" " + counter);

                sum = counter + sum;

                counter++;

            }
            Console.Write("Sum of 10 natural numbers are : " + sum);
            Console.ReadKey();
        }
    }
}
