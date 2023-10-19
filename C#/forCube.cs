using System;

namespace forCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter;
            int cube = 0;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            for(counter = 1; counter <= num; counter++)
            {
                cube = counter * counter * counter;
                Console.WriteLine("{0} and cube of the {1} is : {2}", counter, counter, cube);
            }
            
            Console.ReadKey();
        }
    }
}
