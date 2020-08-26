using System;

namespace Geternumbet3num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Enter three number");

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)

                Console.WriteLine("Number one is gretter");


            else if (n2 > n3)

                Console.WriteLine("Number two is greater");


            else
            {
                Console.WriteLine("Number three is greater");

                Console.ReadKey();
            }
        }
    }
}
