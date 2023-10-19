using System;
using System.Diagnostics;

namespace nestedFor5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int cnt=1; cnt<=1; cnt++) 
            {
                for(int cnt1=1; cnt1<=cnt; cnt1++)
                {
                    Console.Write(cnt1+"\t");
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
