using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_Account_Return
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract string deposit(int actno, int amt);

        public string showbalance()
        {
            return "Balance is : " + bal;
        }
    }
    class Current : Account
    {
        public override string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Amount deposited successfully in current account without interest";
        }
    }
    class Saving : Account
    {
        public override string deposit(int actno, int amt)
        {
            int interest = 200;
            this.actno = actno;
            bal = bal + amt + interest;
            return "Amount deposited successfully in saving account with interest";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter amount to be deposited ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter account type (saving or currrent)");
            String acttype = Console.ReadLine();

            Account act = null;
            if(acttype == "saving")
            {
                act = new Saving();
            }
            else if(acttype == "current")
            {
                act = new Current();
            }

            Console.WriteLine("--------------Account Details--------------");
            Console.WriteLine("Act No. :" + actno);
            string res = act.deposit(actno, amt);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
