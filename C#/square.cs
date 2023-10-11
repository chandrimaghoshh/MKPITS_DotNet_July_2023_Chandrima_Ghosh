using System;
using System.Runtime.Remoting.Services;

namespace squareProgram
{
    internal class square
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Area of square = " + square);
            Console.ReadKey();
        }
    }
}
