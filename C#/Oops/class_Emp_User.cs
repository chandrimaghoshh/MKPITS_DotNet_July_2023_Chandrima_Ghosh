using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_emp_user
{
    internal class Program
    {
        class Employee
        {
            int emp_no;
            string emp_name;
            string emp_desig;
            int emp_salary;

            public void getdata(int emp_no, string emp_name, string emp_desig, int emp_salary)
            {
                this.emp_no = emp_no;
                this.emp_name = emp_name;
                this.emp_desig = emp_desig;
                this.emp_salary = emp_salary;
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

            Console.WriteLine("Enter Employee No. : ");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation : ");
            string empdesig = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary : ");
            int empsal = Convert.ToInt32(Console.ReadLine());

            emp.getdata(empno, empname, empdesig, empsal);
            emp.displaydata();

            Console.ReadKey();
        }
    }
}
