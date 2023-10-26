using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_float

{
    internal class Program
    {
        static void Main(string[] args)
        {
            float [] floatArray = new float[3];

            floatArray[0] = 1.2f;
            floatArray[1] = 2.2f;
            floatArray[2] = 1.5f;

            Console.WriteLine("num[0]= " + floatArray[0]);
            Console.WriteLine("num[1]= " + floatArray[1]);
            Console.WriteLine("num[2]= " + floatArray[2]);

            Console.ReadKey();

        }
    }
}
