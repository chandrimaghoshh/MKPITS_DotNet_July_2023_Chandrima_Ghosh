using System;

namespace whileAverageSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;
                int sum = 0;
                float avg=0;

            

            while (counter <= 10)
            {
                Console.WriteLine(" " + counter);

                avg = sum / 10.0f;
                sum = counter + sum;

                counter++;

            }
            Console.WriteLine("Average of 10 natural numbers are : "+avg);
            Console.Write("Sum of n natural numbers are : " + sum);
            Console.ReadKey();
        }
    }
}
