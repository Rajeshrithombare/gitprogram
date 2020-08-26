using System;

namespace Opratorswithswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            int res,num1,num2;
            Console.WriteLine("Enter two number");
            Console.WriteLine("Enter + for addition");
            Console.WriteLine("Enter - for substraction");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the oprator");
            op = Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case '+':
                    if (op == '+')
                    {
                        res=num1 + num2;
                        Console.WriteLine("Result is= " + res);
                    }
                    else
                    {

                    }
                    break;

                case '-':
                    if(op=='-')
                    {
                        res = num1 - num2;
                        Console.WriteLine("Result is= " + res);
                    }
                    else
                    {

                    }
                    break;
                default:
                    Console.WriteLine("Invalid oprator");
                    break;
            }
            Console.ReadKey();

        }
    }
}
