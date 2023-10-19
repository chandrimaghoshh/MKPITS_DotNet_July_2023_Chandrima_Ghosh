using System;

namespace forPrint1To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int counter;

            for(counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("" + counter);
            }
            Console.ReadKey();
        }
    }
}
