using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_non_abstract_Account
{
    abstract class Account
    {
        public abstract void deposit();
        
        //non abstract method
        public void showbalance()
        {
            Console.WriteLine("Balance Method");
        }
    }
    class Saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.showbalance();
            act.deposit();

            Console.ReadLine();
        }
    }
}
