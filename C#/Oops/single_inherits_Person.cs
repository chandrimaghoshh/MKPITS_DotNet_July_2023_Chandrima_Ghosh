using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Person
{
    class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int roll_no;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Chandrima";
            s.roll_no = 12;

            Console.WriteLine("Name : " + s.name);
            Console.WriteLine("Roll No. : " + s.roll_no);

            Console.ReadLine();
        }
    }
}
