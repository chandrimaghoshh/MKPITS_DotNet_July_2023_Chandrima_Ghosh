using System;

namespace doWhile1To5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine("{0}", counter);
                counter++;
            }
            while (counter <= 5);

            Console.ReadKey();
        }
    }
}
