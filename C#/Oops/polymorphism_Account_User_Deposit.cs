using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Account_User
{
    class Account
    {
        public int actno;
        public int bal = 1000;
        public int amt;

        public virtual void deposit(int actno, int amt)
        {
            Console.WriteLine("Deposit method of account class");
        }
        public void showbalance()
        {
            Console.WriteLine("Bal Amount : " + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            Console.WriteLine("Amount deposited successfully without interest in current class");
        }
    }
    class Saving : Account
    {
        public override void deposit(int actno, int amt)
        {
            this.actno = actno;
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("Amount deposited successfully interest in saving class : ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No. : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited : ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Account a = new Current();
            a.deposit(actno, amt);
            Console.WriteLine("Account No. : " + actno);
            a.showbalance();

            Console.WriteLine("Enter Account No. : ");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited : ");
            int amt1 = Convert.ToInt32(Console.ReadLine());

            Account a1 = new Saving();
            a1.deposit(actno1, amt1);
            Console.WriteLine("Account No. : " + actno1);
            a1.showbalance();

            Console.ReadLine();
        }
    }
}
