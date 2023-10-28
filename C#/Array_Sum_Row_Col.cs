using System;

namespace Array_sum_Row_col_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            Console.WriteLine("Enter elements of matrix: ");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 2; row++)
            {
                int sum = 0;
                for (int col = 0; col < 2; col++)
                {
                    sum = sum + arr[row, col];
                }
                Console.WriteLine("Sum of row: {0} ", sum);
            }
            for (int row = 0; row < 2; row++)
            {
                int sum = 0;
                for (int col = 0; col < 2; col++)
                {
                    sum = sum + arr[col, row];
                }
                Console.WriteLine("Sum of column: {0} ", sum);
            }
            Console.ReadKey();
        }
    }
}