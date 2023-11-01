using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    internal class Program
    {
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public int Balance { get; set; }

            public void display()
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Account Details Of Customer");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Account No. : " + AccountNumber);
                Console.WriteLine("Account Holder Name : " + AccountHolderName);
                Console.WriteLine("Balance : " + Balance);
            }
            public void transfer(BankAccount ba)
            {
                Balance = Balance + ba.Balance;
                ba.Balance = 0; ;
            }
            public void showbalance()
            {
                Console.WriteLine("Current balance for account no {0} is {1} ", AccountNumber, Balance);
            }
        }
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolderName = "Chandrima";
            b1.Balance = 500;
            b1.display();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "Akash";
            b2.Balance = 100;
            b2.display();

            b1.transfer(b2);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Balance After Transaction ");
            Console.WriteLine("----------------------------------");

            b1.showbalance();
            b2.showbalance();

            Console.ReadKey();
        }
    }
}
