using System;

namespace nestedFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 2 3
              1 2 3
              1 2 3*/

            for(int oc=1; oc<=3; oc++)
            {
                for(int ic=1; ic<=3; ic++)
                {
                    Console.Write("{0}", ic);
                }
                Console.WriteLine("\t");
            }
            Console.ReadKey();
        }
    }
}
