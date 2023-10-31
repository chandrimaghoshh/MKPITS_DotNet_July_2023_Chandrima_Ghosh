using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Bookk
{
    internal class Program
    {
        class Book
        {
            string title;
            string author;
            int year;

            public void getdata(string title, string author, int year)
            {
                this.title = title;
                this.author = author;
                this.year = year;
            }
            public void displaydata()
            {
                Console.WriteLine("Book Title : " + title);
                Console.WriteLine("Book Author : " + author);
                Console.WriteLine("Book Published Year : " + year);
            }
        }

        static void Main(string[] args)
        {
            Book[] bookied = new Book[3];
            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Book Title : ");
                string tit = Console.ReadLine();

                Console.WriteLine("Enter Book Author : ");
                string autho = Console.ReadLine();

                Console.WriteLine("Enter Book Published Year : ");
                int year =Convert.ToInt32(Console.ReadLine());
                bookied[i].getdata(tit, autho, year);
            }
            for(int i = 0; i < 3;i++)
            {
                bookied[i].displaydata();
            }
            Console.ReadKey();
        }
    }
    }

