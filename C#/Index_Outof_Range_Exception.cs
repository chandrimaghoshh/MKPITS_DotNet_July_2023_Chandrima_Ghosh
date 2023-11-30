using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Outof_Range_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
            try
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("arr : " + arr[i]);
                }
            }
            catch(IndexOutOfRangeException oe)
            {
                Console.WriteLine(oe.ToString());
            }
            catch(Exception oe)
            {
                Console.WriteLine(oe.ToString());
            }
            finally
            {
                Console.WriteLine("Finally block is executing");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
