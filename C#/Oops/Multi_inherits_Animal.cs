using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_inherits_Animal
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Babydog : Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Babydog b = new Babydog();
            b.eat();
            b.bark();
            b.weep();

            Console.ReadLine();
        }
    }
}
