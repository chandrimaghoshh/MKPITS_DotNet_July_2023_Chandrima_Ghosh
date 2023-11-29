using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibraryBank
{
    public abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract string deposit(int amt);
        public string withdrawal(int amt)
        {
            string res = null;
            if(bal < amt)
            {
                res = "insufficient balance for withdrawal money" + bal.ToString();
            }
            else
            {
                bal = bal - amt;
                res = "Successfully withdrawal money from account" + bal.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "Final Balance Amount : " + bal.ToString();
        }
    }
    public class Saving  : Account
    {
        public override string deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            return "Amount Successfully deposit in saving account : "+bal.ToString();
        }
        
    }
    public class Current : Account
    {
        public override string deposit(int amt)
        {
            bal = bal + amt;
            return "Amount Successfully deposit in Current account : " + bal.ToString();
        }

    }
}
