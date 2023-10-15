using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int id;
            float unit, surcharge = 0, charge, bill, total;

            Console.WriteLine("Enter Customer Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Customer ID : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Unit Consume : ");
            unit = Convert.ToSingle(Console.ReadLine());

            if (unit <= 200)
            {
                charge = 1.20f;
            }
            else if (unit >= 200 && unit <= 400)
            {
                charge = 1.50f;
            }
            else if (unit >= 400 && unit <= 600)
            {
                charge = 1.80f;
            }
            else
            {
                charge = 2.00f;
            }
            total = unit * charge;
            Console.WriteLine("Amount Charges @Rs 2.00 per unit : " + total);

            if (total > 400)
            {
                surcharge = total * 0.15f;

                Console.WriteLine("Surcharge Amount : " + surcharge);

            }
            bill = total + surcharge;
            Console.WriteLine("Net Amount Paid By the Customer :  " + bill);

            Console.ReadKey();
        }
    }
}