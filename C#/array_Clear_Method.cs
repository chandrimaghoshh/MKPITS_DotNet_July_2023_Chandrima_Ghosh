using System;

namespace array_Clear_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2 };

            Array.Clear(arr, 0, 1);

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
