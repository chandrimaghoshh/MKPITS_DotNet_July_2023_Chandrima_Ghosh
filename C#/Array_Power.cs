using System;


namespace Array_Power
{
    class Program
    {
        static void calculate(int num, int power)
        {
            int result = 1;
            for(int cnt=1; cnt<=power; cnt++)
            {
                result= result*num;
            }
            Console.WriteLine("Result = " + result);
        }
        static void Main(string[] args)
        {
            int num, power;
            Console.WriteLine("Enter num : ");
            num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter power");
            power=Convert.ToInt32(Console.ReadLine());

            calculate(num, power);

            Console.ReadKey();
        }
    }
}
