using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Counting_Object
{
   class Account
    {
        public int  actno;
        public string name;
        public static int count = 0;

        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(actno + " " +  name + " ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1, "Chandrima");
            a1.display();

            Account a2 = new Account(2, "Pooja");
            a2.display();

            Account a3 = new Account(3, "Kareena");
            a3.display();

            Console.WriteLine("The Objects count = " + Account.count);

            Console.ReadKey();

        }
    }
}
