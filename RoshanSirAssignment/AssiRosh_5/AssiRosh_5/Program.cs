using System;

namespace AssiRosh_5
{//5    
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            Console.WriteLine("Enter the Arithmatic seriz");
            int range = int.Parse(Console.ReadLine());

            for (int i = 2; i <= range; i++)
            {
                Console.WriteLine("the range is" + sum);
                sum = sum + i;
            }
            Console.ReadKey();
        }
    }
}
