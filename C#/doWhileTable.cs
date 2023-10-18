using System;

namespace doWhile.Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter = 1, res = 0;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                res = num * counter;
                counter++;
                Console.WriteLine("{0} x {1} = {2}", num, counter,res);
            }
            while (counter <= 10);

            Console.ReadKey();
        }
    }
}
