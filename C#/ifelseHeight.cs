using System;

namespace height
{
    internal class Height
    {
        static void Main(string[] args)
        {
            int cm;

            Console.WriteLine("Enter Cm : ");
            cm = Convert.ToInt32(Console.ReadLine());

            if(cm <= 150)
            {
                Console.WriteLine("Height is Dwarf");
            }
            else if(cm <= 165 && cm >=150)
            {
                Console.WriteLine("Height is Average");
            }
            else if(cm >= 165 && cm <= 195)
            {
                Console.WriteLine("Height is Tall");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }
            Console.ReadKey();
        }
    }
}
