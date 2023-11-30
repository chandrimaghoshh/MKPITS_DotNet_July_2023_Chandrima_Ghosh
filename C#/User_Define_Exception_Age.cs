using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Define_Exception_Age
{
    public class AgeException : ApplicationException
    {
        public AgeException(string message):base(message)
        {

        }
    }
    class Age
    {
        public int age=22;
        public void showage()
        {
            if(age <= 18)
            {
                throw new AgeException("Not Eligible for vote");
            }
            else
            {
                Console.WriteLine("Eligible for vote : {0}", age);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.showage();
            }
            catch (AgeException ae)
            {
                Console.WriteLine("Age exception : " +ae.ToString());
            }
            Console.ReadKey();
        }
    }
}
