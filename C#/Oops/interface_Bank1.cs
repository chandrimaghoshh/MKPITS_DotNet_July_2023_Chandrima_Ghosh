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
    }
    class account
    {
        public int actno;
        public int bal = 1000;
    }
    class saving : account, bank
    {

        public String deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully successfully ,bal is " + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b = new saving();
            String str = b.deposit(1, 200);
            Console.WriteLine(str);
        }
    }
}
