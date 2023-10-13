using System;

namespace leapyear
{
    internal class Leap
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            {
                Console.WriteLine("This is Leap year");
            }
            else
            {
                Console.WriteLine("This is not Leap year");
            }
            Console.ReadKey();
        }
    }
}
