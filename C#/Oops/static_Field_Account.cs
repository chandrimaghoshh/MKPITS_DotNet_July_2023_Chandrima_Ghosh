using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Field_Account
{
    class Account
    {
        public int actno;
        public string name;
        public static float RateOfInterest = 8.8f;

        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(actno + " " + name + " " + RateOfInterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123,"Chandrima");
            a1.display();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("-------------------------------------");

            Account a2 = new Account(145, "Chester");
            a2.display();

            Console.ReadKey();
        }
    }
}
