using System;

namespace multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mul;

            Console.Write("Enter num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num3 :");
            num3 = Convert.ToInt32(Console.ReadLine());

            mul = num1 * num2 * num3;

            Console.WriteLine("Multiplication : " + mul);

            Console.ReadKey();
        }
    }
}
