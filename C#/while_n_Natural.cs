using System;

namespace while_n_Natural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter = 1, sum = 0;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first n natural numbers are : ");

            while (counter <= num)
            {
                Console.WriteLine(" " + counter);

                sum = counter + sum;

                counter++;

            }
            Console.Write("Sum of n natural numbers are : " + sum);
            Console.ReadKey();
        }
    }
}
