using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Employee
{
    class Employee
    {
        protected int salary;
    }
    class programmer : Employee
    {
        public int bonus;

        public void getdata(int salary,  int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Bonus  : " + bonus);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p = new programmer();
            p.getdata(60000, 5000);
            p.displaydata();

            Console.ReadLine();
        }
    }
}
