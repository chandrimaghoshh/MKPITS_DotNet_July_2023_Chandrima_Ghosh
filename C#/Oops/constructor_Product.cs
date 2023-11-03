using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_Product
{
    class Product
    {
        int productId;
        string productName;
        int price;
        int quantity;

        public Product() 
        {
            productId = 123;
            productName = "Pencil";
            price = 10;
            quantity = 50;
        }
        public void display()
        {
            Console.WriteLine("Product Id : " + productId);
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Product Price : " +  price);
            Console.WriteLine("Product Quantity : " +  quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            pro.display();

            Console.ReadKey();
        }
    }
}
