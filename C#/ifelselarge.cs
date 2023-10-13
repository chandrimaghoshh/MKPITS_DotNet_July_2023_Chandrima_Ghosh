using System;

namespace large
{
    internal class Larger
    {
        static void Main(string[] args)
        {
            int m,n;

            Console.WriteLine("Enter Num : ");
            m = Convert.ToInt32(Console.ReadLine());

            if(m > 0)
            {
                Console.WriteLine("The value of n is :1 ");
            }
            else if(m == 0)
            {
                Console.WriteLine("The value of n is :0");
            }
            else
            {
                Console.WriteLine("The value of n is :-1");
            }
            
            Console.ReadKey();
        }
    }
}
