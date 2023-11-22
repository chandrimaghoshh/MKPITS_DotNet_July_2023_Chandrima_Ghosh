using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void run()
        {
            Console.WriteLine("Running...");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog is eating...");
        }
        public sealed override void run()
        {
            Console.WriteLine("Runnng fast...");
        }
    }
    class BabyDog : Dog
    {
        public override void eat()
        {
            Console.WriteLine("Eating biscuit...");
        }
        public override void run()
        {
            Console.WriteLine("Running very slowly...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDog dog = new BabyDog();
            dog.eat();
            dog.run();

            Console.ReadKey();
        }
    }
}
