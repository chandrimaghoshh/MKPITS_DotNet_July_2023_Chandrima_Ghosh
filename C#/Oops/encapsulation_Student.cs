using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_Student
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 10;
            s.Name = "Chandrima";
            s.EmailId = "chandrima@gmail.com";

            Console.WriteLine("Student Id : " + s.Id);
            Console.WriteLine("Student Name : " + s.Name);
            Console.WriteLine("Student EmailId : " + s.EmailId);

            Console.ReadKey();
        }
    }
}
