using System;

namespace AssiRosh25_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate distance between two point
            int x1, x2;
            int y1, y2;
            int res;

            Console.WriteLine("Enter value x1");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value x1");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value x1");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value x1");
            y2 = int.Parse(Console.ReadLine());

            res = (x2 - x1) * (x2 - x1) * (y2 - y1) * (y2 - y1);

            Console.WriteLine("distence between two is" + res);

            Console.ReadKey();
        }
    }
}
