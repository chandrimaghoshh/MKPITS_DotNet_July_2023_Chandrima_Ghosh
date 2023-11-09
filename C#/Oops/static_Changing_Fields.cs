using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Changing_Fields
{
    class Account
    {
        public int actno;
        public string name;
        public static float rateOfInterest = 8.8f;

        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(actno + " " + name + " " + rateOfInterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account.rateOfInterest = 10.5f; //changing value  

            Account a1 = new Account(1, "James");
            a1.display();

            Account a2 = new Account(2, "Obama");
            a2.display();

            Console.ReadKey();
        }
    }
}
