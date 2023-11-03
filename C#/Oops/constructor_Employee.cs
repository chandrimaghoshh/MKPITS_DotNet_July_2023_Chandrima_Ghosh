using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Employee
{
    class Employee
    {
        int no;
        string name;
        string desig;
        double salary;

        public Employee()
        {
            no = 1;
            name = "Chandrima";
            desig = "Manager";
            salary = 70000;
        }
           
        public void display()
        {
            Console.WriteLine("Employee No. : " + no);
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Designation : " + desig);
            Console.WriteLine("Employee Salary : " + salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.display();

            Console.ReadKey();
        }
    }
}
