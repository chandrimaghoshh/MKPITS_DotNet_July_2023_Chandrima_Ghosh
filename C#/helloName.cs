using System;

namespace helloname
{
    internal class Hello
    {
        static void Main(string[] args)
        {
            string name;
            
            Console.WriteLine("Enter Name :");

            name = Console.ReadLine();

            Console.WriteLine("Hello : " + name);
            Console.ReadKey();
        }
    }
}
