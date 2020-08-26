using System;

namespace Print10number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10, i = 1;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());

            while(i<=num)
            {
                
                i++;
                Console.WriteLine("Number is= " + i);
            }
            Console.ReadKey();

        }
    }
}
