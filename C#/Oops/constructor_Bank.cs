using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Bank
{
    class Bank
    {
        int act_no;
        string name;
        int deposit;
        int withdrawal;
        int bal, amt;

        public Bank()
        {
            act_no = 123;
            name = "Chandrima";
            bal = 1000;
            amt = 500;

            deposit = bal + amt;
            withdrawal = bal - amt;
        }
        public void display()
        {
            Console.WriteLine("Deposit Amount = " + deposit);
            Console.WriteLine("Withdrawal Amount = " + withdrawal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();

            b.display();

            Console.ReadKey();
        }
    }
}
