using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("11", "Chandrima");
            ht.Add("12", "Akash");
            ht.Add("14", "Pooja");
            ht.Add("16", "Kareena");
            ht.Add("15", "Sarang");
            ht.Add("17", "Lucky");
            ht.Add("18", "David");

            if (ht.ContainsValue("Chester"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("20", "Chester");
            }

            // Get a collection of the keys.
            ICollection Key = ht.Keys;

            foreach (string k in Key)
            {
                Console.WriteLine(k + " : " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}
