using System;

namespace profitLoss
{
    internal class ProfitLoss
    {
        static void Main(string[] args)
        {
            int cost_price, selling_price, amount;

            Console.WriteLine("Enter Cost Price : ");
            cost_price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Selling Price : ");
            selling_price = Convert.ToInt32(Console.ReadLine());

            if(selling_price > cost_price)
            {
                amount = selling_price - cost_price;
                Console.Write("You can booked your profit amount : {0} ", amount);
            }
            else if(cost_price > selling_price)
            {
                amount = cost_price - selling_price;
                Console.Write("your Loss amount : {0}", amount);
            }
            else
            {
                Console.WriteLine("you booked no loss no profit");

            }
            Console.ReadKey();
        }
    }
}
