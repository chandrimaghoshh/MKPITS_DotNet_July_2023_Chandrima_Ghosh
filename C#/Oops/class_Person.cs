using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Person
{
    internal class Program
    {
        class Person
        {
            string name;
            int age;
            string address;

            public void getdata(string name, int age, string address) 
            {
                this.name = name;
                this.age = age; 
                this.address = address;
            }
            public void display()
            {
                Console.WriteLine("Person Name : " + name);
                Console.WriteLine("Person Age : " + age);
                Console.WriteLine("Person Address : " + address);
            }
        }
        static void Main(string[] args)
        {
            Person per = new Person();

            Console.WriteLine("Enter Person Name : ");
            string p_name = Console.ReadLine();

            Console.WriteLine("Enter Person Age : ");
            int p_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Person Address : ");
            string p_add = Console.ReadLine();

            per.getdata(p_name, p_age, p_add);
            per.display();

            Console.WriteLine("----------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
