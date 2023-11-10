using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Class
{
    static class Math
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of Pi : " + Math.pi);
            Console.WriteLine("Value of cube : " + Math.cube(5));

            Console.ReadKey();
        }
    }
}
