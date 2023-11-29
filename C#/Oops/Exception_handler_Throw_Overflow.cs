using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handler_Throw_overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("enter age ");
                age = Convert.ToInt32(Console.ReadLine());
                //if the user enters age below 18 then throw the exception
                if (age < 18)
                {
                    throw new Exception("age should be greater or equal to 18");
                }
            }
            catch (OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter a small number please");
                age = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("enter age 18 or greater than 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("Age = " + age);

            }

            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
