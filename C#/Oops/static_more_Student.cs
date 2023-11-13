using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_more_Student
{
    class Student
    {
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public void sayHii()
        {
            Console.WriteLine("Say Hii");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.display();

            Student s = new Student();
            s.sayHii();

            Console.ReadKey();
        }
    }
}
