using System;

namespace Choiseforaddsub
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            int num1, num2, res;

            Console.WriteLine("Ente the 1 for addition");
            Console.WriteLine("Enter 2 for substaction");
            ch = Convert.ToInt32(Console.ReadLine());
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("Result = " + res);
                    break;

                case 2:
                    res = num1 - num2;
                    Console.WriteLine("Result = " + res);
                    break;

                default:
                    Console.WriteLine("Not");
                    break;
            }

            Console.ReadLine();
        }
    }
}
