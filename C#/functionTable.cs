using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodTable
{
    class Program
    {
        static int table(int num)
        {
            int res = 0;
            int cnt=1;
            while(cnt <= 10)
            {
                res = num * cnt;
           
                Console.WriteLine(num + " * " + cnt + " = " + res + "\n");
                cnt++;
            }


            return res;
        }
        static void Main(string[] args)
        {
            int cnt = 1;
            Console.WriteLine("Enter Num : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int res = table(num);

            Console.ReadKey();
        }
    }
}
