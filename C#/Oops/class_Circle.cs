using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Circle
{
    internal class Program
    {
        class Circle
        {
            int radius;
            float circle;
            float circ;

            public void getdata(int radius)
            {
                this.radius = radius;
                
                circle = 3.14f * radius * radius;
                circ = 2 * 3.14f * radius;
            }
            public void displaydata()
            {
                Console.WriteLine("Area of Circle = " + circle);
                Console.WriteLine("Area of Circumference = " + circ);
            }
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();

            c.getdata(7);
            c.displaydata();

            Console.ReadKey();
        }
    }
}
