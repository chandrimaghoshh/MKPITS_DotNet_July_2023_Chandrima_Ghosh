using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        public int AccountNumber { get; set;}
        public decimal Balance { get; set;}
        public int Amount {  get; set;}

        public Account(int accountnumber, decimal balance)
        {
            AccountNumber = accountnumber;
            Balance = balance;
        }
        public void Deposit(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine("Deposited Amount : " + Balance);
        }
        public void Withdrawal(decimal Amount)
        {
            Balance = Balance - Amount;
            if (Amount < Balance)
            {
                Console.WriteLine("Withdrawal Amount : " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance : " + Balance);
            }
        }
    }
    class Customer
    {
       public string CustomerName { get; set; }
        public List<Account> accounts = new List<Account>();
        public Customer(string customerName)
        {
            CustomerName = customerName;
        }
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
        public decimal GetTotalBalance()
        {
            decimal totalBalance = 0;
            foreach(Account account in accounts)
            {
                totalBalance = totalBalance + account.Balance;
            }
            return totalBalance;
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Customer Name : " + CustomerName);
            foreach(Account account in accounts)
            {
                Console.WriteLine("Account No. : " + account);
            }
            Console.WriteLine("Total balance : " + GetTotalBalance());
        }
    }
    class Bank
    {
        public List<Customer> customers = new List<Customer>();
        
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void DisplayCustomerAccountDetails(string customerName)
        {
            Customer customer = customers.Find(c => c.CustomerName == customerName);

            if(customer!=null)
            {
                Console.WriteLine("Customer ID : " + customerName);
                Console.WriteLine("Account Details:");
                foreach(Account account in customer.accounts)
                {
                    Console.WriteLine("Account No. : " + account.AccountNumber);
                    Console.WriteLine("Balance is : " + account.Balance);
                }
                Console.WriteLine("Total Balance : " + customer.GetTotalBalance());
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();

            Customer customer1 = new Customer("C1");
            Account account1 = new Account(1, 1000);
            Account account2 = new Account(2, 500);
            customer1.AddAccount(account1);
            customer1.AddAccount(account2);

            Customer customer2 = new Customer("C2");
            Account account3 = new Account(1, 1500);
            Account account4 = new Account(2, 1000);
            customer2.AddAccount(account3);
            customer2.AddAccount(account4);

            //Add customer on bank
            b.AddCustomer(customer1);
            b.AddCustomer(customer2);

            // Display account details for a customer
            b.DisplayCustomerAccountDetails("C1");
            b.DisplayCustomerAccountDetails("C2");

            // Perform transactions
            account1.Deposit(200);
            account2.Withdrawal(300);
            account3.Withdrawal(200);

            // Display updated account details
            b.DisplayCustomerAccountDetails("C1");
            b.DisplayCustomerAccountDetails("C2");
            Console.ReadLine();
        }
    }
}
