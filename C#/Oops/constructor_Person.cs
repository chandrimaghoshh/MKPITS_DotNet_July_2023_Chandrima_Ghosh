using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Person
{
    class Person
    {
        string name;
        int age;
        string address;

        public Person()
        {
            name = "Chandrima";
            age = 21;
            address = "Nagpur";
        }
        public void display()
        {
            Console.WriteLine("Person Name : " + name);
            Console.WriteLine("Person Age : " + age);
            Console.WriteLine("Person Address : " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.display();

            Console.ReadKey();
        }
    }
}
