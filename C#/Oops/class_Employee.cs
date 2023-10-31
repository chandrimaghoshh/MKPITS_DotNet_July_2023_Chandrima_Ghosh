using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Employee
{
    internal class Program
    {
        class Employee
        {
            int emp_no;
            string emp_name;
            string emp_desig;
            int emp_salary;

            public void getdata(int eno, string en, string dg, int sal)
            {
                emp_no = eno;
                emp_name = en;
                emp_desig = dg;
                emp_salary = sal;
            }
            public void displaydata()
            {
                Console.WriteLine("Employee No. : " + emp_no);
                Console.WriteLine("Employee Name : " + emp_name);
                Console.WriteLine("Employee Designation : " + emp_desig);
                Console.WriteLine("Employee Salary : " + emp_salary);
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.getdata(123, "Chandrima", "Manager", 60000);
            emp.displaydata();

            Console.ReadKey();
        }
    }
}
