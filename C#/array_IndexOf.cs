using System;

namespace array_indexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int i=Array.IndexOf(arr, 4);

            Console.WriteLine("Index of 4 is : " +i); 

            Console.ReadKey();

        }
    }
}
