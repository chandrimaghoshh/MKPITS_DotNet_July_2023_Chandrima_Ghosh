using System;

namespace Long_ulong
{
    internal class Long
    {
        static void Main(string[] args)
        {
            //signed
            long l;

            Console.Write("Enter number : ");
            l = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Number for long : " + l);

            //uint -  unsigned
            ulong ul;

            Console.Write("Enter number : ");
            ul = Convert.ToUInt64(Console.ReadLine());

            Console.Write("Number for ulong : " + ul);

            Console.ReadKey();
        }
    }
}
