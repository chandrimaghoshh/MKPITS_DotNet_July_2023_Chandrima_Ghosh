using System;

namespace whileEvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while(counter <=10)
            {
                if(counter % 2 == 0)
                {
                    Console.WriteLine(" "+counter);
                }
                counter = counter + 1;
            }
            Console.ReadKey();
        }
    }
}
