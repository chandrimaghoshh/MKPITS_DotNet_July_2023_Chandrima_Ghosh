using System;

namespace switchVowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;

            Console.WriteLine("Enter Character : ");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("{0} is Vowel", op);
                    break;
                default:
                    Console.WriteLine("{0} is not Vowel", op);
                    break;
            }
            Console.ReadKey();
        }
    }
}
