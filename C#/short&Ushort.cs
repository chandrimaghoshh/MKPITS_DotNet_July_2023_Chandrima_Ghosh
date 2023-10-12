using System;

namespace @short
{
    internal class shortu
    {
        static void Main(string[] args)
        {
            // short for neg & p+ no.

            short s;

            Console.Write("Enter number :");
            s = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Number for short : "+s);

            //ushort is unsigned

            ushort us;

            Console.Write("Enter number : ");
            us = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Number for ushort : " + us);
         

            Console.ReadKey();

        }
    }
}
