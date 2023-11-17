using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Account
{
    class Account
    {
        public int act_no;
        public int bal = 1000;

        public virtual string deposit(int act_no, int bal)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return "balance amount : " + bal;
        }
    }
    class Cuurent : Account
    {
        public override string deposit(int act_no, int amt)
        {
            this.act_no = act_no;
            bal = bal + amt;
            return "amount deposited successfully in current class";
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Cuurent();
            string res = a.deposit(123, 500);
            Console.WriteLine("account no is " + a.act_no);
            Console.WriteLine(res);
            res = a.showbalance();
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
