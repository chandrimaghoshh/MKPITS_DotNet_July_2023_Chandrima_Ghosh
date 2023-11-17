using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_Inherits_Vehical
{
    public class Vehicle
    {
        public void vehicle()
        {
            Console.WriteLine("Details of Vehicle : ");
        }
    }
    public class Car : Vehicle 
    {
        public void car()
        {
            Console.WriteLine("Car is stating");
            Console.WriteLine("Car is stop");
        }
    }
    public class Truck : Vehicle
    {
        public void truck()
        {
            Console.WriteLine("Truck is stating");
            Console.WriteLine("Truck is stop");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c= new Car();
            c.car();

           Truck t = new Truck();
            t.truck();

            Console.ReadKey();
        }
    }
}
