using System;


namespace functionnSwap2Num
{
    class Program
    {
        static int swap(int num1, int num2)
        {
            
            int temp;

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Result After swapping :num1 is {0}, num2 is {1} " , num1,num2);

            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = swap(num1, num2);
            

            Console.ReadKey();
        }
    }
}
