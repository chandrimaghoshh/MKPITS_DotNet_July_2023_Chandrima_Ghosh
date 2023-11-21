using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Bank
{
    interface Bank
    {
        string deposit(int actno, int amt);
    }
    class Saving : Bank
    {
        int actno;
        int bal = 1000;
        int interest = 500;
        public string deposit(int actno, int amt)
        {
            bal = bal + amt + interest;
            return "Account No. : " + actno + "\n" + "Balance is : " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            string res = b.deposit(1234, 500);
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
