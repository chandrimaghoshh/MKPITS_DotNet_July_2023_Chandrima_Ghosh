using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_Shape
{
    abstract class Shape
    {
        public abstract void draw();
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Code for rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.draw();

            Console.ReadKey();
        }
    }
}
