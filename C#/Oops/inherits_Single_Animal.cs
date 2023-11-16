using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherits_Single_Animal
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
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();

            Console.ReadLine();

        }
    }
}
