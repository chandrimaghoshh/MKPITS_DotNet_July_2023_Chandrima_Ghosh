using System;

namespace whilePrimeNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int counter = 2;
            int flag;

            while(counter <= 20)
            {
                counter = 2;
                flag = 0;
               while(counter < num)
                {
                    if(num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
               if(flag == 0)
                {
                    Console.WriteLine("Prime no {0} : ", num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
