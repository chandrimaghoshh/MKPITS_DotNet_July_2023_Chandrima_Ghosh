using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Simple_Person_Student_Protected
{
    public class Person
    {
        string name;
        string address;

        protected void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displayPersonData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    public class Student : Person
    {
        int roll_no;
        int marks;

        public void getStudentData(int roll_no, int marks)
        {
            getPersonData("Akash", "Nagpur");
            this.roll_no = roll_no;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            displayPersonData();
            Console.WriteLine("Roll No. : " + roll_no);
            Console.WriteLine("Marks : " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
           
            s.getStudentData(11, 70000);
            s.displayStudentData();

            Console.ReadKey();
            
        }
    }
}
