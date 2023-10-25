using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAtm
{
    class Program
    {
        static int calculate(int actno,int amt, int bal)
        {
            int res;
            int balance = 1000;
            int deposite = 0;
            int withdrawal = 0;

            res = bal + amt;
            Console.WriteLine("Deposited Amount = " + res);

            res = bal - amt;
            Console.WriteLine("Withdrawal Amount = " + res);

            return res;
        }
        static void Main(string[] args)
        {
            int actno = 0;
            Console.Write("Enter Account No. : ");
            int acctno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            
            int balance = 1000;
            int bal = calculate(actno, amt, balance);


            Console.ReadKey();
        }
    }
}
