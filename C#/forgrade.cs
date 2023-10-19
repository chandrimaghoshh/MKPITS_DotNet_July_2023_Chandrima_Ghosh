using System;
using System.Runtime.Remoting.Services;

namespace forGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            int counter;
            string grade;
            int total=0;
            float per=0;

            for(counter = 1; counter <=5; counter++)
            {
                Console.Write("Enter 5 subj marks : ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per <= 75)
            {
                grade = "First";
            }
            else if (per >= 50 && per <= 65)
            {
                grade = "Second";
            }
            else
            {
                grade = "Fail";
            }

            total = num + num + num + num + num;
            per = (total / 500.0f) * 100.0f;

            Console.WriteLine("Total marks = " +total);
            Console.WriteLine("Percentage = " + per + "%");
            Console.WriteLine("Grade = " + grade);
            Console.ReadKey();
        }
    }
}
