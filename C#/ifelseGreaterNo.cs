using System;

namespace greaterNo
{
    internal class Greater
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else
            {
                Console.WriteLine("num2 is greater");
            }
            Console.ReadKey();
        }
    }
}
