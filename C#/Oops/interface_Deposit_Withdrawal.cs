using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Deposit_Withdrawal
{
    interface Bank
    {
        string deposit(int actno, int amt);
        string withdrawal(int actno, int amt);
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
        public int interest = 400;
    }
    class Saving : Account, Bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt + interest;
            return "Account No.  : " + actno + " Balance after deposit amount with interest : " + bal;
        }
        public string withdrawal(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "Account No.  : " + actno + " Balance After withdrawal from Saving class : " + bal;
        }
    }
    class Current : Account, Bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Account No.  : " + actno + " Balance after deposit amount without interest : " + bal;
        }
        public string withdrawal(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "Account No.  : " + actno + "\n " + " Balance After withdrawal from Saving class : " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            Console.WriteLine("Enter Account No : ");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount : ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter saving or current");
            string acttype = Console.ReadLine();

            string res = null;
            switch(acttype)
            {
                case "saving":
                    b = new Saving();
                    break;
                case "current":
                    b = new Current();
                    break;
            }

            Console.WriteLine("Enter deposit or withdrawal");
            string choice = Console.ReadLine();

            if(choice=="deposit")
            {
                res=b.deposit(actno, amt);
            }
            else if(choice=="withdrawal")
            {
                res=b.withdrawal(actno, amt);
            }
            Console.WriteLine(res);

            Console.ReadKey();
            
        }
    }
}
