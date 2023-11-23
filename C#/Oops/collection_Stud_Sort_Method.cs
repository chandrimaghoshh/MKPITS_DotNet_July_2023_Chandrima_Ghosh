using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_Stud_Sort_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(8);
            ar.Add(20);

            foreach(object obj in ar)
            {
                Console.WriteLine("Student Roll No. : " + obj);
            }

            //Sorting
            ar.Sort();
            Console.WriteLine("Array collection with sort method");

            foreach(int obj in ar)
            {
                Console.WriteLine("Student Roll No. : " + obj);
            }

            Console.ReadKey();
        }
    }
}
