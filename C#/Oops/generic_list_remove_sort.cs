using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_list_remove_sort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> langs = new List<string>();

            langs.Add("Dotnet");
            langs.Add("Java");
            langs.Add("Php");
            langs.Add("Python");
            langs.Add("Oracle");

            Console.WriteLine(langs.Contains("Dotnet"));

            Console.WriteLine(langs[0]);
            Console.WriteLine(langs[1]);
            Console.WriteLine(langs[2]);
            Console.WriteLine(langs[3]);


            langs.Remove("Java");
            langs.Remove("Oracle");
            Console.WriteLine(langs.Contains("Dotnet"));

            langs.Insert(3, "C++");
            langs.Sort();

            foreach (string s in langs)
                Console.WriteLine(langs);

            Console.ReadKey();

        }
    }
}
