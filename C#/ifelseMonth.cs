using System;

namespace ifelseMonth
{
    internal class Month
    {
        static void Main(string[] args)
        {
            int month;

            Console.WriteLine("Enter Month No.: ");
            month = Convert.ToInt32(Console.ReadLine());

            if(month == 1 ||  month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("The month have 31 days");
            }
            else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("The month have 30 days");
            }
            else if(month == 2)
            {
                Console.WriteLine("The month have 28 days");
            }
            Console.ReadKey();
        }
    }
}
