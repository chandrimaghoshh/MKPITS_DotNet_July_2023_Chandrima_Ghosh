using System;

namespace Array_2_Smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j = 0, sml, sml2nd;
            int[] arr1 = new int[3];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input {0} elements in the array (value must be <9999):\n", n);
            for (i = 0; i < 3; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
       
            sml = 0;
            for (i = 0; i < 3; i++)
            {
                if (sml > arr1[i])
                {
                    sml = arr1[i];
                    j = i;
                }
            }

 
            sml2nd = 99999;
            for (i = 0; i < 3; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (sml2nd > arr1[i])
                    {
                        sml2nd = arr1[i];
                    }
                }
            }

            Console.Write("The Second smallest element in the array is :  {0} \n\n", sml2nd);

            Console.ReadKey();
        }
    }
}
