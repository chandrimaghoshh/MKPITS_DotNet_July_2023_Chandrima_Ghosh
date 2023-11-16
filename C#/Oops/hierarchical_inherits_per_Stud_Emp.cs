using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inherits_Per_Stud_Emp
{
    class Person
    {
        public string name;
        public string address;
    }
    class Student : Person
    {
       public int roll_no;
       public int marks;
    }
    class Employee : Person
    {
       public int salary;
       public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.name = "Chandrima";
            s.address = "Nagpur";
            s.roll_no = 11;
            s.marks = 95;

            Console.WriteLine("--------------- Student details ----------");
            Console.WriteLine("Name  : " + s.name);
            Console.WriteLine("Addres  : " + s.address);
            Console.WriteLine("Roll No. : " + s.roll_no);
            Console.WriteLine("Marks : " + s.marks);

            Employee emp = new Employee();
            emp.name = "Chester";
            emp.address = "Mumbai";
            emp.salary = 55544;
            emp.designation = "Manager";

            Console.WriteLine("--------------- Employee details ----------");
            Console.WriteLine("Name : " + emp.name);
            Console.WriteLine("Addres : " + emp.address);
            Console.WriteLine("Salary : " + emp.salary);
            Console.WriteLine("Designation : " + emp.designation);

            Console.ReadKey ();
        }
    }
}
