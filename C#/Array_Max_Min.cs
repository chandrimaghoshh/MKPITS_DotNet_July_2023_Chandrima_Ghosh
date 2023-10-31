using System;

namespace Array_Max_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int max, min;
            int i;

            for( i=0; i<3; i++)
            {
                Console.Write("elements {0} - : ",i);
                arr1[i]=Convert.ToInt32(Console.ReadLine());
            }
            max = arr1[0];

            for( i=1; i<3;i++)
            {
                if (arr1[i]>max)
                {
                    max = arr1[i];
                }
            }
            min = arr1[0];


            for( i=1; i<3; i++)
            {
                if (arr1[i]<min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine("Maximum Value : " + max);
            Console.WriteLine("Minimum Value : " + min);

            Console.ReadKey();
        }
    }
}
