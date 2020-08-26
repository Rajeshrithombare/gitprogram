using System;

namespace ConversionImplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            int intvalue = 123;

            long longvalue = intvalue;

            Console.WriteLine("{0}={1}", intvalue, longvalue);

            Console.ReadKey();
        }
    }
}
