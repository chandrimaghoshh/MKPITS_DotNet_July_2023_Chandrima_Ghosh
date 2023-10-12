using System;

namespace Char
{
    internal class Char
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("enter charact");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("char : " + ch);

            Console.ReadKey();
        }
    }
}
