using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_Shapes_different
{
    abstract class Shape
    {
        public abstract void draw();
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();

            Console.ReadKey();

        }
    }
}
