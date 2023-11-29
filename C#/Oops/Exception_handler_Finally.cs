using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handler_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter numm1 : ");
            num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 : ");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n; 
            }
            catch (Exception ee)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine("Result : " + res);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
                Console.WriteLine("Result : " + res);
            }
            Console.ReadKey();

        }
    }
}
