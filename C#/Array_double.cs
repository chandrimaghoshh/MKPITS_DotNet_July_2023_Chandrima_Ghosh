using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArray = new double[3];

            doubleArray[0] = 1.2;
            doubleArray[1] = 2.2;
            doubleArray[2] = 1.5;

            Console.WriteLine("num[0]= " + doubleArray[0]);
            Console.WriteLine("num[1]= " + doubleArray[1]);
            Console.WriteLine("num[2]= " + doubleArray[2]);

            Console.ReadKey();
        }
    }
}
