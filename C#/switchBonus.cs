using System;

namespace switchBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designation;
            int bonus = 0;

            Console.WriteLine("Enter Designation (Manager, Clerk, Peon): ");
            designation = Console.ReadLine();

            switch(designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("Invalid designation");
                    break;
            }
            Console.WriteLine("{0} ", bonus);
            Console.ReadKey();
        }
    }
}
