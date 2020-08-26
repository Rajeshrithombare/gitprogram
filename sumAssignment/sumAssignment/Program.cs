using System;

namespace sumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int res = 0;
            int i;
            Console.WriteLine("Enter 5 array element");
            for(i=0;i<5;i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            for(i=0;i<5;i++)
            {
                res = a[i] + res;

            }
            Console.WriteLine("the sum of element is= "+res);
            Console.ReadKey();
        }
    }
}
