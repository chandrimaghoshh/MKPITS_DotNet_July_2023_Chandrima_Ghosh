using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Rectangle
{
    class Rectangle
    {
        float length;
        float breadth;
        float area;

        public Rectangle()
        {
            length = 5.5f;
            breadth = 2.2f;
            area = length * breadth;
        }
        public void display()
        {
            Console.WriteLine("Area of Rectangle = " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.display();

            Console.ReadKey();
        }
    }
}
