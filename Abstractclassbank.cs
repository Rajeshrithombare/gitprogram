using System;

namespace Assi16Abstract2
{//Abstract2
   abstract class Bank
    {
        
        public abstract void getBalence();
       
       
    }
    class BankA
    {
        public int Balence = 1000;
        public  void getBalence()
        {
            Balence = Balence+100;
            Console.WriteLine("Balence of class A is $" + Balence);

        }
    }
    class BankB
    {
        public int Balence = 1000;
        public  void getBalence()
        {
            Balence = Balence + 150;
            Console.WriteLine("Balence of class B is $" + Balence);
        }

    }
    class BankC
    {
        public int Balence = 1000;
        public void getBalence()
        {
            Balence = Balence + 200;
            Console.WriteLine("Balence of class C is $" + Balence);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankA A = new BankA();
            A.getBalence();
            BankB B = new BankB();
            B.getBalence();
            BankC C = new BankC();
            C.getBalence();
            Console.ReadKey();
        }
    }
}
