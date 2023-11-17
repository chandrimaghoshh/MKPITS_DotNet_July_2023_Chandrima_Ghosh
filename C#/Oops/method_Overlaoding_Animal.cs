using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Overloading_Animal
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Chestu is eating");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Chestu is eating biscuits");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();

            Console.ReadKey();
        }
    }
}
