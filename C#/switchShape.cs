using System;

namespace switchShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  r, l, b, choice;
            float area, h,circle;
            

            Console.WriteLine("1. Circle\n2. Rectangle\n3. Triangle");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Radius :");
                    r = Convert.ToInt32(Console.ReadLine());
                    r = r * r;

                    circle = 3.14f * r * r;
                    Console.WriteLine("Area of circle = " + circle);
                    break;

                case 2:
                    Console.WriteLine("Enter Length & Breadth : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    area = l * b;
                    Console.WriteLine("Area of Rectangle = " + area);
                    break;

                case 3:
                    Console.WriteLine("Enter Length, Breadth & Height");

                    l = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    h = Convert.ToSingle(Console.ReadLine());

                    area = l * b * h;
                    Console.WriteLine("Area of Triangle = "+area);
                    break;
                default:
                    Console.WriteLine("Invalid num");
                    break;
            }
            Console.ReadKey();
        }
    }
}
