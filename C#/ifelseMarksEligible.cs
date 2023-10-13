using System;
using System.Xml.Schema;

namespace marksEligible
{
    internal class Eligible
    {
        static void Main(string[] args)
        {
            int physics, chemistry, maths, total;

            Console.WriteLine("Enter marks in physics : ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in chemistry: ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in maths: ");
            maths = Convert.ToInt32(Console.ReadLine());

            total = physics + chemistry + maths;
            Console.WriteLine("Total marks = " + total);


            if (physics >= 55 && chemistry >=50 && maths >= 65 )
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadKey();
        }

    }
    
}
