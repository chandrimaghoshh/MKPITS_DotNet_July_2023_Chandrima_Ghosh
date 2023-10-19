using System;

namespace forTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1; ;
            int counter;
            int res = 0;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter = 1; counter<=10; counter++)
            {
                res = num * counter;
                Console.WriteLine("{1} x {2} = {0}",res,num,counter);
            }
            Console.ReadKey();
        }
    }
}
