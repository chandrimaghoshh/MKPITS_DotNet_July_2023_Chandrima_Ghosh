using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Overloading_Student
{
    class Student
    {
        int roll_no;
        string name;
        string course;
        int fees;

        public void getdata()
        {
            roll_no = 1;
            name = "Chandrima";
            course = "DotNet";
            fees = 75000;
        }
        public void getdata(int roll_no, string name, string course, int fees)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("Student Roll No. : " + roll_no);
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Roll No. : " + course);
            Console.WriteLine("Student Roll No. : " + fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------Student1 Details----------");
            Student s = new Student();
            s.getdata();
            s.display();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------Student2 Details----------");
            Student s1 = new Student();
            s1.getdata(2, "Akash", "DotNet", 65000);
            s1.display();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------Student3 Details----------");
            Student s2 = new Student();
            s2.getdata(3, "Pooja", "Java", 75000);
            s2.display();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("------------Student4 Details----------");
            Student s3 = new Student();
            s3.getdata(4, "Kareena", "Java", 65000);
            s3.display();

            Console.ReadKey();
        }
    }
}
