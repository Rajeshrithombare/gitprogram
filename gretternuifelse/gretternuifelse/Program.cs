﻿using System;

namespace gretternuifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter two Number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Num 1 is greater");
            }
            else
                Console.WriteLine("Num 2 is greater");


            Console.ReadKey();

        }
    }
}
