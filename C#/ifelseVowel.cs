using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            string alphabet;

            Console.Write("Enter Alphabet :");
            alphabet = Console.ReadLine();

            if(alphabet == "a" || alphabet == "e" || alphabet == "i" || alphabet == "o" || alphabet == "u")
            {
                Console.WriteLine("The alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }
            Console.ReadKey();

        }
    }
}
