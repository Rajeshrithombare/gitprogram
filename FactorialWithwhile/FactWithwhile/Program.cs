using System;

namespace FactWithwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1, num;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            while(num>0)
            {
                f = num * f;
                num--;
               
            }
            Console.WriteLine("Factorial is=" + f);

            Console.ReadKey();
        }
    }
}
