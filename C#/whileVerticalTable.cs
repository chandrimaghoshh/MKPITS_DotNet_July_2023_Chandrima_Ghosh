using System;

namespace whileVerticalTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;

            Console.WriteLine("Enter limit : ");
           flag = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            int counter1 = 1;


            while (counter <= 10)
            {
                counter1 = 1;
                while(counter1 <= flag)
                {
                    Console.Write("{1} * {0} = {2}", counter, counter1, (counter * counter1));

                    Console.Write("\t");
                    counter1++;
                }
                counter++;
                Console.WriteLine();
            }
                Console.ReadKey();

        }
    }
}
