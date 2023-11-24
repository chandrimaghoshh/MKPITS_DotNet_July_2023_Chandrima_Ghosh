using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_Queue_Customer
{
    class Customer
    {
        public int customerId;
        public string customerName;
        public string customerEmail;
        public int customerMobileNo;

        public Customer(int customerId, string customerName, string customerEmail, int customerMobileNo)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.customerMobileNo = customerMobileNo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "Chandrima", "chandrima@1410", 90965);
            Customer c2 = new Customer(2, "Akash", "akash@26", 90950);
            Customer c3 = new Customer(3, "Pooja", "pooja@09", 80976);

            Queue c = new Queue();
            c.Enqueue(c1);
            c.Enqueue(c2);
            c.Enqueue(c3);

            foreach (Customer s in c)
            {
                Console.WriteLine("Customer Id : " + s.customerId);
                Console.WriteLine("Customer Name : " + s.customerName);
                Console.WriteLine("Customer Email : " + s.customerEmail);
                Console.WriteLine("Customer Moblie No. : " + s.customerMobileNo);
                Console.WriteLine("------------------------------------------------------------");
            }
            Customer r = (Customer)c.Dequeue();
            Console.WriteLine("Item dequeue : " + r.customerId + " : " + r.customerName + " : " + r.customerEmail + " : " + r.customerMobileNo);

            Console.WriteLine("After Dequeue : ");
            foreach (Customer s in c)
            {
                Console.WriteLine("Name : " + s.customerName);
            }
            Console.ReadKey();
        }
    }
}
