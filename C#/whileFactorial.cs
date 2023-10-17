using System;

namespace whileFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact=1;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial is : " + fact);

            Console.ReadKey();
        }
    }
}
