using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageProgram
{
    internal class Age
    {
        static void Main(string[] args)
        {
           int age;

            Console.WriteLine("Enter Age :");
            age = Convert.ToInt32(Console.ReadLine());

            if(age>20)
            {
                Console.WriteLine("You look older than 20!");

                Console.ReadKey();
            }
         
        }
    }
}
