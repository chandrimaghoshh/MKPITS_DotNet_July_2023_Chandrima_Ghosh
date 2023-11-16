using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Single_Person_Emp_Method
{
    class Person
    {
        string name;
        string address;

        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;    
        }
        public void displayPersonData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    class Employee : Person
    {
        int emp_no;
        int salary;

        public void getEmpData(int emp_no, int salary)
        {
            this.emp_no = emp_no;
            this.salary = salary;
        }
        public void displayEmpData()
        {
            Console.WriteLine("Emp No. : " + emp_no);
            Console.WriteLine("Salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e =new Employee();
            e.getPersonData("Chandrima", "Nagpur");
            e.displayPersonData();

            e.getEmpData(123, 60000);
            e.displayEmpData();

            Console.ReadKey();
        }
    }
}
