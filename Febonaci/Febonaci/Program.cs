using System;

namespace Febonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, a = 0, b = 1, c = 0;
            Console.WriteLine("Enter the series size");
            r = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            while(c<=r)
            {
                c = a + b;
                if (c <= r)
                {
                    Console.WriteLine("Seris is =" + c);
                }
                a = b;b = c;

                }
            Console.ReadKey();
            

        }
    }
}
