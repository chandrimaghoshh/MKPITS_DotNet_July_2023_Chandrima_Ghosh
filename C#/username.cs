using System;

namespace username
{
    internal class Username
    {
        static void Main(string[] args)
        {
            string username; 
            int password;

            Console.WriteLine("Enter username : ");
            username = (Console.ReadLine());

            Console.WriteLine("Enter password : ");
            password = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unsuccessful attempts");


            Console.WriteLine("Enter username : ");
            username = (Console.ReadLine());

            Console.WriteLine("Enter password : ");
            password = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unsuccessful attempts");


            Console.WriteLine("Enter username : ");
            username = (Console.ReadLine());

            Console.WriteLine("Enter password : ");
            password = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unsuccessful attempts");


            Console.WriteLine("Rejected");

            Console.ReadKey();

        }
    }
}
