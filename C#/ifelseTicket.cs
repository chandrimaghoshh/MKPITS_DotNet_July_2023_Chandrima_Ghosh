using System;

namespace ticket
{
    internal class Ticket
    {
        static void Main(string[] args)
        {
            int trainno;
            int date;
            int km;
            string origin;
            string destination;
            string pname;
            string clss;

            Console.WriteLine("Enter Passenger Name : ");
            pname = Console.ReadLine();

            Console.WriteLine("Enter Date :");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train No. : ");
            trainno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Class : ");
            clss = Console.ReadLine();

            Console.WriteLine("Enter Origin : ");
            origin = Console.ReadLine();

            Console.WriteLine("Enter Destination : ");
            destination = Console.ReadLine();

           
            Console.WriteLine("Enter km :");
            km = Convert.ToInt32(Console.ReadLine());

      

            if (km >100)
            {
                Console.WriteLine("Fare is 100rs" );
            }
            else if(km <= 100 && km>=500)
            {
                Console.WriteLine("Fare is 500rs" );
            }
            else
            {
                Console.WriteLine("Fare is 800rs" );
            }

            Console.WriteLine(km);
            Console.WriteLine("Origin = {0}, Destination = {1}, Passenger Name = {2}, Train No. = {3}, Class = {4}, Date = {5}", origin, destination, pname, trainno, clss, date);
           
            Console.ReadKey();
        }
       
    }
}
