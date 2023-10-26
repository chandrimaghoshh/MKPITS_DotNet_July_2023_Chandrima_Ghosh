using System;
using System.Security.Principal;

namespace Output_ParaEx
{
    internal class Program
    {
        static void calculate( int radius, out float circle, out float circ)
        {
            
            circle = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float circle, circ;

            calculate( radius, out circle, out circ);

            Console.WriteLine("Area of Circle : "+ circle );
            Console.WriteLine("Area of Circumference : " + circ);

            Console.ReadKey();
        }
    }
}
