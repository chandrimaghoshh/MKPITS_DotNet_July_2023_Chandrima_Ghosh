using System;

namespace Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num=new int[3];
            int sum = 0;
            for(int cnt=0; cnt<3; cnt++)
            {
                Console.WriteLine("Enter 3 number : ");
                num[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input 3 elements in the array :");
            for(int cnt=0; cnt<3;cnt++)
            {
                Console.WriteLine("elements {0} - {1} ",cnt, num[cnt]);
            }
            Console.WriteLine("Sum of all elements stored in the array is : ");
            for(int cnt=0; cnt<3; cnt++)
            {
                sum = sum +num[cnt];
               
            }
            Console.WriteLine("{0} ", sum);
            Console.ReadKey();
        }
    }
}
