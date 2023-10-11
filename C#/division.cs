using System;

namespace divProgram
{
    internal class Divide
    {
        static void Main(string[] args)
        {
            float num1, num2, div;

            Console.Write("Enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            div = num1 / num2;

            Console.WriteLine("Division : "+div);
            Console.ReadKey();
        }
    }
}
