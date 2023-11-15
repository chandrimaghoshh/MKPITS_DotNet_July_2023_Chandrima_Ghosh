using System;


namespace constructor_Circle
{
    class Circle
    {
        int radius;
        float circle;
        float circ;

        public Circle()
        {
            radius = 5;
            circle = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        public void display()
        {
            Console.WriteLine("Area of Circle = " + circle);
            Console.WriteLine("Area of Circumference = " + circ);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.display();

            Console.ReadKey();
        }
    }
}
