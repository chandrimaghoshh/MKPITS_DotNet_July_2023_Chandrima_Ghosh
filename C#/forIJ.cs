using System;

namespace forIJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 0, j = 0; i <= 5;  i++, j++) 
            {
                Console.WriteLine("i = {0}, j = {1}", i,j);
            }
            Console.ReadKey();
        }
    }
}
