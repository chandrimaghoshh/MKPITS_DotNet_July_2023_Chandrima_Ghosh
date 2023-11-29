using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculate
{
    public class Calculate
    {
        public int addition(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }
        public int substraction(int n1, int n2)
        {
            int res = n1 - n2;
            return res;
        }
        
    }
}
