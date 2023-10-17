using System;

namespace switchGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string grade;

            Console.WriteLine("Enter Grade : ");
            grade = Console.ReadLine();

            switch(grade)
            {
                case "E":
                    Console.WriteLine("Grade is Excellent");
                    break;
                case "V":
                    Console.WriteLine("Grade is Very Good");
                    break;
                case "G":
                    Console.WriteLine("Grade is Good");
                    break;
                case "A":
                    Console.WriteLine("Grade is Average");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;

            }
            Console.ReadKey();

        }
    }
}
