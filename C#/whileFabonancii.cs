using System;

namespace whileFabonancii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1 = 0, num2 = 1;
            int add = num1 + num2;
            int counter=1;


            Console.Write("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0},{1},", num1, num2);
            while(counter <= num)
            {
                Console.Write("{0},", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                counter = counter + 1;
                counter++;
            }
            Console.ReadKey();
        }
    }
}
