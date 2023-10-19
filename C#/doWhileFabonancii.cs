using System;

namespace doWhileFabonancii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1 = 0, num2 = 1;
            int counter = 3;
            int add = num1 + num2;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0},{1},", num1, num2);
            Console.Write("{0},", add);
            do
            {
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                counter++;
                Console.Write("{0},", add);
            }
            while (counter <= num);
           
            Console.ReadKey();
        }
    }
}
