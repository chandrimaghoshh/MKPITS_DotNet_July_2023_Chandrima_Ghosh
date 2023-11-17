using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Shape
{
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing...");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.draw();

            Rectangle r = new Rectangle();  
            r.draw();

            Circle c = new Circle();
            c.draw();

            Console.ReadKey();
        }
    }
}
