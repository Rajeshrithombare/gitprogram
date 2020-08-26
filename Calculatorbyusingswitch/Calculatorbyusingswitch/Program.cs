using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float ch;
            float num1, num2, res;

            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for substraction");
            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for divition");
            Console.WriteLine("Enter 5 for Remender");

            ch = Convert.ToSingle(Console.ReadLine());
            num1 = Convert.ToSingle(Console.ReadLine());
            num2 = Convert.ToSingle(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    res = num1 + num2;
                    Console.WriteLine("Result is= " + res);
                    break;

                case 2:
                    res = num1 - num2;
                    Console.WriteLine("Result is= " + res);
                    break;

                case 3:
                    res = num1 * num2;
                    Console.WriteLine("Result is= " + res);
                    break;

                case 4:
                    if(num1>num2)
                    {
                        res = num1 / num2;
                        Console.WriteLine("Result is= " + res);
                    }
                    else
                    {
                        res = num2 / num1;
                        Console.WriteLine("Result is= " + res);

                    }
                    break;

                case 5:
                    if(num1>num2)
                    {
                        res = num1 % num2;
                        Console.WriteLine("Result is= " + res);
                    }
                    else
                    {
                        res = num2 % num1;
                        Console.WriteLine("Result is= " + res);

                    }
                    break;

                default:
                    Console.WriteLine("Number invalid");
                    break;
            }

            Console.ReadKey();
        }
    }
}
