using System;

namespace Temprature
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp, c;

            Console.WriteLine("Enter the temprature");
            temp = Convert.ToSingle(Console.ReadLine());

                   c = (5.0f / 9.0f) * (temp - 32);

            Console.WriteLine("c=" + c);


            Console.ReadKey();
            
        }
    }
}
