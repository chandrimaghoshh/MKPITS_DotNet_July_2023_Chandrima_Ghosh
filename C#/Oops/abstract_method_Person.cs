using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_Person
{
    abstract class Person
    {
        public abstract void display();

        public void showdata()
        {
            Console.WriteLine("Hello from showdata");
        }
    }
    class Student : Person
    {
        public override void display()
        {
            Console.WriteLine("Hello from display method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.display();
            p.showdata();

            Console.ReadLine();
        }
    }
}
