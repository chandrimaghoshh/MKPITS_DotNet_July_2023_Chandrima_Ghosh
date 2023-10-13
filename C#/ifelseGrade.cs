using System;

namespace grade
{
    internal class Grade
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;

            Console.WriteLine("Enter sub1 : ");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter sub2 : ");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter sub3 : ");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            Console.WriteLine("Total Marks = "+ total);

            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Percentage : " + per + "%");

            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 65 && per < 75)
            {
                grade = "First class";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine("Grade : " + grade);
            Console.ReadKey();

        }
    }
}
