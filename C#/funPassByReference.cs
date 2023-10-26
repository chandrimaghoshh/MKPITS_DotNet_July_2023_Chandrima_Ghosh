using System;

namespace PassByReferenceEx
{
    internal class Program
    {
        static void display(ref int num1)
        {
            num1 = 20;//local variable
            Console.WriteLine("num inside method " + num1); //20

        }
        static void Main(string[] args)
        {
            int num = 10;
            display(ref num);
            Console.WriteLine("num after passing inside main " + num); //20
            Console.ReadKey();
        }
    }
}
