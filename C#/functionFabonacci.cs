using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionFabonacci
{
    class Program
    {
        static int fabo(int num)
        {
         
            int cnt = 3;
            int num1 = 0;
            int num2 = 1;
            int add = num1 + num2;
            Console.Write("{0},{1},",num1,num2);
            while (cnt <= num)
            {
                
                num1 = num2;
                num2 = add;
                Console.Write("{0},",add);
                add = num1 + num2;

                cnt++;
            }
            return add;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter num : ");
             number =Convert.ToInt32(Console.ReadLine());
            

            int res = fabo(number);
            


            Console.ReadKey();

        }
    }
}
