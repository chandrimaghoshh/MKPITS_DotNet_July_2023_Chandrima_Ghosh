using System;

namespace PassByValueEx
{
    internal class Program
    {
        static void display(int num)
        {
            int num1 = 20;//local varaiable

            Console.WriteLine("Num inside method : "+ num1);
        }
        static void Main(string[] args)
        {
            int number = 10; ;
            display(number);
            Console.WriteLine("num after passing inside main : " + number);


            Console.ReadKey();
        }
    }
}
