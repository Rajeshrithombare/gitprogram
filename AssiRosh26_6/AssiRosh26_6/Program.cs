using System;

namespace AssiRosh26_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter the number between 1 to 50");
            num = int.Parse(Console.ReadLine());

            while (num < 50)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is even= "+num);
                }
                num++;
            }
              
                Console.ReadKey();
            
        }
    }
}
