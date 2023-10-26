using System;

namespace PassByReference_Circle
{
    class Program
    {
        static void calculate(ref int radius, ref float circle, ref float circ)
        {
            circle = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius;
            float circle = 0;
            float circ = 0;

            Console.WriteLine("Enter Radius : ");
            radius = Convert.ToInt32(Console.ReadLine());

            calculate(ref radius, ref circle, ref circ);

            Console.WriteLine("Area of Circle : " + circle);
            Console.WriteLine("Area of Circumference : " + circ);

            Console.ReadKey();
        }
    }
}
