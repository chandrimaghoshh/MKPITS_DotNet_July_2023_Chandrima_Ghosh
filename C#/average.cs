using System;

namespace average
{
    internal class Average
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, res;

            Console.WriteLine("Enter num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3 :");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num4 :");
            num4 = Convert.ToInt32(Console.ReadLine());

            res = num1 + num2 + num3 + num4 / 4;

            Console.WriteLine("Average is : " + res);

            Console.ReadKey();
        }
    }
}
