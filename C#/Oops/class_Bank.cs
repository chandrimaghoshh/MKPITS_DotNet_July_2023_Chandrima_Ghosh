using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Bank
{
    internal class Program
    {
        class Bank
        {
            string name;
            int act_no;
            int bal = 1000;
            int deposit, withdrawal, amt;

            public void getdata(string name, int act_no,int amt)
            {
                this.name = name;
                this.act_no = act_no;
                this.amt = amt;
                deposit = bal + amt;
                withdrawal = bal - amt;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer Name : " + name);
                Console.WriteLine("Customer Account No." + act_no);
                Console.WriteLine("Deposit Amount : " + deposit);
                Console.WriteLine("Withdrwal Amount : " + withdrawal);
            }
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();

            Console.WriteLine("Enter Customer Name : ");
            string cn = Console.ReadLine();

            Console.WriteLine("Enter Account No. : ");
            int actno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount : ");
            int amount=Convert.ToInt32(Console.ReadLine());

            b.getdata(cn, actno, amount);
            b.displaydata();
            
            Console.ReadKey();
        }
    }
}
