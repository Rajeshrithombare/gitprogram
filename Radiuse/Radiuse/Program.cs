using System;

namespace Radiuse
{
    class Program
    {
        static void Main(string[] args)
        {
            float len, brt;
            int area;

            Console.WriteLine("enter  the lenght");
            len = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the breadth");
            brt = Convert.ToSingle(Console.ReadLine());

            //area = Convert.ToInt32(Console.ReadLine());
            area = Convert.ToInt32(len * brt);

            Console.WriteLine(len);
            Console.WriteLine(brt);

            Console.WriteLine("Area =", + area);


            Console.ReadKey();
          }
    }
}
