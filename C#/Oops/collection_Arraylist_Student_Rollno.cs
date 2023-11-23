using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_arraylist_Student_Rollno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(10);
            ar.Add(12);
            ar.Add(13);

            foreach(object obj in ar)
            {
                Console.WriteLine("Student Roll No. : " + obj + "\n");
            }
            Console.WriteLine("Capacity : {0}", ar.Capacity);
            Console.WriteLine("Count : {0}", ar.Count);

            Console.ReadKey();
        }
    }
}
