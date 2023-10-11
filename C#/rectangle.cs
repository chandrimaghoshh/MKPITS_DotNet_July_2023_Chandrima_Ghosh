using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleProgram
{
    internal class Rectangle
    {
        static void Main(string[] args)
        {
            int length, breadth, area;

            Console.WriteLine("Enter length : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth : ");
            breadth = Convert.ToInt32(Console.ReadLine());

            area = length * breadth;

            Console.WriteLine("Area of Rectangle = " + area);
            Console.ReadKey();
        }
    }
}
