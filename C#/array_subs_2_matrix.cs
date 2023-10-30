using System;

namespace array_subs_2_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            Console.WriteLine("Enter elements of first matrix : ");
            for(int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("[{0}],[{1}] : ", row, col, arr1[row, col]);
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements of second matrix : ");
            for(int row = 0;row < 2; row++)
            {
                for(int col = 0;col < 2; col++)
                {
                    Console.Write("[{0}],[{1}] : ", row, col, arr2[row, col]);
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The first matrix : ");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr1[row, col] + "\t");
                  
                }
                Console.WriteLine();
            }

            Console.WriteLine("The second matrix : ");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr2[row, col] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Substraction of two matrix : ");
            for(int row=0; row < 2; row++)
            {
                for(int col=0; col < 2; col++)
                {
                    arr3[row, col] = arr1[row, col] - arr2[row, col];
                    Console.Write(arr3[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
