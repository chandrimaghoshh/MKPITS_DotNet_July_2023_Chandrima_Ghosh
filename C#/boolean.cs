using System;

namespace boolean
{
    internal class boolean
    {
        static void Main(string[] args)
        {
            Boolean b;

            Console.WriteLine("True or False");
           
            b = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Boolean is : " + b);

            Console.ReadKey();



        }
    }
}
