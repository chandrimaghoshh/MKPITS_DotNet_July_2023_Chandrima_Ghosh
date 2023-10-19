using System;

namespace forOddNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter = 1;
            int sum = 1;
            int total = 0;

            Console.WriteLine("Enter number :");
            num = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (sum <= num)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("Odd No. : {0}", counter);
                        sum = sum + 1;
                        total = total + num;

                    }
                }
               
                else
                {
                    break;
                }
                counter++;
            
            }
            Console.WriteLine("sum of all numbers : {0}", total);
            Console.ReadKey();
        }
    }
}
