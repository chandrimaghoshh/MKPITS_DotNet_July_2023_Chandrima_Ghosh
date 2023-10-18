using System;

namespace doWhileCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cube, counter=1; 

            Console.WriteLine("Enter num :");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
               // Console.WriteLine("", +num);

                cube = counter * counter * counter;
                
                Console.WriteLine("{0} and cube of the {1} is :{2}", counter, counter, cube);
                counter++;
            }
            while(counter<=num);
           
            //Console.WriteLine("{1} and cube of the {1} is :{0}", cube,num,counter);

            Console.ReadKey();
        }
    }
}
