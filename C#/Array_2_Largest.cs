using System;

namespace Array_2_largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j = 0, lrg, lrg2nd;
            int[] arr1 = new int[3];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < 3; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            lrg = 0;

            for (i = 0; i < 3; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }
            
            lrg2nd = 0;
            for (i = 0; i < 3; i++)
            {
                if (i == j)
                {
                    i++; 
                    i--;
                }
                else
                {
                    if (lrg2nd < arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }

            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
            Console.ReadKey();
        }
    }
}
