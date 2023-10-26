using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            char[] ch = new char[3];

            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine("Enter Character : ");
                ch[cnt] = Convert.ToChar(Console.ReadLine());
            }
            for(int cnt = 0; cnt<3; cnt++)
            {
                Console.Write("{0}", ch[cnt]);
            }
            Console.ReadKey();
        }
    }
}
