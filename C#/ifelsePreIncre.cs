using System;

namespace PreIncreament
{
    internal class Preincreament
    {
        static void Main(string[] args)
        {
            int i, j;

            i = 0;
            j = ++i;

            Console.WriteLine("Value of i : " + i);
            Console.WriteLine("Value of j : " + j);

            Console.ReadKey();
        }
    }
}
