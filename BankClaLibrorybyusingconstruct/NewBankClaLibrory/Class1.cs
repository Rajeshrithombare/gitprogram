using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankClaLibrary
{
   public class Account
    {
        public int ANumber { get; set; }
        public double Balence { get; set; }

        public Account()
        {
            Balence = 1000;
        }
        public virtual string Deposite(int amt)
        {
            return "hellow from Deposite Account class Method";
        }
        public string Showdata()
        {
            return "Account Number is" + ANumber + "Account Balence is" + Balence;

        }

   public  class Saving:Account
        {
            public double intrest { get; set;}

            public override string Deposite(int amt)
            {
                Balence = Balence + amt + intrest;
                return "Ammount deposited suscessfully Balence is= " + Balence;
            }
        }
    
    }
    public class Class1
    {

    }
}
