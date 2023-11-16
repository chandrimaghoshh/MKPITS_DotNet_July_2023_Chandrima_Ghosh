using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inherits_Single_Person_Student_Method
{
    public class Person
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
            Console.WriteLine("Person Name : " + name);
            Console.WriteLine("Person Address : " + address);
        }
    }
    public class Student : Person
    {
        public int roll_no;
        public int marks;

        public void getStudentData(int roll_no, int marks)
        {
            this.roll_no = roll_no;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Student Roll No. : " + roll_no);
            Console.WriteLine("Student Marks : " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.getPersonData("Chester", "Nagpur");
            p.displayPersonData();

            p.getStudentData(11, 85);
            p.displayStudentData();

            Console.ReadKey();

        }
    }
}
