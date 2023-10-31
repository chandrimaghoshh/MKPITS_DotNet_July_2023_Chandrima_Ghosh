using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Student
{
    internal class Program
    {
        class Student
        {
            string name;
            int roll_no;
            int[] marks = new int[3];
            public void getdata(string name, int roll_no, int[] marks)
            {
                this.name = name;
                this.roll_no = roll_no;
                this.marks = marks;
                
            }
            public void displaydata()
            {
                int total = 0;
                float avg = 0;
                for (int cnt = 0; cnt < 3; cnt++)
                {

                    total = total + marks[cnt];
                }
                avg = total / 3.0f;
                Console.WriteLine("Student Name : " + name);
                Console.WriteLine("Student Roll No. : " + roll_no);
                Console.WriteLine("Total = " + total);
                Console.WriteLine("Average = " + avg);
            }
        }
        static void Main(string[] args)
        {
            int[]marks= new int[3];
            Student stud = new Student();

            Console.WriteLine("Enter Student Name : ");
            string s_name =Console.ReadLine();

            Console.WriteLine("Enter Student rollno : ");
            int s_roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks : ");
            for (int cnt = 0; cnt < 3; cnt++)
            {
                marks[cnt] = Convert.ToInt32(Console.ReadLine());

            }
            stud.getdata(s_name, s_roll, marks);
            stud.displaydata();

            Console.ReadKey();
        }
    }
}
