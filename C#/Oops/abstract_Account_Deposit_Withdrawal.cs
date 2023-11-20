using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Account_Deposit_Withdrawal
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract void deposit(int amt);
        public abstract void withdrawal(int amt);

        public void showbalance()
        {
            Console.WriteLine("Balance is : " + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Amount deposited from current account");
        }
        public override void withdrawal(int amt)
        {
            bal = bal - amt;
        }
    }
    class Saving : Account
    {
        public override void deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("Amount deposited from Saving account");
        }
        public override void withdrawal(int amt)
        {
            bal = bal - amt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No. : ");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount : ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account type (current or saving) : ");
            string acttype = Console.ReadLine();

            Console.WriteLine("Enter  choice (deposit or withdrawal) : ");
            string choice = Console.ReadLine();

            Account act = null;
            if(acttype == "current")
            {
                act = new Current(); 
            }
            else if(acttype == "saving")
            {
                act = new Saving();
            }

            if(choice=="deposit")
            {
                act.deposit(amt);
            }
            else if(choice == "withdrawal")
            {
                act.withdrawal(amt);
            }
            act.showbalance();

            Console.ReadLine();
        }
    }
}
