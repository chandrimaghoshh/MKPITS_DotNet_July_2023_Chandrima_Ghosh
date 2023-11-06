using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Overloading_Book
{
    class Book
    {
        int id;
        string title;
        string author;
        int price;
        public void getdata()
        {
            id = 01;
            title = "Avengers";
            author = "James";
            price = 1500;
        }
        public void getdata(int id, string title, string author, int price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Id : " + id);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Author : " + author);
            Console.WriteLine("Book Price : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.display();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-------------Book1 Details-------------");
            Book b1= new Book();
            b1.getdata(01, "Orchids", "chester", 1000);
            b1.display();


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-------------Book2 Details-------------");
            Book b2 = new Book();
            Console.WriteLine("Enter Book Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Title : ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Book Author : ");
            string author= Console.ReadLine();

            Console.WriteLine("Enter Book Price : ");
            int price= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");

            b2.getdata(id, title, author, price);
            b2.display();

            Console.ReadKey();


        }
    }
}
