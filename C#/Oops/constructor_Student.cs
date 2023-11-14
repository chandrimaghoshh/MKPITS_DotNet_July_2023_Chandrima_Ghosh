using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Student
{
    class Student
    {
        string name;
        int roll_no;
        int marks;
        int total;
        float avg;

        public Student()
        {
            name = "Chandrima";
            roll_no = 12;
            marks = 80;
        }
        public void display()
        {
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Age : " + roll_no);
            Console.WriteLine("Student Marks : " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            s.display();

            Console.ReadKey();
        }
    }
}
