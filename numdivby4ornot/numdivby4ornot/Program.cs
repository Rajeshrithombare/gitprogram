using System;

namespace numdivby4ornot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 4==0)

                Console.WriteLine("Number is divisible by 4");

            else
                Console.WriteLine("Number is not divisible by 4");

            Console.ReadKey();

        }
    }
}
