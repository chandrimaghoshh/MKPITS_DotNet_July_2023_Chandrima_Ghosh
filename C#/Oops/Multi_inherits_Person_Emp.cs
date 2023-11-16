using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Multi_inherits_person_Emp
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
    class Student : Person
    {
        int roll_no;
        int marks;

        public void getStudentData(int  roll_no, int marks)
        {
            this.roll_no = roll_no;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll No. : " + roll_no);
            Console.WriteLine("Marks : " + marks);
        }
    }
    class Parttime : Student
    {
        int empno;
        int salary;

        public void getParttimeData(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayParttimeData()
        {
            Console.WriteLine("Empno : " + empno);
            Console.WriteLine("Salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.getPersonData("Chandrima", "Nagpur");
            p.displayPersonData();

            p.getStudentData(11, 95);
            p.displayStudentData();

            p.getParttimeData(123, 60000);
            p.displayParttimeData();

            Console.ReadKey();
        }
    }
}
