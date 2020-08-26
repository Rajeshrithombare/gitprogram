using System;

namespace logtoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int intvalue = 123;

            long longvalue = (int)intvalue;

            Console.WriteLine("{0}={1}" +intvalue, longvalue);

            Console.ReadKey();
        }
    }
}
