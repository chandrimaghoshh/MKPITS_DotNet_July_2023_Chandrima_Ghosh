using System;

namespace Float
{
    internal class Float
    {
        static void Main(string[] args)
        {
            float f;

            Console.WriteLine("Enter number : ");
            f = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Number is : " + f);

            Console.ReadKey();
        }
    }
}
