using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Single_Car_Methods
{
    class Car
    {
        public void start()
        {
            Console.WriteLine("Car is started");
        }
    }
    class Alto : Car
    {
        public void startmusic()
        {
            Console.WriteLine("Music is starting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alto a = new Alto();
            a.start();
            a.startmusic();

            Console.ReadKey();
        }
    }
}
