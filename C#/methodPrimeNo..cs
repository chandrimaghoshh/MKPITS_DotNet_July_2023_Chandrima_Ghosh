using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodPrimeNo
{
    class Program
    {
        static int prime(int num)
        {
            int flag = 0;
            int cnt = 2;
            while (cnt < num)
            {
                if (num % cnt == 0)
                {
                    flag = 1;

                    break;
                }
                cnt++;
            }
                if (flag == 0)
                {
                    Console.WriteLine("Number is Prime");
                }
                else
                {
                    Console.WriteLine("Number is not Prime");
                }
                return cnt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int flag = prime(num);

            Console.ReadKey();
        }
    }
}
