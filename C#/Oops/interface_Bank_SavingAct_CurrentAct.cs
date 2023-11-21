using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Bank_SavingAct_CurrentAct
{
    interface Bank
    { 
     string deposit(int actno, int amt);
    }
    class Account
    {
        int actno;
        int bal = 1000;
        int interest = 700;
    }
    class Saving : Account, Bank
    {
        public string deposit(int actno, int amt)
        {
            int bal = 1000;
            int interest = 700;
            bal = bal + amt + interest;
            return "Account No : " + actno + "\n" + "Balance after deposit with interest : " + bal;
        }
    }
    class Current : Account
    {
        public string deposit(int actno, int amt)
        {
            int bal = 1000;
            bal = bal + amt;
            return "Account No : " + actno + "\n" + "Balance after deposit without interest : " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving s;
            s = new Saving();
            string res = s.deposit(1, 200);
            Console.WriteLine(res);

            Current c;
            c = new Current();
            string res1 = c.deposit(2, 200);
            Console.WriteLine(res1);

            Console.ReadLine();
        }
    }
}
