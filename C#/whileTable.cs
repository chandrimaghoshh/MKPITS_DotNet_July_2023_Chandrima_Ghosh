using System;


namespace whileTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter=1, res=0;

            Console.WriteLine("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            while(counter <= 10)
            {
                res = num * counter;
  
                Console.WriteLine("{0} x {1} = {2}", counter, num, res);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
