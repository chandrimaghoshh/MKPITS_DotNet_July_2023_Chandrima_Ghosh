using System;

namespace array_Copy_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr1 = new int[5];

            Array.Copy(arr, arr1,5);

            for(int i =0; i < arr1.Length; i++)
            {
                Console.WriteLine (arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
