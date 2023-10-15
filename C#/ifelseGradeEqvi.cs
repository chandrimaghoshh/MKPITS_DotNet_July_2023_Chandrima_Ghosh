using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseGradeEqvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;

            Console.WriteLine("Enter Grade : ");
            grade = Console.ReadLine();

            if(grade == "E")
            {
                Console.WriteLine(" Grade is Excellent");
            }
            else if (grade == "V")
            {
                Console.WriteLine("Grade is Very good");
            }
            else if (grade == "G")
            {
                Console.WriteLine("Grade is Good");
            }
            else if (grade == "A")
            {
                Console.WriteLine("Grade is Average");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}
