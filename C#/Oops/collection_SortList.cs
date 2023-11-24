using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_Sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl=new SortedList();
            sl.Add("001","Doremon");
            sl.Add("005", "Nobita");
            sl.Add("003", "Shinchan");
            sl.Add("002", "Suzuka");
            sl.Add("004", "Noddy");

            if(sl.ContainsValue("Bhem"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("006", "Bhem");
            }

            ICollection key = sl.Keys;
            foreach(string str in  key)
            {
                Console.WriteLine(str + " : " + sl[str]);
            }
            Console.ReadKey();
        }
    }
}
