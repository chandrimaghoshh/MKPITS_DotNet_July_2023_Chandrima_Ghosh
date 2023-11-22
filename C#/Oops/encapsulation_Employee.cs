using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_Employee
{
    class Employee
    {
        public string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.name = "Chandrima";
            Console.WriteLine("Employee Name : " + e.name);

            Console.ReadKey();
        }
    }
}
