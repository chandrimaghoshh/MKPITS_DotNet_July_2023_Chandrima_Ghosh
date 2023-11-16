using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Single_Person_Employee
{
    class Person
    {
        public string name;
        public string address;
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
            Employee e = new Employee();
            e.name = "Devil";
            e.address = "USA";
            e.salary = 100000;
            e.designation = "Manager";

            Console.WriteLine("Name : " + e.name);
            Console.WriteLine("Address : " + e.address);
            Console.WriteLine("Salary : " + e.salary);
            Console.WriteLine("Designation : " + e.designation);

            Console.ReadKey();
        }
    }
}
