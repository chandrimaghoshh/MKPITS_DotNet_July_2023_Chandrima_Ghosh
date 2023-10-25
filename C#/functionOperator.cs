using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOperator
{
    class Program
    {
        static int calculate(int num1, int num2, char op)
        {
            int res = 0;
            if(op == '+')
            {
               res = num1 + num2;
            }
            else if (op == '-')
            {
                res = num1 - num2;
            }
            else if (op == '*')
            {
                res = num1 * num2;
            }
            else if (op == '/')
            {
                res = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator (+,-,*,/) : ");
            char op = Convert.ToChar(Console.ReadLine());

            int res = calculate(num1, num2, op);
            Console.WriteLine("Result = " + res);

            Console.ReadKey();

        }
    }
}
