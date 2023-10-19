using System;

namespace doWhilePrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            int counter = 2;
            int num;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                   
                }
                counter++;
                if (flag == 0)
                {
                    Console.WriteLine("prime no");
                }
                else
                {
                    Console.WriteLine("Not prime no");
                }
            }
            while (counter < num);
                Console.ReadKey();
            
            
            }
    }
}
