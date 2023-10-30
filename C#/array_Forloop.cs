using System;

namespace array_Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            int sum = 0;

            Console.WriteLine("Enter num : ");
            foreach (int val in num)
            {
                num[val]=Convert.ToInt32(Console.ReadLine());

                sum =sum + num[val];
            }
            Console.WriteLine("Sum of array elements are : "+sum);

            Console.ReadKey();

        }
    }
}
