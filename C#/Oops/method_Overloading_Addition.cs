using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Overloading_Addition
{
    class calculate
    {
        public void addition(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Addition of integer num : " + res);
        }
        public void addition(float n1, float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Additon of float num : " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate cal = new calculate();

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Calling Addition of Integer Number : ");
            cal.addition(2, 3);

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Now Calling Addition of Float Number :");
            cal.addition(2.0f, 4.0f);

            Console.ReadKey();
        }
    }
}
