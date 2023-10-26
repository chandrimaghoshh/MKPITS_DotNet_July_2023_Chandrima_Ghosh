using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array_Marksheets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            float per = 0;
            string grade = null;
            int[] num = new int[5];

            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine("Enter 5 subject Marks : ");
                num[cnt] = Convert.ToInt32(Console.ReadLine());
          
                total = total + num[cnt];
                per = total / 500.0f * 100.0f;

                if (per >= 75)
                {
                    grade = "Distinction";
                }
                else if (per >= 60 && per <= 75)
                {
                    grade = "First";
                }
                else if (per >= 40 && per <= 50)
                {
                    grade = "Second";
                }
                else
                {
                    grade = "Fail";
                }

            }
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + per + "%");
            Console.WriteLine("Grade = " + grade);
            Console.ReadKey();
        }
    }
}
