using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sum_Right_Diagonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];
            int sum = 0;

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("elements - [{0}],[{1}] : ", row, col, arr1[row, col]);
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    if (row==col)
                    {
                        sum = sum + arr1[row, col];
                    }
                }
            }
            Console.Write("The matrix is :\n");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr1[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Addition of the right Diagonal elements is :{0}\n",sum);
            Console.ReadKey();
        }
    }
}
