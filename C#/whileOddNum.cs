using System;


namespace whileOddNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 20;

            while(counter <30)
            {
                if(counter % 2 != 0)
                {
                    Console.WriteLine("{0} is odd num", counter);
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
