using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_public_Shape
{
    public interface Drawable
    {
        void draw();
    }
    public class Triangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
    public class Cicle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawable d;
            d = new Triangle();
            d.draw();
            d = new Cicle();
            d.draw();

            Console.ReadLine();
        }
    }
}
