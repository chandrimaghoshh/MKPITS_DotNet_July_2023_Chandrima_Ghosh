using System;

namespace Variable_Length_Parameter_List
{
    class Program
    {
        static int calculate(params int[] num)
        {
            int cnt, total = 0;

            for(cnt =0; cnt <num.Length; cnt++)
            {
                total = total + num[cnt];
            }
            return total;
        }
        static void Main(string[] args)
        {
        int result = calculate (1, 2, 3); //0+1=1, 1+2=3, 3+3=6
        Console.WriteLine("Result : " + result);

        Console.ReadKey();
        }
    }
}
