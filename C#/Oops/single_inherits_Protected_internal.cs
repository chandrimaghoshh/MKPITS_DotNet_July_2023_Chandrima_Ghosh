using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Single_Protected_Internal
{
    public class Person
    {
        string name;
        string address;

        protected internal void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Address : " + address);
        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getdata("pooja", "nagpur");
            s.getStudentData(111, 999);
            s.displayStudentData();
            s.display();

            Console.ReadKey();

        }
    }
}
