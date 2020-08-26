using System;

namespace bhaskers
{
    class Program
    {
        static void Main(string[] args)
        {
            float formula;
            int a, b, c;

            Console.WriteLine("Enter three number");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

                formula=b*b-(4*a*c);

            Console.WriteLine(formula);


            Console.ReadKey();

        }
    }
}
