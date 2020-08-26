using System;

namespace AssiRosh26_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, res = 0;

            Console.WriteLine("Enter the number 1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 1");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number 1");
            n3 = int.Parse(Console.ReadLine());

            if(n1<n2+n3&&n2<n1+n3&&n3<n1+n2)
            {
                res = n1 + n2 + n3;
                Console.WriteLine("Make trangle" + res);
            }
            else
            {
                Console.WriteLine("It is not posible for make a trangle");
            }
            Console.ReadKey();
        }
    }
}
