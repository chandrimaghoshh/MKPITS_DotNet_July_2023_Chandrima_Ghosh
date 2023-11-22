using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    abstract class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int rno;
    }
    sealed class Parttime : Student
    {
        public int hours;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parttime pt = new Parttime();
            pt.rno = 21;
            pt.name = "Chandrima";
            pt.hours = 5;
            Console.WriteLine("Roll No. : " + pt.rno);
            Console.WriteLine("Name : " + pt.name);
            Console.WriteLine("Working Hours : " + pt.hours);

            Console.ReadKey();

        }
    }
}
