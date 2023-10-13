using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus
{
    internal class Bonus
    {
        static void Main(string[] args)
        {
            int empno, basicsalary; 
              float totalsalary;
            string empname, desig;
            float bonus = 0;

            Console.WriteLine("Enter EmpNo. : ");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EmpName : ");
            empname = Console.ReadLine();

            Console.WriteLine("Enter BasicSalary. : ");
            basicsalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter desig (Manager, Clerk, Peon): ");
            desig = Console.ReadLine();

            

            if(desig == "Manager")
            {
                bonus = basicsalary * 0.55f;
            }
            else if(desig == "Clerk")
            {
                bonus = basicsalary * 0.25f; 
            }
            else if(desig == "Peon")
            {
                bonus = basicsalary * 0.10f;
            }
            else
            {
                Console.WriteLine("Invalid designation");
            }

            totalsalary = basicsalary + bonus;

            Console.WriteLine("EmpNo = {0},EmpName = {1}, BasicSalary = {2}, Desig = {3}", empno, empname, basicsalary, desig);
            Console.WriteLine("TotalSalary = {0}, bonus = {1}", totalsalary, bonus);

            Console.ReadKey();

        }
    }
}
