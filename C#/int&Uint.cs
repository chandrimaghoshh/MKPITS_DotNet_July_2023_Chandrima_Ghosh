using System;

namespace int_uint
{
    internal class Int
    {
        static void Main(string[] args)
        {
            //signed
            int i;

            Console.WriteLine("Enter Number : ");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number for int : " + i);


            //uint (unsigned)

            uint ui;

            Console.WriteLine("Enter Number : ");
            ui = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Number for uint : " + ui);

            Console.ReadKey();
        }
    }
}
