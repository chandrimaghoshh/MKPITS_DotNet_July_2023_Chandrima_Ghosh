﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvaildCastException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Chandrima");
            sb.Append("Ghosh");
            Console.WriteLine("Sb = " + sb.ToString());
            object obj = sb;
            Console.WriteLine("Obj = " + obj.ToString());

            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
