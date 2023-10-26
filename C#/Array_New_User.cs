using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_New_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            int [] num = new int[3];
            for(int cnt =0; cnt <3; cnt++)
            {
                Console.WriteLine("Enter Num : ");
                num[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for(int cnt=0; cnt <3; cnt++)
            {
                Console.WriteLine("num[{0}] = {1}", cnt, num[cnt]);

            }
            Console.ReadKey();

        }
    }
}
