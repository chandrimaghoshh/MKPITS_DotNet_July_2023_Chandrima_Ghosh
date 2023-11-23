using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_Remove_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);
            ar.Add(4);
            ar.Add(5);

            foreach (object obj in ar)
            {
                Console.WriteLine("Array List without removing : " + obj);
            }

            ar.Remove(3);
            Console.WriteLine("---------------------------------------");
            foreach(object obj in ar)
            {
                Console.WriteLine("Array List after removing : " + obj);
            }
            ar.RemoveAt(1);
            Console.WriteLine("---------------------------------------");
            foreach (object obj in ar)
            {
                Console.WriteLine("Array List after removing at : " + obj);
            }
            Console.ReadKey();
        }
    }
}
