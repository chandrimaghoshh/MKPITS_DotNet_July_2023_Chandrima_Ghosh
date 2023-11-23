using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_Arraylist_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Chandrima");
            ar.Add("Akash");
            ar.Add("Pooja");
            ar.Add("Kareena");

            foreach(object obj in ar)
            {
                Console.WriteLine("Students Name : " + obj);
            }
            Console.ReadKey();
        }
    }
}
