using System;


namespace Array_Seperate_Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Num: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0, k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("Even no: ");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("{0} ", arr2[i]);
            }
            Console.WriteLine("Odd no: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.ReadKey();

        }
    }
}
