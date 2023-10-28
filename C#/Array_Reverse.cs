using System;

namespace Array_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            for(int cnt = 0; cnt<3; cnt++)
            {
                Console.WriteLine("Enter 10 numbers : ");
                num[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for(int cnt = 0;cnt<3; cnt++)
            {
                Console.WriteLine("element {0} - {1} ",cnt, num[cnt]);
            }

            Console.WriteLine("The values store into the array are: ");
            for(int cnt=0;cnt<3; cnt++)
            {
                Console.Write("{0} ", num[cnt]);
            }
            Console.WriteLine();

            Console.WriteLine("The values store into the array in reverse are : ");
            for (int cnt = 3 - 1; cnt >= 0; cnt--)
            {
                Console.Write("{0} ", num[cnt]);
            }
            Console.ReadKey();0
        }
    }
}
