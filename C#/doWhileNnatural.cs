using System;
using System.Diagnostics.CodeAnalysis;

namespace doWhileNnatural
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, sum = 0,counter =1 ;
           
            Console.WriteLine("Enter num :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first num natural number is :");
            do
            {
                Console.WriteLine("" + counter);
                sum = counter + sum;
                counter++;
            }
            while (counter <= num);

            Console.WriteLine("The sum is : " + sum);

            Console.ReadKey();


        }
    }

}