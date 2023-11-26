using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace polymorphism_calculate
{
    class IShape
    {
        public void CalculateArea()
        {
            int length, breadth;
            int side,area;
        }
    }
    class Rectangle : IShape
    {
       public void CalculateArea()
        {
          int length, breadth;
            int side,area;
            area = length * breadth;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
