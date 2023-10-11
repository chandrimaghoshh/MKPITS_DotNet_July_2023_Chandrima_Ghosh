using System;
using System.Data.SqlClient;

namespace circleProgram
{
    internal class Circle
    {
        static void Main(string[] args)
        {
            int radius; 
            float area,circ;

            Console.WriteLine("Enter Radius : ");
            radius = Convert.ToInt32(Console.ReadLine());

            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;

            Console.WriteLine("Area of circle = " + area);
            Console.WriteLine("Circumference of cicle = " + circ);

            Console.ReadKey();
        }
    }
}
