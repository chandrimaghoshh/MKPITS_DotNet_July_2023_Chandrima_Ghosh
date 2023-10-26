using System;

namespace Array_New_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            Console.WriteLine("num[0] = " + num[0]);
            Console.WriteLine("num[1] = " + num[1]);
            Console.WriteLine("num[2] = " + num[2]);

            Console.ReadKey();

        }
    }
}
