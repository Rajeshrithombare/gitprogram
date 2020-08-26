using System;

namespace AssiRosh5_1
{
    class Program
    {
        //Swap two Number without using therd veriabl
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter Number One");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Numbre two");
            num2 = int.Parse(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Number one is="+num1);
            Console.WriteLine("Number two is= "+num2);

            Console.ReadKey();
        }
    }
}
