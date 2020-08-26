using System;

namespace RuntimePolymorphism
{
   abstract class Account
    {
        public int AccountNo { get; set; }
        public double Balence { get; set; }

        public Account()
        {
            Balence = 1000;
        }


        public abstract string Deposite(double amount);
        
        public string ShowBalence()
        {
            return "Balence Amount of Account Number " + AccountNo + "is" + Balence;
        }
    }

    class Saving:Account
    {
        public double Intrest { get; set; }

        public override string Deposite(double amount)
        {
            Intrest = 500;
            Balence = Balence + amount + Intrest;
            return "Saving class Succesfull with Intrest and Balence" + Balence;
        }
    }

    class Current : Account
    {
        //Override the Base class Deposit Method


        public override string Deposite(double amount)
        {
            Balence = Balence + amount;
            return "Current Class Succesfull Without Intrest" + Balence;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int acno;
            double amt;
            Console.WriteLine("Enter the Acount Number");
            acno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Amount");
            amt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type (Saving) or(current)");
            string accounttype = Console.ReadLine();
            String result = null;
            String result1 = null;
            Account act = null;
            //Account act = new Account();
            if (accounttype == "saving")
            {
                act = new Saving(); //call saving with Acount class object
            }
            else if (accounttype == "Current")
            {
                act = new Current();//call current with Acount class object

            }
            act.AccountNo = acno;//for stor the valu af acno to AcccountNo
            result = act.Deposite(amt);
            result1 = act.ShowBalence();

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
