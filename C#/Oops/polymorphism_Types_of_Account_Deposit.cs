using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Types_of_Account
{
    class Account
    {
        public int actno;
        public int bal = 1000;

        public virtual void deposit(int actno, int amt)
        {
            Console.WriteLine("Amount deposit method ");
        }
        public void showbalance()
        {
            Console.WriteLine("Balance Amount = " + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            Console.WriteLine("Amount deposit successfully without interest = " + bal);
        }
    }
    class Saving : Account
    {
        public override void deposit(int actno, int amt)
        {
            this.actno = actno;
            int interest = 1000;
            bal = bal + amt + interest;
            Console.WriteLine("Amount deposit successfully with interest = " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account type (current & saving) : )");
            string acttype = Console.ReadLine();

            Account act = null;
            if (acttype == "current")
            {
                act = new Current();
            }
            else if(acttype == "saving")
            {
                act = new Saving();
            }

            Console.WriteLine("------------Account Details------------");
            Console.WriteLine("Account No. : " + actno);
            act.deposit(actno, amount);
            act.showbalance();

            Console.ReadKey();
        }
    }
}
