using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_Student_Insert_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Chandrima");
            ar.Add("Pooja");
            ar.Add("Akash");
            ar.Add("Kareena");

            foreach(object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }

            ar.Insert(2, "Minu");
            foreach (object obj in ar)
            {
                Console.WriteLine("Student Name : " + obj);
            }
            Console.ReadKey();
        }
    }
}
