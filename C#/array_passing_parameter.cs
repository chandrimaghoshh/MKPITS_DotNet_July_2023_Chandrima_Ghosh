using System;

namespace array_passing_parameter
{
    internal class Program
    {
        static void acceptarray(int[]arr)
        {
            int sum = 0;
            for (int i = 0; i<arr.Length; i++) 
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum of array elements are : " + sum);
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            acceptarray(num);

            int[] num1 = { 11, 22, 33 };
            acceptarray(num1);

            Console.ReadKey();
        }
    }
}
