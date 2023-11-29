using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handler_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter num1 : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2 : ");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n;
            }
            catch (Exception ee)
            {
                Console.WriteLine("Cannot divided by zero");
            }
            Console.WriteLine("Result : " + res);
            Console.ReadKey();

        }
    }
}
