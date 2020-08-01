using System;

namespace ArrayObject
{
  public  class student
    {
        public decimal bal=100;
        public decimal intrest=200;
        public string name;

        public void Array(string n,decimal amnt)
        {
            name = n;
            bal = bal + amnt + intrest;
            Console.WriteLine("amount deposite {0}bal is{1}", name, bal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student[] ba = new student[5];
            for (int i= 0;i<5;i++)
            {
                ba[i] = new student();
                Console.WriteLine("Enter the name and amount");
                ba[i].name = Console.ReadLine();
                decimal amt = decimal.Parse(Console.ReadLine());
                Console.WriteLine("deposite or withdrow");
                string t = Console.ReadLine();
                switch(t)
                {
                    case "deposite":
                        ba[i].Array(ba[i].name, amt);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
