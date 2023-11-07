using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor_Employee
{
    class Employee
    {
        //creating a constructor

        public Employee()
        {
            Console.WriteLine("Constructor called");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor called");
        }
    }
                    //use clt F5 for full output and stay the output
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.ReadKey();

            Employee e2 = new Employee();
            Console.ReadKey();
        }
    }
}
