using System;

namespace forNaturalAvgSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int sum = 0;
            float avg = 0;

            for(counter = 1; counter <=10; counter++)
            {
                Console.WriteLine("Enter num : ");
                num = Convert.ToInt32(Console.ReadLine());

                sum = sum + num;
                avg = sum / 10.0f;
            }
            Console.WriteLine("Sum is = {0}", sum);
            Console.WriteLine("Average is = {0}", avg);
            Console.ReadKey();
        }
    }
}
