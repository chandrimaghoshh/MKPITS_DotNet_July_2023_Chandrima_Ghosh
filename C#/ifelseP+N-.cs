using System;

namespace posNeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if(num>0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            Console.ReadKey();
        }
    }
}
