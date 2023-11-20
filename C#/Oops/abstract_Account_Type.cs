using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Account_Type
{
    abstract class Account
    {
        public int accno;
        public int bal = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("Balance amount for account no {0} is {1} ", accno, bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
        }
    }
    class Saving : Account
    {
        public override void deposit(int amt)
        {
            int interest = 500;

            bal = bal + amt + interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entet Account No. : ");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount : ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Type (current or saving) : ");
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

            act.accno = accno;
            act.deposit(amt);
            act.showbalance();

            Console.ReadKey();
        }
    }
}
