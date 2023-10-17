using System;

namespace whileCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1, num,res=1;

            Console.Write("Enter num : ");
            num = Convert.ToInt32(Console.ReadLine());

            while(counter <= num)
            {
                res = counter * counter * counter;
                

                Console.WriteLine(" {0} and cube of the {0} is:{2} ",counter,num, res);
                counter++;
            }
           

            Console.ReadKey();

        }
      
    }
}
