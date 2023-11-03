using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cons_Para_Product_User
{
    class Product
    {
        int productId;
        string productName;
        int productPrice;
        int productQuantity;
        public Product(int productId, string productName, int productPrice, int productQuantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
        public void display()
        {
            Console.WriteLine("Product ID : " + productId);
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Product Price : " + productPrice);
            Console.WriteLine("Product Quantity : " + productQuantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product(1,"chairs",500,10);

            pro.display();

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Enter Product ID : ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name : ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter Product Price : ");
            int productPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Product ID : ");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------------------");

            Product pro1 = new Product(productId, productName, productPrice, productQuantity);

            pro1.display();

            Console.ReadKey();
        }
    }
}
