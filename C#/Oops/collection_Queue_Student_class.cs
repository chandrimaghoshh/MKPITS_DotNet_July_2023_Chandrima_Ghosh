using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_Quaue_Student_class
{
    class Student
    {
        public int rno;
        public string name;
        public Student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10, "Chandrima");
            Student s2 = new Student(11, "Pooja");
            Student s3 = new Student(12, "Akash");

            Queue s = new Queue();
            s.Enqueue(s1);
            s.Enqueue(s2);
            s.Enqueue(s3);
            foreach (Student val in s)
            {
                Console.WriteLine("Roll No. : " + val.rno);
                Console.WriteLine("Name : " + val.name);
            }
            Student r = (Student)s.Dequeue();
            Console.WriteLine("item deque : " + r.rno + " : " + r.name);
            Console.WriteLine("after deque : ");
            foreach (Student val in s)
            {
                Console.WriteLine("Name " + val.name);
            }

            Console.ReadLine();
        }
    }
}
