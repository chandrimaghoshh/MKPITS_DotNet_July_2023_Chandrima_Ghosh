using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilePrime2To20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("primeno : 2");
            int num = 3;
            int counter = 2;
            int flag = 0;
            while (num <= 20)
            {
                flag = 0;
                counter = 2;
                while (counter < num)
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }

                if (flag == 0)
                {
                    Console.WriteLine("prime no : {0}", num);
                }
                num++;

            }
            Console.ReadKey();
        }
    }
}
