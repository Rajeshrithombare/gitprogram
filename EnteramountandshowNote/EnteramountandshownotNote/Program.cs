using System;

namespace Note
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount, total;
            Console.WriteLine("Enter the amount");
            amount = int.Parse(Console.ReadLine());
            total = amount / 100;
            Console.WriteLine("the 100 ropis= " + total);

            amount = amount-(total*100);           
            total=amount/ 50;
            Console.WriteLine("this is 50 Rupis= "+total);

            amount = amount - (total * 50);
            total = amount / 20;
            Console.WriteLine("this is 20 rupies= "+total);

            amount = amount - (total * 20);
            total = amount / 10;
            Console.WriteLine("this is 10 rupis=  "+total);

            amount = amount - (total * 10);
            total = amount / 5;
            Console.WriteLine("this is 5 rupis=  " + total);          
            Console.ReadKey();
        }
    }
}
