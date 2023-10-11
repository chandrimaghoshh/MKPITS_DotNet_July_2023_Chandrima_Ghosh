using System;
using System.Threading;

namespace table
{
    internal class Table
    {
        static void Main(string[] args)
        {
            int num, sum=1, cnt;

            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            
            for(cnt=1;cnt<=10;cnt++)
            {
                sum = num * cnt;
                Console.WriteLine(num + "*" + cnt + "=" + sum);
               
            }
            Console.ReadKey();
        }
    }
}
