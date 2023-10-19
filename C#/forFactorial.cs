using System;

namespace forFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int counter, num;

            Console.WriteLine("Enter num :");
            num = Convert.ToInt32(Console.ReadLine());  

            for(counter = 1; counter <= num; counter++)
            {
                fact = fact * counter;
                Console.WriteLine("Factorial is :{0}", fact );
            }
            Console.ReadKey();
        }
    }
}
