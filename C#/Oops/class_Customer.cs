using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Customer
{
    internal class Program
    {
        class Customer
        {
            public int Customer_code;
            public string Customer_name;
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Customer_code = 123;
            cust.Customer_name = "Chandrima";

            Console.WriteLine("Customer Code : " + cust.Customer_code);
            Console.WriteLine("Customer Name : " + cust.Customer_name);

            Console.ReadKey();
        }
    }
}
