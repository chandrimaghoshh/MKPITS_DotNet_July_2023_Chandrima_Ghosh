using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Customer_getdata
{
    class Program
    {
        class Customer
        {
            int Customer_code;
            string Customer_name;
            public void getdata(int cc, string cn)
            {
                Customer_code = cc;
                Customer_name = cn;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer Code : " + Customer_code);
                Console.WriteLine("Customer Name : " + Customer_name);
            }
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata(123, "Chandrima");
            cust.displaydata();

            Console.ReadKey();
        }
    }
}
