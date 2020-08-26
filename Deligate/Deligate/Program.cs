using System;

namespace Deligate
{
    class account
    {
        public int balence = 1000;

        public string Deposite(int amt)
        {
            balence = balence + amt;
            return "Deposite bal is= " + balence;
        }
        public string Withdrow(int amt)
        {
            balence = balence - amt;
            return "Withdraw Bal is= " + balence;
        }
    }
    class Program
    {
        //declare Delegate
        public delegate string accountdeligate(int amt);
        private event accountdeligate accountevent;

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Enter the amount");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter you want to Deposite or Withdrow");
            string t = Console.ReadLine();

            account act = new account();
            accountdeligate ad = null;

            switch (t)
            {
                case "Deposite":
                  p.accountevent+=new accountdeligate(act.Deposite);
                    break;

                case "Withdrow":
                   p.accountevent+= new accountdeligate(act.Withdrow);
                    break;

                default:
                    Console.WriteLine("You should be Enter Deposite or Withdrow");
                    break;
            }

                    //calling Daligate
                    if(p.accountevent!=null)
                    { 

                    string result = p.accountevent(amount);
                    Console.WriteLine(result);
                    }


            Console.ReadKey();
            
        }
    }
}
