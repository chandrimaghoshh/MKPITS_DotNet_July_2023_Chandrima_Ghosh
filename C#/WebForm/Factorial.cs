using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Factorial
{
    class Factorial
    {
        public int num;
        public int fact = 1;
        public string display(int num)
        {
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return "Factorial : " + fact;
            
        }

    }
}
