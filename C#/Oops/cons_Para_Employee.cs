using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons_Para_Employee
{
    class Employee
    {
        int empNo;
        string empName;
        string empDesig;
        int empSalary;

        public Employee() 
        {
            empNo = 10;
            empName = "Chandrima";
            empDesig = "Manager";
            empSalary = 80000;
        }
        public Employee(int empNo, string empName, string empDesig, int empSalary)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.empDesig = empDesig;
            this.empSalary = empSalary;
        }
        public void display()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Employee No. : " + empNo);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Employee Designation : " + empDesig);
            Console.WriteLine("Employee Salary : " + empSalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(111, "csharp", "martin", 2000);

            Console.WriteLine("Enter Employee No. : ");
            int empNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name : ");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation : ");
            string empDesig = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary : ");
            int empSalary = Convert.ToInt32(Console.ReadLine());
            emp1.display();

            Console.WriteLine("-----------------------------------");

            Employee emp2 = new Employee(empNo, empName, empDesig, empSalary);

            emp2.display();

            Console.ReadKey();
        }
    }
}
