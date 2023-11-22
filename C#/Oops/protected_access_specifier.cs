using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_specifier
{
    class Person
    {
       protected string name;
    }
    class Student : Person
    {
        public void getData()
        {
            name = "Chandrima";
            Console.WriteLine("Name : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            
            s.getData();

            Console.ReadKey();
        }
    }
}
