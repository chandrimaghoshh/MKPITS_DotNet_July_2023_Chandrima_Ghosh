﻿using System;

namespace array_sum_left_diagonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
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
                    if(row!=col)
                    {
                        sum = sum + arr1[row, col];
                    }
                }
            }
            Console.WriteLine("The matrix is : ");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr1[row, col] + "\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition of the left Diagonal elements is : " + sum);
            Console.ReadKey();

        }
    }
}
