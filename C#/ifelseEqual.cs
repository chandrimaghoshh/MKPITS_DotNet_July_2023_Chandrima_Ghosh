using System;

namespace equal2num
{
    internal class Equal
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Both num are equal" );
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            Console.ReadKey();
        }
    }
}
