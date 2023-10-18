using System;
using System.Xml.Schema;

namespace doWhileAvgSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("The first 10 natural number is :");

            int num, counter = 1; 
            float avg = 0,sum = 0;

            

            do
            {
                Console.Write("Enter num :");
                num = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("" + counter);
                sum = counter + sum;
                //avg = sum / num;

                counter++;
            }
            while (counter <= 10);

            avg = sum / num;
            Console.WriteLine("The sum is :" + sum);
            Console.WriteLine("The average is : " + avg);

            Console.ReadKey();
        }
    }
}
