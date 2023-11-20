using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method_Account
{
    abstract class Account
    {
        public abstract void deposit();
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
            act.deposit();

            Console.ReadLine();
        }
    }
}
