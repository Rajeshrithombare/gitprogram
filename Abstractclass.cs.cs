using System;

namespace AbstractClass
{
    abstract class Account
    {
        public abstract void Deposite(int amt);

        public void ShowData()
        {
            Console.WriteLine("balence");
        }
    }
    class Saving:Account
    {
        public override void Deposite(int amt)
        {
            Console.WriteLine("Deposite");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.ShowData();
            act.Deposite(2);
            Console.ReadKey();
        }
    }
}
