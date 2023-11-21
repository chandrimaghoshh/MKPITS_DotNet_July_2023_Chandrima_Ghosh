using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface bank
    {
        String deposit(int actno, int amt);
        String withdraw(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;
        public String showbalance()
        {
            return "bal is : " + bal;
        }
    }
    class saving : account, bank
    {

        public String deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Deposited successfully successfully ,bal is :  " + bal;
        }
        public String withdraw(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "Withdrawal successfully ,bal is : " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            saving b;
            b = new saving();
            String str = b.deposit(1, 200);
            Console.WriteLine(str);

            str = b.withdraw(1, 100);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalance());

            Console.ReadLine();
        }
    }
}
