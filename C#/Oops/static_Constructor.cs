using staticConstractor;
using System;
namespace staticConstractor
{
    public class employee
    {
        static employee() // Static constructor
        { 
            Console.WriteLine("The static constructor ");

        }
        public static void Salary()
        {
            Console.WriteLine();
            Console.WriteLine("The Salary method");
        }
    }
}
class details
{
    static void Main()
    {
        Console.WriteLine("----------Static constrctor example by chester------------------");
        Console.WriteLine();
        employee.Salary();
        Console.ReadLine();
    }
}
