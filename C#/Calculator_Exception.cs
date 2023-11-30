using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_exception
{
    class Calculate
    {
        public double a, b;
        public double res;
        public void Addition(double a, double b)
        {
           res= a + b;
        }
        public void Substraction(double a, double b)
        {
            res = a - b;
        }
        public void Multiplication(double a, double b)
        {
            res = a * b;
        }
        public void Division(double a, double b)
        {
             if(a!=0 && b!=0)
            {
                res = a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Calculate c = new Calculate();
                c.Addition(10, 5);
                Console.WriteLine("Addition = " + c.res);

                c.Substraction(10, 5);
                Console.WriteLine("Substraction = " + c.res);

                c.Multiplication(10, 5);
                Console.WriteLine("Multiplication = " + c.res);

                c.Division(10, 0);
                Console.WriteLine("Division = " + c.res);

            Console.ReadKey ();
        }
    }
}
