using System;

namespace swapProgram
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swap : ");
            Console.WriteLine("num1 : " + num1);
            Console.WriteLine("num2 : " + num2);

            Console.ReadKey();
        }
    }
}
