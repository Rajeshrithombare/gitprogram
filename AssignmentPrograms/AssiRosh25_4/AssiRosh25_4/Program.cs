using System;

namespace AssiRosh25_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, day, wek, yr;

            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            yr = num / 365;
            wek = num / 7;
            day = num % 7;

            Console.WriteLine(yr);
            Console.WriteLine(wek);
            Console.WriteLine(day);

        }
    }
}
