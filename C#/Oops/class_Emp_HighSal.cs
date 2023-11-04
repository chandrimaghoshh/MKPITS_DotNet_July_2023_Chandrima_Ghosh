using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Emp_HighSal
{
    internal class Program
    {
        class Employee
        {
            string name;
            int id;
            int salary;

            public void getdata(string name, int id, int salary)
            {
                this.name = name;
                this.id = id;
                this.salary = salary;
            }
            public void displaydata()
            {
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Employee Id : " + id);
                Console.WriteLine("Employee Salary : " + salary);
            }
        }
        static void Main(string[] args)
        {
            Employee[]emp = new Employee[3];
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Emplyoee Name : ");
                string en = Console.ReadLine();

                Console.WriteLine("Enter Emplyoee Id : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Emplyoee Salary : ");
                int sal = Convert.ToInt32(Console.ReadLine());

                emp[i].getdata(en, id, sal);
            }
                
            for(int i=0; i < 3; i++)
            {
                emp[i].displaydata();
            }
            Console.ReadKey();

        }
    }
}
