using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inherits_Account
{
    class Account
    {
        public int act_no;
        public int bal = 1000;
        public void deposit(int amt)
        {
            Console.WriteLine("This is deposit method of account class : ");
        }
    }
    class Saving : Account
    {
        public void deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("Amount deposited with interest balance is : " + bal);
        }
    }
    class Current : Account
    {
        public void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Amount deposited without interest balance is : " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.act_no = 1346;
            s.deposit(1000);

            Current c = new Current();
            c.act_no = 1234;
            c.deposit(1000);

            Console.ReadKey();
        }
    }
}
