using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Single_Person_Student
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Chandrima";
            s.address = "Nagpur";
            s.roll_no = 10;
            s.marks = 90;

            Console.WriteLine("Name : " + s.name);
            Console.WriteLine("Address : " + s.address);
            Console.WriteLine("Roll No. : " + s.roll_no);
            Console.WriteLine("Marks : " + s.marks);

            Console.ReadKey();
        }
    }
}
