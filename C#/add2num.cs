using System;

namespace addProgram
{
    internal class addition
    {
        static void Main(string[] args)
        {
            int num1, num2, add;

            Console.WriteLine("Enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;

            Console.WriteLine("Addition : " + add);
            Console.ReadKey();
            

        }
    }
}
