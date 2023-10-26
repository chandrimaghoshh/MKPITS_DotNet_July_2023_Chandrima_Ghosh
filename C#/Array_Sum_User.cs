using System;

namespace Array_Sum_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] num = new int[3];
            
            for(int cnt=0; cnt<3; cnt++)
            {
                Console.WriteLine("Enter num : ");
                num[cnt] = Convert.ToInt32(Console.ReadLine());
                sum = sum + num[cnt]; 
            }
            Console.WriteLine("Sum of array elements = {0}",sum);


            Console.ReadKey();
        }
    }
}
