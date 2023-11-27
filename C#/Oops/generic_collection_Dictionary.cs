using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("in", "India");
            dic.Add("us", "United States");
            dic.Add("ge", "Germany");
            dic.Add("po", "Poland");
            dic.Add("ne", "Newzeland");

            Console.WriteLine(dic["us"]);
            Console.WriteLine(dic["ne"]);

            Console.WriteLine("Dictionary has {0} items",dic.Count);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Keys of the dictionary:");

            List<string> Keys = new List<string>(dic.Keys);

            foreach (string keys in Keys)
            {
                Console.WriteLine("{0}",keys);
            }
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Values of the dictionary : ");
            List<string> Values = new List<string>(dic.Values);
            foreach(string val in Values)
            {
                Console.WriteLine("{0}", val);
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Keys & values of the dictionary : ");
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                Console.WriteLine("Key={0},Value={1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();

        }
    }
}
