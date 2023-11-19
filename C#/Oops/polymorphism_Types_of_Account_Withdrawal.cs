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
        public virtual void withdrawal(int actno, int amt)
        {
            Console.WriteLine("Amount withdrawal method");
        }
        public void dshowbalance()
        {
            Console.WriteLine("Deposit Balance Amount = " + bal);
        }
        public void wshowbalance()
        {
            Console.WriteLine("Withdrawal Balance Amount = " + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int actno, int amt)
        {
            bal = 1000;
            this.actno = actno;
            bal = bal + amt;
            Console.WriteLine("Amount deposit successfully without interest = " + bal);
        }
        public override void withdrawal(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            if (amt > bal)
            {
                Console.WriteLine("Insufficient balance for withdrawal from current account");
            }
            else
            {
                Console.WriteLine("Amount withdrawal successfully without interest");
            }
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
        public override void withdrawal(int actno, int amt)
        {
            bal = 1000;
            this.actno = actno;
            bal = bal - amt;
            if (amt > bal)
            {
                Console.WriteLine("Insufficient balance for withdrawal from current account");
            }
            else
            {
                Console.WriteLine("Amount withdrawal successfully without interest");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter amount to be deposited ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account type (current & saving) : )");
            string acttype = Console.ReadLine();

            Account act = null;
            if (acttype == "current")
            {
                act = new Current();
            }
            else if (acttype == "saving")
            {
                act = new Saving();
            }

            Console.WriteLine("You want to deposit or withdrawal amount");
            string choice = Console.ReadLine();
            if (choice == "deposit")
            {
                act.deposit(actno,amt);
                act.dshowbalance();
            }
            else if(choice == "withdrawal")
            {
                act.withdrawal(actno, amt);
                act.wshowbalance();
            }
            Console.ReadLine();
        }
    }
}
