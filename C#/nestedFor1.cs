using System;

namespace nestedFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int oc=1; oc<=3;  oc++)
            {
                for(int ic=1; ic<=3; ic++)
                {
                    Console.Write(" {0}",oc,ic);
                }
                Console.WriteLine("\t");
            }
            Console.ReadKey();
        }
    }
}
