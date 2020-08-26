using System;

namespace Interface
{
    interface Account
    {
        public void Deposite(int amt);
    }
    interface Account1:Account
    {
       void ShowBalence();
    }
    class Saving:Account1
    {
        public void Deposite(int amt)
        {
            Console.WriteLine("Deposite");
        }
        public void ShowBalence()
        {
            Console.WriteLine("show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          Account1 act = new Saving();
            act.Deposite(2);


            Console.ReadKey();

        }
    }
}
