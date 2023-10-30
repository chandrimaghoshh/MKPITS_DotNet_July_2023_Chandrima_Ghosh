using System;

namespace Array_Sort_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 6 };

            Array.Sort(arr);

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
