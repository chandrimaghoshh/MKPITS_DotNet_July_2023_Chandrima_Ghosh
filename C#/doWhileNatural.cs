using System;

namespace doWhileNatural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 natural number is :");
            int num = 1, sum = 0;

            do
            {
                Console.WriteLine("" +num);
                sum = num + sum;
                num++;
            }
            while (num <= 10);

            Console.WriteLine("The Sum is : " + sum);
            
            Console.ReadKey();
        }
    }
}
