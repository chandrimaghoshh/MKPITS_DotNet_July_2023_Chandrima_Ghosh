using System;

namespace nestedFor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int oc = 1; oc<=3;  oc++)
            {
                for(int ic = 1;ic<=oc; ic++)
                {
                    Console.Write("* \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
