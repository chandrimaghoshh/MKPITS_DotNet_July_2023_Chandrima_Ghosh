using System;

namespace @byte
{
    internal class Byte
    {
        static void Main(string[] args)
        {
            byte b;

            Console.WriteLine("Enter number : ");
            b = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Number for btye : " + b);

            //sbyte

            sbyte b1;
            Console.WriteLine("Enter number : ");
            b1 = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Number for sbyte : " + b1);

            Console.ReadKey();
        }
    }
}
