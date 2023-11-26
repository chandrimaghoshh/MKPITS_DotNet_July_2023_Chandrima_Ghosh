using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Vehical
{
    public class Vehical
    {
        public virtual void make()
        {
            Console.WriteLine("making car");
        }
        public virtual void model()
        {
            Console.WriteLine("Making model of car");
        }
    }
    public class Car : Vehical
    {
        public override void make()
        {
            Console.WriteLine("Num of doors");
        }
        public override void model()
        {
            Console.WriteLine("fuel types");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehical v = new Vehical();  
            v.make();
            v.model();

            Car c = new Car();
            c.make();
            c.model();

            Console.ReadKey();
        }
    }
}
