using System;

namespace Array_Mul_2_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = { {2, 2 }, { 4, 4 } };
            int[,] arr3 = new int[2, 2];

            for(int r=0; r<2; r++)
            {
                for(int c=0; c<2; c++)
                {
                    arr3[r, c] = arr1[r, c] * arr2[r,c];

                    Console.Write(arr3[r, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
