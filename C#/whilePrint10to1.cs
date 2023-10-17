using System;

namespace whilePrint10to1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
