using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_ByZero_Exception_Temp
{
    public class TempException : ApplicationException
    {
        public TempException(string message) :base (message)

        {

        }
    }
    class Temperature
    {
        int temp = 0;
        public void showtemp()
        {
            if(temp == 0)
            {
                throw (new TempException("Zero Temprature found"));
            }
            else
            {
                Console.WriteLine("Temperature {0}",temp);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            try
            {
                t.showtemp();
            }
            catch(TempException e)
            {
                Console.WriteLine("Temperature exception : "+ e.Message);
            }
            Console.ReadKey();
        }
    }
}
