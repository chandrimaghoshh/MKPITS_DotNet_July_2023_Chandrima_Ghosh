using System;

namespace forNatural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter=1;

            for(counter=1; counter<=10; counter++)
            {
                Console.WriteLine("{0}", counter);
            }
           
            Console.ReadKey();
        }
    }
}
