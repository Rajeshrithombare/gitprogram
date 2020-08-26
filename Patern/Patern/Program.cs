using System;

namespace Patern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, size;
            size = Convert.ToInt32(Console.ReadLine());
            for(i=size;i>=1;i--)
            {
                for(j=0;j<=i;j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
